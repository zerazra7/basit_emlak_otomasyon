﻿using System;
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
    public partial class Form4 : Form
    {
        public Form1 frm1;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.listBox4.Items.Add(textBox1.Text + " " + "metrekare" + " ," + "mutfak " +textBox2.Text + " " +  " ," + textBox3.Text + " " + " wc var " + " ," + textBox4.Text + " " + "kat bina.");
            MessageBox.Show("İslem Onaylandı..");
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
