namespace CapaPresentación
{
    partial class MenuPrincipla
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
            botonMenu = new Button();
            botonMedicos = new Button();
            botonPacientes = new Button();
            botonAdministradores = new Button();
            botonClinicas = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 100);
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
            panel2.Size = new Size(236, 620);
            panel2.TabIndex = 1;
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.White;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonTratamientos.ForeColor = Color.Black;
            botonTratamientos.Location = new Point(41, 295);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1, 1, 1, 1);
            botonTratamientos.Size = new Size(155, 43);
            botonTratamientos.TabIndex = 17;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonMenu.Location = new Point(57, 70);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(10, 10, 10, 10);
            botonMenu.Size = new Size(120, 57);
            botonMenu.TabIndex = 12;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonMedicos.Location = new Point(58, 115);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(10, 10, 10, 10);
            botonMedicos.Size = new Size(120, 54);
            botonMedicos.TabIndex = 13;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonPacientes.Location = new Point(58, 162);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(10, 10, 10, 10);
            botonPacientes.Size = new Size(120, 54);
            botonPacientes.TabIndex = 14;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            botonPacientes.Click += botonPacientes_Click;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAdministradores.Location = new Point(28, 252);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1, 1, 1, 1);
            botonAdministradores.Size = new Size(175, 43);
            botonAdministradores.TabIndex = 16;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.White;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonClinicas.Location = new Point(57, 207);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(10, 10, 10, 10);
            botonClinicas.Size = new Size(120, 53);
            botonClinicas.TabIndex = 15;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mulish", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 129);
            label1.Name = "label1";
            label1.Size = new Size(190, 44);
            label1.TabIndex = 2;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(297, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 173);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Location = new Point(785, 176);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 173);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish Medium", 20F, FontStyle.Bold);
            label2.Location = new Point(13, 122);
            label2.Name = "label2";
            label2.Size = new Size(138, 37);
            label2.TabIndex = 0;
            label2.Text = "Doctores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish Medium", 20F, FontStyle.Bold);
            label3.Location = new Point(19, 122);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 1;
            label3.Text = "Pacientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 424);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(394, 248);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(785, 424);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(394, 248);
            dataGridView2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mulish Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 394);
            label4.Name = "label4";
            label4.Size = new Size(208, 26);
            label4.TabIndex = 7;
            label4.Text = "Medicos Disponibles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mulish Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(785, 395);
            label5.Name = "label5";
            label5.Size = new Size(204, 26);
            label5.TabIndex = 8;
            label5.Text = "Pacientes Recientes";
            // 
            // MenuPrincipla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipla";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
    }
}