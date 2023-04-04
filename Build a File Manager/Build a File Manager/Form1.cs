using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_a_File_Manager
{
    public partial class Form1 : Form
    {
        public List<File> files = new List<File>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_file_button_Click(object sender, EventArgs e)
        {
            File temp = new File(file_name_textBox.Text, file_type_comboBox.Text, file_content_textBox.Text);
            files.Add(temp);
            file_name_textBox.Clear();
            file_content_textBox.Clear();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Count; i++)
            {
                if (remove_fileName_textBox.Text == files[i].name)
                {
                    files.RemoveAt(i);
                }
                else
                {
                    MessageBox.Show("Can't find the expected file!");
                }
            }
            remove_fileName_textBox.Clear();
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            for (int i= 0; i < files.Count; i++)
            {
                if (files[i].name == update_fileNAme_textBox.Text)
                {
                    MessageBox.Show("IT is not Editable!");
                }
                else
                {
                    MessageBox.Show("You Can Update the Content!");
                }
            }
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            features_listBox.Items.Clear();
            for(int i=0; i< files.Count; i++)
            {
                if (files[i].name == view_fileName_textBox.Text)
                {
                    view_content_textBox.Text = files[i].content;
                    if (files[i].type == "read-only")
                    {
                        features_listBox.Items.Add("SHARE");
                        features_listBox.Items.Add("PRINT");
                        features_listBox.Items.Add("ARCHIVE");
                    }
                    else
                    {
                        features_listBox.Items.Add("Edit");
                        features_listBox.Items.Add("TRANSLATE");
                        features_listBox.Items.Add("COMPRESS");
                        features_listBox.Items.Add("SHARE");
                        features_listBox.Items.Add("PRINT");
                        features_listBox.Items.Add("ARCHIVE");


                    }
                    
                }
            }
            view_fileName_textBox.Clear();
        }

        private void summary_button_Click(object sender, EventArgs e)
        {
            total_file_textBox.Text= Convert.ToString(files.Count);
            summary_listBox.Items.Clear();
            int x = 0;
            for(int i=0; i< files.Count;i++)
            {
                x += files[i].content.Length;

            }
            memory_textBox.Text = Convert.ToString(x);
            for(int i=0; i<files.Count; i++)
            {
                string s = $"{files[i].name} \t\t {files[i].type} \t\t {files[i].content.Length}";
                summary_listBox.Items.Add(s);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            for(int i=0; i< files.Count; i++)
            {
                if (files[i].name == update_fileNAme_textBox.Text && files[i].type== "editable")
                {
                    files[i].content= new_content_textBox.Text;
                    show_content_textBox.Text = new_content_textBox.Text;
                }
                else
                {
                    MessageBox.Show("UPDATED");
                }
            }
            new_content_textBox.Clear();
        }

        private void file_content_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void file_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_fileName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_fileNAme_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void file_type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void new_content_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_content_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_content_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_fileName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_file_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void memory_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
