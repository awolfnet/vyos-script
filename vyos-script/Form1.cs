using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyos_script
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for(i=0;i<listBox1.Items.Count-1;i++)
            {
                listBox1.SelectedIndex = i;

                textBox1.Text += String.Format(textBox2.Text, listBox1.Text, listBox1.Text, listBox1.Text);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString()+"/"+listBox1.Items.Count.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
