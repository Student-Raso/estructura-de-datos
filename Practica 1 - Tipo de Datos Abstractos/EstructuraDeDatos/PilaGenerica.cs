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
    public partial class PilaGenerica : Form
    {
        Stack <String> pila = new Stack <string>();
        public PilaGenerica()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void imprimirPila()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pila)
            {
                dataGridView1.Rows.Add(item.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(textBox1.Text);
            imprimirPila();
            textBox1.Clear();
            textBox1.Focus();
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pila.Count>0)
            {
                pila.Pop();
                imprimirPila();
            }
            else
            {
                label2.Text = "No se puede hace POP, La pila está vacía";
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pila.Clear();
            pila.Push("uno");
            pila.Push("dos");
            pila.Push("tres");
            pila.Push("cuatro");
            pila.Push("cinco");
            pila.Push("seis");
            pila.Push("siete");
            pila.Push("ocho");
            pila.Push("nueve");
            pila.Push("diez");
            imprimirPila();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pila.Clear();
            imprimirPila();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pila.Contains(textBox1.Text))
            {
                MessageBox.Show("Se encontro elemento en la pila");
            }
            else
            {
                MessageBox.Show("No se encontro elemento en la pila");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pila = new Stack<string>(new Stack<string>(pila.Reverse()));
            imprimirPila();
        }
    }
}
