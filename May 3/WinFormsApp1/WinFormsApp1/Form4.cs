using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("select country");
            comboBox1.Items.Add("Nepal");
            comboBox1.Items.Add("USA");

            Student s1 = new Student() { Roll_No = 1, Name = "Rock" };

            Student s2 = new Student() { Roll_No = 2, Name = "John" };

            students.Add(s1);
            students.Add(s2);
            dataGridView1.DataSource = students;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Rdo_mail.Checked)
            {
                MessageBox.Show("You're Mail");
            }
            else
                MessageBox.Show("You're Female");
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Student student = new Student() { Roll_No = Convert.ToInt32(textBox1.Text), Name = textBox2.Text };
                students.Add(student);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
                MessageBox.Show(null, "Hello WOrld", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
                textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
