using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiHonGo
{
    public partial class form1 : Form
    {


        private string n50a = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをん";
        private string n50ae = ".a.i.u.e.o.ka.ki.ku.ke.ko.sa.shi.su.se.so.ta.chi.tsu.te.to.na.ni.nu.ne.no.ha.hi.fu.he.ho.ma.mi.mu.me.mo.ya.yu.yo.ra.ri.ru.re.ro.wa.wo.n.";
        private string quesion_series_of_word = "";
        private string answer_series_of_word = "";
        private int nouse = 0;
        private int anskey;
        private int[] how_is_going =new int[500];
        private int idx_buffer = 0;
        private int score_un_formated = 0;
        private int score_win_un_formated = 0;

        Random ran = new Random(Guid.NewGuid().GetHashCode());
        public form1()
        {
            InitializeComponent();
            what_the_heck_is_initilize();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nouse++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            score_un_formated++;
            score_refresh();
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            if (auto_rewrite.Checked && !cheet.Checked)
            {
                label2.Visible = false;
            }

            label3.Text = " ";

            bool res_rec = true;
            for(int i = 0; i < quesion_series_of_word.Length; i++)
            {
                    if (how_is_going[i] == 0)
                {
                    res_rec = false;
                }
            }
            if (res_rec)
            {
                for (int i = 0; i < how_is_going.Length; i++)
                {
                    how_is_going[i] = 0;
                }
            }

            int idx = ran.Next(0, quesion_series_of_word.Length);

            while (how_is_going[idx] == 1)
            {
                idx = ran.Next(0, quesion_series_of_word.Length);
            }
            idx_buffer = idx;

            Show_all_stat();

            label1.Text = quesion_series_of_word.Substring(idx, 1);
            int idxOFeng = -1;
            int k = 0;
            string buf = answer_series_of_word;
            
            while(k<idx+1)
            {
                idxOFeng = buf.IndexOf('.');
                buf = buf.Substring(idxOFeng+1);
                k++;
            }
            idxOFeng = buf.IndexOf('.');
            buf = buf.Substring(0, idxOFeng);
            label2.Text = buf;

            anskey = ran.Next(1, 6);

            int give_wrong_ans = 4;
            int w1=-1;
            int w2 = -1;
            int w3 = -1;
            int w4 = -1;
            string ws1="_";
            string ws2 = "_";
            string ws3 = "_";
            string ws4 = "_";
            while (give_wrong_ans > 0)
            {
                int idx1 = ran.Next(0, quesion_series_of_word.Length);
                if ((idx1==idx) || (idx1 == w1) || (idx1 == w2) || (idx1 == w3) || (idx1 == w4))
                {
                    continue;
                }
                else {
                    
                    int idxOFeng1 = -1;
                    int k1 = 0;
                    string buf1 = answer_series_of_word;

                    while (k1 < idx1 + 1)
                    {
                        idxOFeng1 = buf1.IndexOf('.');
                        buf1 = buf1.Substring(idxOFeng1 + 1);
                        k1++;
                    }
                    idxOFeng1 = buf1.IndexOf('.');
                    buf1 = buf1.Substring(0, idxOFeng1);
                    switch (give_wrong_ans)
                    {
                        case 1:
                            ws1=buf1;
                            w1 = idx1;
                            break;
                        case 2:
                            ws2 = buf1;
                            w2 = idx1;
                            break;
                        case 3:
                            ws3 = buf1;
                            w3 = idx1;
                            break;
                        case 4:
                            ws4 = buf1;
                            w4 = idx1;
                            break;
                        

                    }
                    
                    give_wrong_ans--;
                }
            }


            switch (anskey)
            {
                case 1:
                    button1.Text = buf;

                    
                    button2.Text = ws1;
                    button3.Text = ws2;
                    button4.Text = ws3;
                    button5.Text = ws4;
                    break;
                case 2:
                    button2.Text = buf;

                    button1.Text = ws1;
                   
                    button3.Text = ws2;
                    button4.Text = ws3;
                    button5.Text = ws4;
                    break;
                case 3:
                    button3.Text = buf;

                    button1.Text = ws1;
                    button2.Text = ws2;
                    
                    button4.Text = ws3;
                    button5.Text = ws4;
                    break;
                case 4:
                    button4.Text = buf;

                    button1.Text = ws1;
                    button2.Text = ws2;
                    button3.Text = ws3;
                   
                    button5.Text = ws4;
                    break;
                case 5:
                    button5.Text = buf;

                    button1.Text = ws1;
                    button2.Text = ws2;
                    button3.Text = ws3;
                    button4.Text = ws4;
                   
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans_but_pres(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ans_but_pres(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans_but_pres(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ans_but_pres(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ans_but_pres( 5);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheet.Checked)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;


            }
        }
        private void win()
        {
            how_is_going[idx_buffer] = 1;
            Disable_all_answer_sheet();
             score_win_un_formated ++;

        }

        private void Disable_all_answer_sheet()
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }
        private void Show_all_stat()
        {
            string all_rec = "";
            for (int i = 0; i < quesion_series_of_word.Length; i++)
            {
                all_rec = all_rec + how_is_going[i].ToString();

            }
            string all_rec_plus = "";

            for (int i = 0; i < quesion_series_of_word.Length; i++)
            {
                all_rec_plus = all_rec_plus + quesion_series_of_word.Substring(i, 1) + all_rec.Substring(i, 1) + " ";
                if ((i + 1) % 5 == 0)
                {
                    all_rec_plus = all_rec_plus + "\n";

                }
            }
            label4.Text = all_rec_plus;
        }
        private void ans_but_pres(int ans_key_abcde)
        {
            if (only_one.Checked)
            {
                Disable_all_answer_sheet();
            }
            switch (ans_key_abcde)
            {
                case 1:
                    button1.Enabled = false;

                    break;
                case 2:
                    button2.Enabled = false;

                    break;
                case 3:
                    button3.Enabled = false;

                    break;
                case 4:
                    button4.Enabled = false;

                    break;
                case 5:
                    button5.Enabled = false;

                    break;
            }
            if (anskey == ans_key_abcde)
            {
                win();
                label3.Text = "正確";
            }
            else
            {
                label3.Text = "錯誤";
                if (auto_rewrite.Checked)
                {
                    label2.Visible = true;
                }
            }
            Show_all_stat();
            score_refresh();
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (only_one.Checked)
            {
                cheet.Enabled = false;
                cheet.Checked = false;
            }
            else
            {
                cheet.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nouse++;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (auto_next.Checked)
            {
                dely_sec.Enabled = true;
            }
            else
            {
                dely_sec.Enabled = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            what_the_heck_is_initilize();
            if (
            quesion_series_of_word == n50ae&&
            answer_series_of_word == n50a)
            {
                quesion_series_of_word = n50a;
                answer_series_of_word= n50ae;
            }
            else
            {
                quesion_series_of_word = n50ae;
                answer_series_of_word = n50a;
            }
        }

        private void what_the_heck_is_initilize()
        {
            quesion_series_of_word = n50a;
            answer_series_of_word = n50ae;
            label5.Text = "得分：\n(答對/作答)\n\n百分比：\n_%\n";
            if (auto_next.Checked)
            {
                dely_sec.Enabled = true;
            }
            else
            {
                dely_sec.Enabled = false;

            }
            label2.Visible = false;
            label4.Visible = false;
            checkBox2.Text = "答題狀況";
            button1.Text = "A";
            button2.Text = "B";
            button3.Text = "C";
            button4.Text = "D";
            button5.Text = "E";
            button6.Text = "NEXT";
            label1.Text = "下一題";
            label2.Text = "正解";
            label3.Text = " ";
            label4.Text = " ";

            for (int i = 0; i < how_is_going.Length; i++)
            {
                how_is_going[i] = 0;
            }


        }
        public void score_refresh()
        {

            double sc_temp = (((float)score_win_un_formated / (float)score_un_formated) * 100.0);
            int sc_i = (int)(sc_temp / 1);
            label5.Text = "得分：\n(答對/作答)\n"+score_win_un_formated.ToString()+"/"+score_un_formated.ToString()+"\n百分比：\n"+sc_i.ToString()+"%\n";

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
