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
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.listBox4.Items.Add(textBox1.Text + " " + "metrekare" + " ," + textBox2.Text + " " + "Salon/Oda " + " ," + textBox3.Text + " " + "Banyo " + ".");
            
            MessageBox.Show("İslem Onaylandı..");
            this.Hide();
        }

    }
}
