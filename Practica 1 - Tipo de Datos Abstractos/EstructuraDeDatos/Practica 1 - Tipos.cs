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
    public partial class Practica_1___Tipos : Form
    {
        public static string tipo = "";
        public Practica_1___Tipos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                tipo = "String";
            }
            else if (radioButton2.Checked)
            {
                tipo = "Int";
            }
            else if (radioButton3.Checked)
            {
                tipo = "Double";
            }
            else if (radioButton4.Checked)
            {
                tipo = "Char";
            }
            else if (radioButton5.Checked)
            {
                tipo = "Decimal";
            }
            else if (radioButton6.Checked)
            {
                tipo = "ADT_1";
            }
            else if (radioButton7.Checked)
            {
                tipo = "ADT_2";
            }
            //MessageBox.Show(tipo);
            ADT frm = new ADT();
            frm.ShowDialog();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Practica_1___Tipos_Load(object sender, EventArgs e)
        {

        }
    }
}
