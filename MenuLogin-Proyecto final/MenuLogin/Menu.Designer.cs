namespace MenuLogin
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnVentas = new Button();
            btnProdutos = new Button();
            button5 = new Button();
            button4 = new Button();
            btnClientes = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProdutos);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 341);
            panel1.TabIndex = 0;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(4, 106);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(110, 38);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(4, 150);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(109, 39);
            btnProdutos.TabIndex = 6;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 283);
            button5.Name = "button5";
            button5.Size = new Size(110, 38);
            button5.TabIndex = 5;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 239);
            button4.Name = "button4";
            button4.Size = new Size(110, 38);
            button4.TabIndex = 4;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(4, 195);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(110, 38);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(119, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 341);
            panel2.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 341);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "MotoDrive.S.A.";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button btnClientes;
        private Button btnProdutos;
        private Button btnVentas;
    }
}