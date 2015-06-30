using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32 (textBox1.Text);
            b = Convert.ToInt32(textBox2.Text );


            if (listBox1.SelectedIndex == 0)
                c = a + b;
            else if (listBox1.SelectedIndex == 1)
                c = a - b;
            else if (listBox1.SelectedIndex == 2)
                c = a * b;
            else
                c = a / b;



            if (checkBox1.Checked == true)
                c = c * c;

            textBox3.Text = Convert.ToString(c);
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label2.Text = "karesi alındı";
            else
                label2.Text = "karesi alınmadı";

            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();

        }
    }
}
