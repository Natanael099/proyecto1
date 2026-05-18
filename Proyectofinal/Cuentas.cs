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
    public partial class Cuentas : Form
    {

        public static string UsuarioGuardado;
        public static string ContraseñaGuardada;
        public static string rutaArchivo = "Usuarios.txt";
        public Cuentas()
        {
            InitializeComponent();
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioGuardado = textBox1.Text;
            ContraseñaGuardada = textBox2.Text;
            using (StreamWriter sw = new StreamWriter("Usuarios.txt", true))

            {
                sw.WriteLine(UsuarioGuardado + "," + ContraseñaGuardada);
            }

            MessageBox.Show("Datos guardados correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuLogin M = new MenuLogin();
            M.Show();
            this.Hide();
        }
    }
}
