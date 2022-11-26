using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_by_mo_amin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jj_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void textfirstnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textfirstnumber.Text);
            double z = double.Parse(textsecondnumber.Text);
            double result = x + z;
            MessageBox.Show(result.ToString());



        }

        private void textsecondnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textfirstnumber.Text);
            double z = double.Parse(textsecondnumber.Text);
            double result = x * z;
            MessageBox.Show(result.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textfirstnumber.Text);
            double z = double.Parse(textsecondnumber.Text);
            double result = x / z;
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textfirstnumber.Text);
            double z = double.Parse(textsecondnumber.Text);
            double result = x - z;
            MessageBox.Show(result.ToString());
        }
    }
}
