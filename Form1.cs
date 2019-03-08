using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carreraLiebreTortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            
            Liebre l1 = new Liebre(5);
            Tortuga t1 = new Tortuga(10);
            txtMostrar.Clear();
            do
            {
                // los animales empiezan a correr
                l1.correr();
                t1.correr();
                txtMostrar.Text += l1.ToString() + "        " + t1.ToString() + Environment.NewLine;
            } while (l1.posicion < 100 && t1.posicion < 100);
            if (l1.posicion >= 100 && t1.posicion >= 100)
            {
                txtMostrar.Text += "EMPATE!!";
            }
            else if (l1.posicion > t1.posicion)
            {
                txtMostrar.Text += "EL GANADOR ES EL CORREDOR #" + l1.numero.ToString();
            }
            else
            {
                txtMostrar.Text += "EL GANADOR ES EL CORREDOR #" + t1.numero.ToString();
            }
        }
    }
}
