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
    public partial class NotacionPostFija : Form
    {
        int operando1;
        int operando2;
        Stack<int> pila = new Stack<int>();
        public NotacionPostFija()
        {
            InitializeComponent();
        }
        private void imprimirPila()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pila)
            {
                dataGridView1.Rows.Add(item.ToString());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //el textbox solo acepta numeros del 0 al 9 el * - + /, va a aceptar backspace y enter, todo lo demas no se acepta
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar+" ");
            if(Char.IsNumber(e.KeyChar)) //Al pulsar un numero
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsWhiteSpace(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (e.KeyChar=='+')
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (e.KeyChar == '/')
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            //MessageBox.Show(e.KeyCode + " " + e.KeyData);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode + " " + e.KeyData + " " + e.KeyValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9 7 8 5 6 8 9 * / + * * +";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+ * 8 5 6 8 * * +";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1 2 8 5 6  * * + /";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arreglo = textBox1.Text.Split(' ');
            pila.Clear();
            
            try
            {
                foreach (var item in arreglo)
                {
                    if (item.All(char.IsDigit))
                    {
                        MessageBox.Show("Numero " + item + " va a la pila");
                        pila.Push(int.Parse(item));
                        imprimirPila();
                    }
                    else if (item == "-")
                    {
                        MessageBox.Show(item + " se aplica resta");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 - operando2);
                        imprimirPila();
                    }
                    else if (item == "+")
                    {
                        MessageBox.Show(item + ": se aplica suma");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 + operando2);
                        imprimirPila();

                    }
                    else if (item == "*")
                    {
                        MessageBox.Show(item + ": se aplica multiplicación");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 * operando2);
                        imprimirPila();
                    }
                    else if (item == "/")
                    {
                        MessageBox.Show(item + ": se aplica divición");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 / operando2);
                        imprimirPila();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Caracter Invalido");
                    }
                }
                if (pila.Count == 1)
                {
                    MessageBox.Show("Resultado: " + pila.Peek() + " es correcta");
                }
                else
                {
                    MessageBox.Show("Error en la expresión");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Error: Expresion no valida, revisar valores");
            }
        }
    }
}
