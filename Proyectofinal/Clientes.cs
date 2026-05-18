using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectofinal
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
              
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Show();
        }

        private void btnAuntos_Click(object sender, EventArgs e)
        {
            Veiculos V = new Veiculos();
            V.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas V = new Ventas();
            V.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes R = new Reportes();
            R.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
