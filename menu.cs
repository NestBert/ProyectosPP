using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosPP
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void sumaDeDosNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ca = new Form1();
            ca.Show();
        }

        private void promedioDeTresCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Coming soon
        }

        private void promedioDeCincoCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROYECTOSPOO.Promediodecincocalificaciones p5c = new PROYECTOSPOO.Promediodecincocalificaciones();
            p5c.Show();
        }
    }
}
