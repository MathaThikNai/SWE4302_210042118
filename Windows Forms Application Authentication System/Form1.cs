using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab09
{
    public partial class Form1 : Form
    {
        public static Form1 form1instance;
        public string username;
        public Form1()
        {
            InitializeComponent();
            form1instance = this;
        }

        private void CreateOneLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string file = "X:\\Project\\SWE4202_210042118\\Windows Forms Application Authentication System\\username&password_list.txt";
            bool flg1 = false;
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                for(int i = 0; i < lines.Length; i++)
                {
                    if (i % 3 == 1 && lines[i] == UserNameTextBox.Text)
                    {
                        if (lines[i + 1] == PasswordTextBox.Text) flg1 = true;
                    }
                }
                if (flg1)
                {
                    username = UserNameTextBox.Text;
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
            }
        }
    }
}
