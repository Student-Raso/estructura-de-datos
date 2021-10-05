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

    public partial class ADT : Form
    {
        private int c = 0;
        private int r = 0;
        private ADT_1 abstractype1;
        private ADT_2 abstractype2;
        public ADT()
        {
            InitializeComponent();
        }
        private bool validador() 
        {
            switch (Practica_1___Tipos.tipo)
            {
                case "String":
                    return true;
                case "Int":
                    try
                    {
                        int.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {

                        return false;
                    }

                case "Double":
                    try
                    {
                        double.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                case "Char":
                    try
                    {
                        char.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                case "Decimal":
                    try
                    {
                        decimal.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                case "ADT_1":
                    try
                    {
                        
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "ADT_2":
                    try
                    {
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
            }
            return false;
        }

        private void ADT_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Practica_1___Tipos.tipo);
            label3.Text = "El tipo de dato seleccionado es "+ Practica_1___Tipos.tipo;
            dataGridView1.Rows.Add(3);
            if (Practica_1___Tipos.tipo== "ADT_1")
            {
                textBox2.Enabled = true;
                textBox2.Visible = true;
            }
            if (Practica_1___Tipos.tipo == "ADT_2")
            {
                textBox2.Enabled = true;
                textBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validador())
            {
                //MessageBox.Show(Practica_1___Tipos.tipo);
                if (Practica_1___Tipos.tipo=="ADT_1")
                {
                    abstractype1 = new ADT_1(textBox1.Text, textBox2.Text);
                    dataGridView1[c, r].Value = abstractype1.propiedad_1+Environment.NewLine+abstractype1.propiedad_2;
                }
                else if (Practica_1___Tipos.tipo == "ADT_2")
                {
                    abstractype2 = new ADT_2(textBox1.Text, textBox2.Text);
                    dataGridView1[c, r].Value = abstractype2.propiedad_3 + Environment.NewLine + abstractype2.propiedad_4;
                }

                else
                {
                    dataGridView1[c, r].Value = textBox1.Text;
                }
                
                c++;
                if (c == 3)
                {
                    r++;
                    if (r > 2)
                    {
                        button1.Enabled = false;
                    }
                    c = 0;
                }
                if (r > 2)
                {
                    label1.Text = $"Elemento [2,2] =";
                }
                else
                {
                    label1.Text = $"Elemento [{c},{r}] =";
                }
                textBox1.Clear();
                textBox1.Focus();
                textBox2.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Elemento [0, 0] =";
            c = 0;
            r = 0;
            button1.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(3);
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
