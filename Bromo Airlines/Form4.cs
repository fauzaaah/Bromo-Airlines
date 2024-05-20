using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, numericUpDown1.Text, textBox4.Text);
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void masterMaskapaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.ShowDialog();
        }
    }
}
