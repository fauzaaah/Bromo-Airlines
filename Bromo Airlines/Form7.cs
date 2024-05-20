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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            numericUpDown1.Text = "";
            numericUpDown2.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, numericUpDown1.Text, numericUpDown2.Text, textBox2.Text);
        }

        private void masterKodePromoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form =new Form7();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form = new Form8();
            form.ShowDialog();
        }
    }
}
