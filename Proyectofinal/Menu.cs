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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAuntos_Click(object sender, EventArgs e)
        {
            Veiculos A = new Veiculos();
            A.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();
            C.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas V = new Ventas();
            V.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes R = new Reportes();
            R.Show();
            this.Hide();
        }
    }
}
