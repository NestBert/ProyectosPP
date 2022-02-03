using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosPP.PROYECTOSPOO
{
    public partial class Promediodecincocalificaciones : Form
    {
        public Promediodecincocalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLASES.CLPROMEDIODE5CAL opromedio = new CLASES.CLPROMEDIODE5CAL(double.Parse
                (txtcalificacion1.Text), double.Parse(txtcalificacion2.Text), double.Parse
                (txtcalificacion3.Text), double.Parse(txtcalificacion4.Text), double.Parse(txtcalificacion5.Text));
            txtresultado.Text = opromedio.calculodelpromedio().ToString();
        }
    }
}
