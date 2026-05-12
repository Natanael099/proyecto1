namespace MenuLogin
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cuenta menu = new Cuenta();
            menu.Show();
            

        }

        private void MenuLogin_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Cuenta.rutaArchivo))
            {
                File.Create(Cuenta.rutaArchivo).Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

    }
}
