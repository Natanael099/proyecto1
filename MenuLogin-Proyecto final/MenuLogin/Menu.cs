using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLogin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                MessageBox.Show("Bienvenido al menú");
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos();
            p.Show();


        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas V = new Ventas();
            V.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();
            C.Show();
        }
    }
}
