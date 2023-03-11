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
    public partial class Form5 : Form
    {
        public Form1 frm1;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.listBox4.Items.Add(textBox1.Text + " " + "kat" + " ," + " yalıtım "+textBox2.Text + " " +  " ," + " aidat " +textBox3.Text + " " +  " ," + textBox4.Text + " " + "daire ");
            MessageBox.Show("İslem Onaylandı..");
            this.Hide();
        }

    }
}
