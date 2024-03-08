namespace NiHonGo
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dely_sec = new System.Windows.Forms.NumericUpDown();
            this.auto_next = new System.Windows.Forms.CheckBox();
            this.auto_rewrite = new System.Windows.Forms.CheckBox();
            this.only_one = new System.Windows.Forms.CheckBox();
            this.cheet = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dely_sec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 30F);
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(28, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "答案";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dely_sec);
            this.groupBox2.Controls.Add(this.auto_next);
            this.groupBox2.Controls.Add(this.auto_rewrite);
            this.groupBox2.Controls.Add(this.only_one);
            this.groupBox2.Controls.Add(this.cheet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(529, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "題目";
            // 
            // dely_sec
            // 
            this.dely_sec.Location = new System.Drawing.Point(410, 81);
            this.dely_sec.Name = "dely_sec";
            this.dely_sec.Size = new System.Drawing.Size(48, 22);
            this.dely_sec.TabIndex = 8;
            this.dely_sec.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dely_sec.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // auto_next
            // 
            this.auto_next.AutoSize = true;
            this.auto_next.Location = new System.Drawing.Point(393, 66);
            this.auto_next.Name = "auto_next";
            this.auto_next.Size = new System.Drawing.Size(116, 16);
            this.auto_next.TabIndex = 7;
            this.auto_next.Text = "自動換題(延遲秒)";
            this.auto_next.UseVisualStyleBackColor = true;
            this.auto_next.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // auto_rewrite
            // 
            this.auto_rewrite.AutoSize = true;
            this.auto_rewrite.Checked = true;
            this.auto_rewrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auto_rewrite.Location = new System.Drawing.Point(393, 18);
            this.auto_rewrite.Name = "auto_rewrite";
            this.auto_rewrite.Size = new System.Drawing.Size(72, 16);
            this.auto_rewrite.TabIndex = 6;
            this.auto_rewrite.Text = "自動訂正";
            this.auto_rewrite.UseVisualStyleBackColor = true;
            // 
            // only_one
            // 
            this.only_one.AutoSize = true;
            this.only_one.Location = new System.Drawing.Point(393, 35);
            this.only_one.Name = "only_one";
            this.only_one.Size = new System.Drawing.Size(84, 16);
            this.only_one.TabIndex = 5;
            this.only_one.Text = "只能答一次";
            this.only_one.UseVisualStyleBackColor = true;
            this.only_one.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cheet
            // 
            this.cheet.AutoSize = true;
            this.cheet.Location = new System.Drawing.Point(393, 51);
            this.cheet.Name = "cheet";
            this.cheet.Size = new System.Drawing.Size(48, 16);
            this.cheet.TabIndex = 4;
            this.cheet.Text = "作弊";
            this.cheet.UseVisualStyleBackColor = true;
            this.cheet.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 25F);
            this.label3.Location = new System.Drawing.Point(259, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(275, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(152, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 60);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(412, 246);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(563, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "交換題目與答案";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "あいうえお";
            this.Load += new System.EventHandler(this.form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dely_sec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cheet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox only_one;
        private System.Windows.Forms.CheckBox auto_rewrite;
        private System.Windows.Forms.NumericUpDown dely_sec;
        private System.Windows.Forms.CheckBox auto_next;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
    }
}

