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
    public partial class Memorama : Form
    {
        //Declaramos variables de clase
        int []imagenes= {1,1, 2,2, 3,3, 4,4, 5,5, 6,6, 7,7, 8,8};
        private void Voltear(PictureBox imagen, int id)
        {
            imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\"+imagenes[id]+ ".png");
            //if (imagenes[id]==1)
            //{
               // imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\1.png");
            //}
            //if (imagenes[id] == 2)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\2.png");
            //}
            //if (imagenes[id] == 3)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\3.png");
            //}
            //if (imagenes[id] == 4)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\4.png");
            //}
            //if (imagenes[id] == 5)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\5.png");
            //}
            //if (imagenes[id] == 6)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\6.png");
            //}
            //if (imagenes[id] == 7)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\7.png");
            //}
            //if (imagenes[id] == 8)
            //{
            //    imagen.Image = Image.FromFile(@"C:\Users\hello\source\repos\EstructuraDeDatos-GitHub\estructura-de-datos\Practica 1 - Tipo de Datos Abstractos\EstructuraDeDatos\img\8.png");
            //}
        }
        public Memorama()
        {
            InitializeComponent();
        }

        private void Memorama_Load(object sender, EventArgs e)
        {

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
            Voltear(pictureBox5, 4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox6, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox7, 6);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox8, 7);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox9, 8);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox10, 9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox11, 10);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox12, 11);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox13, 12);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox14, 13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox15, 14);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox16, 15);
        }
    }
}
