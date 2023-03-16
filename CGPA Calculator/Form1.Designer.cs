namespace CGPA_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.course_comboBox = new System.Windows.Forms.ComboBox();
            this.Mids = new System.Windows.Forms.Label();
            this.Mid_textBox = new System.Windows.Forms.TextBox();
            this.Finals = new System.Windows.Forms.Label();
            this.qz = new System.Windows.Forms.Label();
            this.qz_3 = new System.Windows.Forms.Label();
            this.qz_2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Final_textBox = new System.Windows.Forms.TextBox();
            this.qz_1_Textbox = new System.Windows.Forms.TextBox();
            this.qz_2_textBox = new System.Windows.Forms.TextBox();
            this.qz_3_textBox = new System.Windows.Forms.TextBox();
            this.qz_4_textBox = new System.Windows.Forms.TextBox();
            this.Att = new System.Windows.Forms.Label();
            this.Att_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.result_listbox = new System.Windows.Forms.ListBox();
            this.gpa_Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(358, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CGPA CALCULATOR\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(173, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "COURSE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // course_comboBox
            // 
            this.course_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course_comboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_comboBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Items.AddRange(new object[] {
            "CSE 4203",
            "CSE 4205",
            "Hum 4247",
            "Hum 4249",
            "Math 4241",
            "SWE 4201",
            "CSE 4206",
            "Hum 4245",
            "SWE 4202"});
            this.course_comboBox.Location = new System.Drawing.Point(312, 196);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(121, 21);
            this.course_comboBox.TabIndex = 2;
            this.course_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mids
            // 
            this.Mids.AutoSize = true;
            this.Mids.BackColor = System.Drawing.Color.Transparent;
            this.Mids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mids.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mids.ForeColor = System.Drawing.Color.Chocolate;
            this.Mids.Location = new System.Drawing.Point(173, 230);
            this.Mids.Name = "Mids";
            this.Mids.Size = new System.Drawing.Size(89, 21);
            this.Mids.TabIndex = 3;
            this.Mids.Text = "MID TERM";
            // 
            // Mid_textBox
            // 
            this.Mid_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid_textBox.Location = new System.Drawing.Point(312, 230);
            this.Mid_textBox.Name = "Mid_textBox";
            this.Mid_textBox.Size = new System.Drawing.Size(121, 22);
            this.Mid_textBox.TabIndex = 4;
            this.Mid_textBox.TextChanged += new System.EventHandler(this.Mid_textBox_TextChanged);
            // 
            // Finals
            // 
            this.Finals.AutoSize = true;
            this.Finals.BackColor = System.Drawing.Color.Transparent;
            this.Finals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finals.ForeColor = System.Drawing.Color.Chocolate;
            this.Finals.Location = new System.Drawing.Point(173, 263);
            this.Finals.Name = "Finals";
            this.Finals.Size = new System.Drawing.Size(55, 21);
            this.Finals.TabIndex = 5;
            this.Finals.Text = "FINAL";
            // 
            // qz
            // 
            this.qz.AutoSize = true;
            this.qz.BackColor = System.Drawing.Color.Transparent;
            this.qz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz.ForeColor = System.Drawing.Color.Chocolate;
            this.qz.Location = new System.Drawing.Point(173, 298);
            this.qz.Name = "qz";
            this.qz.Size = new System.Drawing.Size(62, 21);
            this.qz.TabIndex = 6;
            this.qz.Text = "QUIZ 1";
            // 
            // qz_3
            // 
            this.qz_3.AutoSize = true;
            this.qz_3.BackColor = System.Drawing.Color.Transparent;
            this.qz_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qz_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_3.ForeColor = System.Drawing.Color.Chocolate;
            this.qz_3.Location = new System.Drawing.Point(173, 366);
            this.qz_3.Name = "qz_3";
            this.qz_3.Size = new System.Drawing.Size(62, 21);
            this.qz_3.TabIndex = 7;
            this.qz_3.Text = "QUIZ 3";
            // 
            // qz_2
            // 
            this.qz_2.AutoSize = true;
            this.qz_2.BackColor = System.Drawing.Color.Transparent;
            this.qz_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qz_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_2.ForeColor = System.Drawing.Color.Chocolate;
            this.qz_2.Location = new System.Drawing.Point(173, 331);
            this.qz_2.Name = "qz_2";
            this.qz_2.Size = new System.Drawing.Size(62, 21);
            this.qz_2.TabIndex = 8;
            this.qz_2.Text = "QUIZ 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(174, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "QUIZ 4";
            // 
            // Final_textBox
            // 
            this.Final_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Final_textBox.Location = new System.Drawing.Point(312, 263);
            this.Final_textBox.Name = "Final_textBox";
            this.Final_textBox.Size = new System.Drawing.Size(121, 22);
            this.Final_textBox.TabIndex = 10;
            // 
            // qz_1_Textbox
            // 
            this.qz_1_Textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_1_Textbox.Location = new System.Drawing.Point(312, 298);
            this.qz_1_Textbox.Name = "qz_1_Textbox";
            this.qz_1_Textbox.Size = new System.Drawing.Size(121, 22);
            this.qz_1_Textbox.TabIndex = 11;
            // 
            // qz_2_textBox
            // 
            this.qz_2_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_2_textBox.Location = new System.Drawing.Point(312, 331);
            this.qz_2_textBox.Name = "qz_2_textBox";
            this.qz_2_textBox.Size = new System.Drawing.Size(121, 22);
            this.qz_2_textBox.TabIndex = 12;
            // 
            // qz_3_textBox
            // 
            this.qz_3_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_3_textBox.Location = new System.Drawing.Point(312, 366);
            this.qz_3_textBox.Name = "qz_3_textBox";
            this.qz_3_textBox.Size = new System.Drawing.Size(121, 22);
            this.qz_3_textBox.TabIndex = 13;
            // 
            // qz_4_textBox
            // 
            this.qz_4_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_4_textBox.Location = new System.Drawing.Point(312, 401);
            this.qz_4_textBox.Name = "qz_4_textBox";
            this.qz_4_textBox.Size = new System.Drawing.Size(121, 22);
            this.qz_4_textBox.TabIndex = 14;
            // 
            // Att
            // 
            this.Att.AutoSize = true;
            this.Att.BackColor = System.Drawing.Color.Transparent;
            this.Att.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Att.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Att.ForeColor = System.Drawing.Color.Chocolate;
            this.Att.Location = new System.Drawing.Point(173, 437);
            this.Att.Name = "Att";
            this.Att.Size = new System.Drawing.Size(115, 21);
            this.Att.TabIndex = 15;
            this.Att.Text = "ATTENDANCE";
            // 
            // Att_textBox
            // 
            this.Att_textBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Att_textBox.Location = new System.Drawing.Point(312, 437);
            this.Att_textBox.Name = "Att_textBox";
            this.Att_textBox.Size = new System.Drawing.Size(121, 22);
            this.Att_textBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Chocolate;
            this.label10.Location = new System.Drawing.Point(501, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Result:";
            // 
            // result_listbox
            // 
            this.result_listbox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.result_listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_listbox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.result_listbox.FormattingEnabled = true;
            this.result_listbox.ItemHeight = 17;
            this.result_listbox.Location = new System.Drawing.Point(505, 218);
            this.result_listbox.Name = "result_listbox";
            this.result_listbox.Size = new System.Drawing.Size(458, 223);
            this.result_listbox.TabIndex = 18;
            // 
            // gpa_Label
            // 
            this.gpa_Label.AutoSize = true;
            this.gpa_Label.BackColor = System.Drawing.Color.Transparent;
            this.gpa_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_Label.ForeColor = System.Drawing.Color.Peru;
            this.gpa_Label.Location = new System.Drawing.Point(500, 496);
            this.gpa_Label.Name = "gpa_Label";
            this.gpa_Label.Size = new System.Drawing.Size(90, 32);
            this.gpa_Label.TabIndex = 22;
            this.gpa_Label.Text = "CGPA :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1077, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "-At IUT, CGPA matters";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Coral;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear.Location = new System.Drawing.Point(176, 496);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 25;
            this.clear.Text = "CLEAR";
            this.clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(358, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PapayaWhip;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(177, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "SUBMIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(963, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "-At IUT, CGPA matters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1189, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gpa_Label);
            this.Controls.Add(this.result_listbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Att_textBox);
            this.Controls.Add(this.Att);
            this.Controls.Add(this.qz_4_textBox);
            this.Controls.Add(this.qz_3_textBox);
            this.Controls.Add(this.qz_2_textBox);
            this.Controls.Add(this.qz_1_Textbox);
            this.Controls.Add(this.Final_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qz_2);
            this.Controls.Add(this.qz_3);
            this.Controls.Add(this.qz);
            this.Controls.Add(this.Finals);
            this.Controls.Add(this.Mid_textBox);
            this.Controls.Add(this.Mids);
            this.Controls.Add(this.course_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Form1";
            this.Text = "CGPA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox course_comboBox;
        private System.Windows.Forms.Label Mids;
        private System.Windows.Forms.TextBox Mid_textBox;
        private System.Windows.Forms.Label Finals;
        private System.Windows.Forms.Label qz;
        private System.Windows.Forms.Label qz_3;
        private System.Windows.Forms.Label qz_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Final_textBox;
        private System.Windows.Forms.TextBox qz_1_Textbox;
        private System.Windows.Forms.TextBox qz_2_textBox;
        private System.Windows.Forms.TextBox qz_3_textBox;
        private System.Windows.Forms.TextBox qz_4_textBox;
        private System.Windows.Forms.Label Att;
        private System.Windows.Forms.TextBox Att_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox result_listbox;
        private System.Windows.Forms.Label gpa_Label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}

