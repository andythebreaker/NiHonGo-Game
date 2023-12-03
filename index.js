const express = require('express');
const multer = require('multer');
const path = require('path');
const low = require('lowdb');
const FileSync = require('lowdb/adapters/FileSync');

const app = express();
const port = 45763;

// Set up Multer for handling file uploads
const storage = multer.diskStorage({
  destination: function (req, file, cb) {
    cb(null, 'uploads/');
  },
  filename: function (req, file, cb) {
    const uniqueSuffix = Date.now() + '-' + Math.round(Math.random() * 1E9);
    const fileName = file.fieldname + '-' + uniqueSuffix + path.extname(file.originalname);

    // Save filename and upload ID to lowdb
    saveToFileDatabase(fileName, req.body.uploadID, Buffer.from(Buffer.from(file.originalname, "latin1").toString("utf8")).toString('base64'));

    cb(null, fileName);
  },
});

const upload = multer({ storage: storage });

// Set up lowdb and create a database
const adapter = new FileSync('db.json');
const db = low(adapter);

// Initialize the database with an empty array
db.defaults({ uploads: [] }).write();

// Function to save filename and upload ID to lowdb
function saveToFileDatabase(fileName, uploadID, originalname) {
  db.get('uploads').push({ fileName, uploadID, originalname }).write();
}

// Serve static files from the 'public' directory
app.use(express.static('public'));

// Define the route to handle multiple file uploads
app.post('/upload', upload.array('files', 5), (req, res) => {
  if (!req.files || req.files.length === 0) {
    return res.status(400).send('No files uploaded.');
  }
  console.log(req.files);
  res.send(`Files uploaded successfully! Upload ID: ${req.body.uploadID}`);
});

app.get('/find/:uploadID', (req, res) => {
  const uploadID = req.params.uploadID;

  // Find the file names in the database that match the uploadID
  const matchingUploads = db.get('uploads').filter({ uploadID }).value();

  if (matchingUploads.length === 0) {
    return res.status(404).send('File not found.');
  }

  // Extract the file names from the matching uploads
  const fileNames = matchingUploads.map(upload =>
  ({
    i: upload.fileName,
    n: upload.originalname
  })
  );

  // Note: In this example, we're not sending the file for download.
  // If you want to send the files, you may need to modify the code accordingly.

  // Send a response (for demonstration purposes)
  res.status(200).json({ fileNames });
});

//download file
app.get('/download/:fileName', (req, res) => {
  const fileName = req.params.fileName;
  const filePath = path.join(__dirname, 'uploads', fileName);
  res.download(filePath, fileName);
});

//delete file
app.get('/delete/:fileName', (req, res) => {
  const fileName = req.params.fileName;
  // const filePath = path.join(__dirname, 'uploads', fileName);
  // fs.unlink(filePath, function (err) {
  //   if (err) {
  //     return res.status(404).send('File not found.');
  //   }
  //delete from database
  db.get('uploads').remove({ fileName }).write();
  res.send(`please refresh the page to see the changes`);
  // });
});

//delete uploadID
app.get('/deleteUploadID/:uploadID', (req, res) => {
  const uploadID = req.params.uploadID;
  //delete from database
  db.get('uploads').remove({ uploadID }).write();
  res.send(`please refresh the page to see the changes`);
});


// Start the server
app.listen(port, () => {
  console.log(`Server is running at http://localhost:${port}`);
});
