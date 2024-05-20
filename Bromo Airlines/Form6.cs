using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bromo_Airlines
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            numericUpDown1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, numericUpDown1.Text);
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    }
}
