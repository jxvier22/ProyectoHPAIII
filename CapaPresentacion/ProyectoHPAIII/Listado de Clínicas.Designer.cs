namespace CapaPresentación
{
    partial class Pantalla14
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
            panel3 = new Panel();
            label1 = new Label();
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
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 89);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(botonTratamientos);
            panel2.Controls.Add(botonMedicos);
            panel2.Controls.Add(botonAdministradores);
            panel2.Controls.Add(botonMenu);
            panel2.Controls.Add(botonClinicas);
            panel2.Controls.Add(botonPacientes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 631);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(225, 680);
            panel3.Name = "panel3";
            panel3.Size = new Size(1055, 40);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Mulish", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 89);
            label1.Name = "label1";
            label1.Size = new Size(121, 55);
            label1.TabIndex = 3;
            label1.Text = "Citas";
            label1.Click += label1_Click;
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.White;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.ForeColor = Color.Black;
            botonTratamientos.Location = new Point(43, 400);
            botonTratamientos.Margin = new Padding(3, 4, 3, 4);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(137, 57);
            botonTratamientos.TabIndex = 17;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Location = new Point(43, 138);
            botonMedicos.Margin = new Padding(3, 4, 3, 4);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(11, 13, 11, 13);
            botonMedicos.Size = new Size(137, 57);
            botonMedicos.TabIndex = 13;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Location = new Point(43, 334);
            botonAdministradores.Margin = new Padding(3, 4, 3, 4);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(137, 57);
            botonAdministradores.TabIndex = 16;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Location = new Point(43, 73);
            botonMenu.Margin = new Padding(3, 4, 3, 4);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(11, 13, 11, 13);
            botonMenu.Size = new Size(137, 57);
            botonMenu.TabIndex = 12;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.White;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Location = new Point(43, 269);
            botonClinicas.Margin = new Padding(3, 4, 3, 4);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(11, 13, 11, 13);
            botonClinicas.Size = new Size(137, 57);
            botonClinicas.TabIndex = 15;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Location = new Point(43, 204);
            botonPacientes.Margin = new Padding(3, 4, 3, 4);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(11, 13, 11, 13);
            botonPacientes.Size = new Size(137, 57);
            botonPacientes.TabIndex = 14;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            // 
            // Pantalla14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla14";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla14";
            Load += Pantalla14_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button botonTratamientos;
        private Button botonMedicos;
        private Button botonAdministradores;
        private Button botonMenu;
        private Button botonClinicas;
        private Button botonPacientes;
    }
}