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
    public partial class ColaGenerica : Form
    {
        Queue<String> cola = new Queue<string>();
        Queue<int> colaint = new Queue<int>();
        Queue<float> colaFloat = new Queue<float>();
        Queue<bool> colaBool = new Queue<bool>();
        Queue<char> colaChar = new Queue<char>();
        public ColaGenerica()
        {
            InitializeComponent();
        }
        
        private void imprimirCola()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            foreach (var item in cola)
            {
                dataGridView1.Columns.Add("","");
            }
            if (cola.Count > 0)
            {
                dataGridView1.Rows.Add(1);
            }
            int i = 0;
            foreach (var item in cola)
            {
                dataGridView1[i++, 0].Value = item.ToString();
            }
            label3.Text = "La cola contiene " + cola.Count + " elementos";
            if (cola.Count > 0)
            {
                label5.Text = "En el tope de la cola se encuentra: " + cola.Peek();
            }
            else
            {
                label5.Text = "En el tope de la cola se encuentra: Cola vacia";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                cola.Enqueue(textBox1.Text);
                imprimirCola();
                label2.Text = textBox1.Text + " se agrego al tope de la cola";
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cola.Count > 0)
            {
                cola.Dequeue();
                imprimirCola();
            }
            else
            {
                label4.Text = "No se puede hace POP, La COLA está vacía";
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
            cola.Dequeue();
            cola.Enqueue("uno");
            cola.Enqueue("dos");
            cola.Enqueue("tres");
            cola.Enqueue("cuatro");
            cola.Enqueue("cinco");
            cola.Enqueue("seis");
            cola.Enqueue("siete");
            cola.Enqueue("ocho");
            cola.Enqueue("nueve");
            cola.Enqueue("diez");
            imprimirCola();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cola.Clear();
            imprimirCola();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cola.Contains(textBox1.Text))
            {
                MessageBox.Show("Se encontro elemento en la COLA");
            }
            else
            {
                MessageBox.Show("No se encontro elemento en la COLA");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cola = new Queue<string>(new Queue<string>(cola.Reverse()));
            imprimirCola();
        }
    }
}
