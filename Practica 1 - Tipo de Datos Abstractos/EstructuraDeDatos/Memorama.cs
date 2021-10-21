using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EstructuraDeDatos
{
    public partial class Memorama : Form
    {
        //Declaramos variables de clase
        int []imagenes= {1,1, 2,2, 3,3, 4,4, 5,5, 6,6, 7,7, 8,8};
        bool esperando = false;
        int idTemporal = 0;
        PictureBox imagenTemporal = null;
        int intentos = 0;
        int pares = 0;
        private void Voltear(PictureBox imagen, int id)
        {
            imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\"+imagenes[id]+ ".png");
            imagen.Update();

            if (esperando==false)
            {
                imagenTemporal = imagen;
                idTemporal = id;
                imagen.Enabled = false;
                esperando = true;
            }
            else
            {
                intentos ++;
                label1.Text = "INTENTOS = "+intentos;
                if (imagenes[id]==imagenes[idTemporal])
                {
                    MessageBox.Show("Encontramos un par");
                    imagen.Enabled = false;
                    imagenTemporal.Enabled = false;
                    imagen.Visible = false;
                    imagenTemporal.Visible = false;
                    pares ++;
                    label2.Text = "PARES = " + pares;
                    if (pares == 8)
                    {
                        MessageBox.Show("Felicidades, Haz Ganado!!!");
                    }
                }
                else
                {
                    Thread.Sleep(500);
                    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
                    imagenTemporal.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
                    MessageBox.Show("No es un Par");
                    imagen.Update();
                    imagenTemporal.Enabled = true;
                    imagenTemporal.Update();
                }
                esperando = false;
            }

        }
        public Memorama()
        {
            InitializeComponent();
        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            imagenes = imagenes.OrderBy(s=>Guid.NewGuid()).ToArray();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox1, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox2, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox3, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox4, 3);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox8, 4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox7, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox6, 6);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox5, 7);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox12, 8);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox11, 9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox10, 10);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox9, 11);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox16, 12);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox15, 13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox14, 14);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox13, 15);
        }

        private void RESTART_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox6.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox7.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox8.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox9.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox10.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox11.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox12.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox13.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox14.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\amverso.png");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            Memorama_Load(sender, e);
            intentos = 0;
            label1.Text = "INTENTOS = " + intentos;
            pares = 0;
            label2.Text = "PARES = " + pares;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LABEL.Text = string.Join(" , ", imagenes);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
