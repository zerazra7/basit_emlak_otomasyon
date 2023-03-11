using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(maskedTextBox1.Text);
            if (textBox3.Text== "1")
            {
                listBox3.Items.Add(comboBox1.Text + " "+ "Arsa");
            }

            if (textBox3.Text == "2")
            {
                listBox3.Items.Add(comboBox1.Text + " "+ "Daire");
            }

            if (textBox3.Text == "3")
            {
                listBox3.Items.Add(comboBox1.Text + " " + "Konut");
            }

            if (textBox3.Text == "4")
            {
                listBox3.Items.Add(comboBox1.Text + " " + "Apartman");
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox3.Clear();            
            comboBox1.Text = "";

        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text== "1")
            {
                Form2 frm2 = new Form2(); // formdan forma aktarma. form geçişi butonla.
                frm2.frm1 = this;
                frm2.Show();
            }

            else if (textBox3.Text == "2")
            {
                Form3 frm3 = new Form3();
                frm3.frm1 = this;
                frm3.Show();
            }

            else if (textBox3.Text == "3")
            {
                Form4 frm4 = new Form4();
                frm4.frm1 = this;
                frm4.Show();
            }

            else if (textBox3.Text == "4")
            {
                Form5 frm5 = new Form5();
                frm5.frm1 = this;
                frm5.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
