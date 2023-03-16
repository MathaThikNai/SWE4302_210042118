using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA_Calculator
{

    public partial class Form1 : Form
    {
        List<string> codesArrray = new List<string>();
        List<int> totalArray = new List<int>();
        List<double> gpaArray = new List<double>();
        List<string> gradesArray = new List<string>();
        public Form1()
        {
            InitializeComponent();
            result_listbox.Items.Add("Course Code \t Total Marks \t GPA \t Grade");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_TextChanged(object sender, EventArgs e)
        {
            string code = course_comboBox.Text;
            codesArrray.Add(code);
            int mid = Convert.ToInt32(Mid_textBox.Text) / 3;
            int final = Convert.ToInt32(Final_textBox.Text) / 3;
            int att = Convert.ToInt32(Att_textBox.Text) / 3;
            int quiz1 = Convert.ToInt32(qz_1_Textbox.Text);
            int quiz2 = Convert.ToInt32(qz_2_textBox.Text);
            int quiz3 = Convert.ToInt32(qz_3_textBox.Text);
            int quiz4 = Convert.ToInt32(qz_4_textBox.Text);

            int[] qz = new int[4];        
            qz[0] = quiz1;
            qz[1] = quiz2;
            qz[2] = quiz3;
            qz[3] = quiz4;
            Array.Sort(qz);
            int quiz = (qz[1] + qz[2] + qz[3]) / 3;    

            int total = quiz + mid + final + att;      
            totalArray.Add(total);                     

            

            string grade = "a";
            double gpa = 0.0;

            if (total >= 80)
            {
                grade = "A+";
                gpa = 4.00;
            }
            else if (total >= 75 && total < 80)
            {
                grade = "A";
                gpa = 3.75;
            }
            else if (total >= 70 && total < 75)
            {
                grade = "A-";
                gpa = 3.50;
            }
            else if (total >= 65 && total < 70)
            {
                grade = "B+";
                gpa = 3.25;
            }
            else if (total >= 60 && total < 65)
            {
                grade = "B";
                gpa = 3.00;
            }
            else if (total >= 55 && total < 60)
            {
                grade = "B-";
                gpa = 2.75;
            }
            else if (total >= 50 && total < 55)
            {
                grade = "C+";
                gpa = 2.50;
            }
            else if (total >= 45 && total < 50)
            {
                grade = "C";
                gpa = 2.25;
            }
            else if (total >= 40 && total < 45)
            {
                grade = "D";
                gpa = 2.00;
            }
            else
            {
                grade = "F";
                gpa = 0;
            }

            gpaArray.Add(gpa);
            gradesArray.Add(grade);
            MessageBox.Show("Added Successfully. Please Add the next Course. When Done click Final Submit");
            Mid_textBox.Clear();
            Final_textBox.Clear();
            qz_1_Textbox.Clear();
            qz_2_textBox.Clear();
            qz_3_textBox.Clear();
            qz_4_textBox.Clear();
            Att_textBox.Clear();

        }

        private void clear_Click_TextChanged(object sender, EventArgs e)
        {
            Mid_textBox.Clear();
            Final_textBox.Clear();
            qz_1_Textbox.Clear();
            qz_2_textBox.Clear();
            qz_3_textBox.Clear();
            qz_4_textBox.Clear();
            Att_textBox.Clear();
        }
        private void button1_Click_1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Mid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Mid_textBox.Clear();
            Final_textBox.Clear();
            qz_1_Textbox.Clear();
            qz_2_textBox.Clear();
            qz_3_textBox.Clear();
            qz_4_textBox.Clear();
            Att_textBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = course_comboBox.Text;
            codesArrray.Add(code);
            int x=Convert.ToInt32(Mid_textBox.Text);
            int mid = x / 3;
            int final = Convert.ToInt32(Final_textBox.Text) / 3;
            int att = Convert.ToInt32(Att_textBox.Text) / 3;
            int quiz1 = Convert.ToInt32(qz_1_Textbox.Text);
            int quiz2 = Convert.ToInt32(qz_2_textBox.Text);
            int quiz3 = Convert.ToInt32(qz_3_textBox.Text);
            int quiz4 = Convert.ToInt32(qz_4_textBox.Text);

            int[] qz = new int[4];
            qz[0] = quiz1;
            qz[1] = quiz2;
            qz[2] = quiz3;
            qz[3] = quiz4;
            Array.Sort(qz);
            int quiz = (qz[1] + qz[2] + qz[3]) / 3;

            int total = quiz + mid + final + att;
            totalArray.Add(total);



            string grade = "a";
            double gpa = 0.0;

            if (total >= 80)
            {
                grade = "A+";
                gpa = 4.00;
            }
            else if (total >= 75 && total < 80)
            {
                grade = "A";
                gpa = 3.75;
            }
            else if (total >= 70 && total < 75)
            {
                grade = "A-";
                gpa = 3.50;
            }
            else if (total >= 65 && total < 70)
            {
                grade = "B+";
                gpa = 3.25;
            }
            else if (total >= 60 && total < 65)
            {
                grade = "B";
                gpa = 3.00;
            }
            else if (total >= 55 && total < 60)
            {
                grade = "B-";
                gpa = 2.75;
            }
            else if (total >= 50 && total < 55)
            {
                grade = "C+";
                gpa = 2.50;
            }
            else if (total >= 45 && total < 50)
            {
                grade = "C";
                gpa = 2.25;
            }
            else if (total >= 40 && total < 45)
            {
                grade = "D";
                gpa = 2.00;
            }
            else
            {
                grade = "F";
                gpa = 0;
            }

            gpaArray.Add(gpa);
            gradesArray.Add(grade);
            string res = $"{code} \t {total} \t\t {gpa} \t {grade}";
            this.result_listbox.Items.Add(res);
            //MessageBox.Show("Added Successfully. Please Add the next Course. When Done click Final Submit");
            Mid_textBox.Clear();
            Final_textBox.Clear();
            qz_1_Textbox.Clear();
            qz_2_textBox.Clear();
            qz_3_textBox.Clear();
            qz_4_textBox.Clear();
            Att_textBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double sum = 0;
            for (int j = 0; j < gpaArray.Count; j++)
            {
                sum = sum + gpaArray[j];
            }

            double cGPA = sum / (gpaArray.Count);
            cGPA=Math.Round(cGPA, 2);
            string strcgpa = Convert.ToString(cGPA);

            gpa_Label.Text = $"CGPA:  {strcgpa}";
        }
    }
}
