using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectofinal
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Cuentas.rutaArchivo)) 

                File.Create(Cuentas.rutaArchivo).Close();
               {
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = textBox1.Text;
            string contraseñaIngresada = textBox2.Text;

            bool accesoPermitido = false;

            if (System.IO.File.Exists("Usuarios.txt"))
            {
                using (StreamReader sr = new StreamReader("Usuarios.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');
                        if (partes.Length == 2)
                        {
                            string usuario = partes[0];
                            string contraseña = partes[1];

                            if (usuarioIngresado == usuario && contraseñaIngresada == contraseña)
                            {
                                accesoPermitido = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (accesoPermitido)
            {
                MessageBox.Show("Ingreso exitoso");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cuentas C = new Cuentas();
            C.Show();
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
