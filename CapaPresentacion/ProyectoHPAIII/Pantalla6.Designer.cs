namespace CapaPresentación
{
    partial class Pantalla6
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
            panel2 = new Panel();
            botonTratamientos = new Button();
            botonMedicos = new Button();
            botonAdministradores = new Button();
            botonMenu = new Button();
            botonClinicas = new Button();
            botonPacientes = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(botonTratamientos);
            panel2.Controls.Add(botonMenu);
            panel2.Controls.Add(botonMedicos);
            panel2.Controls.Add(botonPacientes);
            panel2.Controls.Add(botonAdministradores);
            panel2.Controls.Add(botonClinicas);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 581);
            panel2.TabIndex = 1;
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.White;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.ForeColor = Color.Black;
            botonTratamientos.Location = new Point(44, 292);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(120, 43);
            botonTratamientos.TabIndex = 17;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Location = new Point(44, 96);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(10);
            botonMedicos.Size = new Size(120, 43);
            botonMedicos.TabIndex = 13;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Location = new Point(44, 243);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(120, 43);
            botonAdministradores.TabIndex = 16;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Location = new Point(44, 47);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(10);
            botonMenu.Size = new Size(120, 43);
            botonMenu.TabIndex = 12;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.White;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Location = new Point(44, 194);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(10);
            botonClinicas.Size = new Size(120, 43);
            botonClinicas.TabIndex = 15;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Location = new Point(44, 145);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(10);
            botonPacientes.Size = new Size(120, 43);
            botonPacientes.TabIndex = 14;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            // 
            // Pantalla6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla6";
            Text = "Pantalla6";
            Load += Pantalla6_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button botonTratamientos;
        private Button botonMenu;
        private Button botonMedicos;
        private Button botonPacientes;
        private Button botonAdministradores;
        private Button botonClinicas;
    }
}