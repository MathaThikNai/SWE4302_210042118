using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrollment_Information
{
    public partial class Form1 : Form
    {
        List<Department> departmentList = new List<Department>();
        public Form1()
        {
            InitializeComponent();
            string temp = "";
            temp += $"ID \t Name \t Department \t Section";
            listBox.Items.Add(temp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_dept_button_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.name = dept_name_textbox.Text;
            dep.code = Convert.ToInt32(dept_code_textbox.Text);
            student_comboBox.Items.Add(dep.code);
            departmentList.Add(dep);
        }

        private void admit_student_button_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.id = Convert.ToInt32(id_textbox.Text);
            std.name = name_textbox.Text;
            std.section = section_textbox.Text;
            std.scode = Convert.ToInt32(student_comboBox.Text);

            foreach (Department dep in departmentList)
            {
                if(dep.code == std.scode)
                {
                    dep.stdlis.Add(std);
                }
            }

        }

        private void show_student_button_Click(object sender, EventArgs e)
        {
            int tempcode = Convert.ToInt32(student_comboBox2.Text);
            Department dep2 = new Department();
            
            foreach (Department dep in departmentList)
            {
                if(dep.code == tempcode)
                {
                    dep2 = dep;
                }
            }
            listBox.Items.Clear();

            string tem1 = "";
            tem1 += $"ID \t Name \t Department \t Section";
            listBox.Items.Add(tem1);

            foreach (Student std in dep2.stdlis)
            {
                string temp = "";
                temp += $"{Convert.ToString(std.id)} \t {std.name} \t {dep2.name} \t\t {std.section}";
                listBox.Items.Add(temp);
            }
        }
    }
}
