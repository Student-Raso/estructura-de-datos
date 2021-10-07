using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int limite = int.Parse(textBox1.Text);
                if (limite > 0)
                {
                    MessageBox.Show("Vas Bien");
                }
                else
                {
                    MessageBox.Show("Error, solo se permite enteros positivos");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
