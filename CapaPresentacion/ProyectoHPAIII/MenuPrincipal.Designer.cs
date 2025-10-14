namespace ProyectoHPAIII
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            botonMenu = new Button();
            botonMedicos = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            botonTratamientos = new Button();
            botonAdministradores = new Button();
            botonClinicas = new Button();
            botonPacientes = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Location = new Point(42, 40);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(10);
            botonMenu.Size = new Size(120, 43);
            botonMenu.TabIndex = 0;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            botonMenu.Click += botonMenu_Click;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Location = new Point(42, 89);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(10);
            botonMedicos.Size = new Size(120, 43);
            botonMedicos.TabIndex = 1;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            botonMedicos.Click += Medicos_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 100);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(botonTratamientos);
            panel2.Controls.Add(botonAdministradores);
            panel2.Controls.Add(botonClinicas);
            panel2.Controls.Add(botonPacientes);
            panel2.Controls.Add(botonMenu);
            panel2.Controls.Add(botonMedicos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(1, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 618);
            panel2.TabIndex = 3;
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.White;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.ForeColor = Color.Black;
            botonTratamientos.Location = new Point(42, 285);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(120, 43);
            botonTratamientos.TabIndex = 5;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Location = new Point(42, 236);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(120, 43);
            botonAdministradores.TabIndex = 4;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.White;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Location = new Point(42, 187);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(10);
            botonClinicas.Size = new Size(120, 43);
            botonClinicas.TabIndex = 3;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            botonClinicas.Click += this.botonClinicas_Click;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Location = new Point(42, 138);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(10);
            botonPacientes.Size = new Size(120, 43);
            botonPacientes.TabIndex = 2;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            botonPacientes.Click += this.botonPacientes_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Padding = new Padding(1);
            Text = "Tratamientos";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button botonMenu;
        private Button botonMedicos;
        private Panel panel1;
        private Panel panel2;
        private Button botonPacientes;
        private Button botonAdministradores;
        private Button botonClinicas;
        private Button botonTratamientos;
    }
}
