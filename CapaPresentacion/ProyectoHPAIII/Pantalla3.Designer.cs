namespace CapaPresentación
{
    partial class Pantalla3
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
            botonClinicas = new Button();
            botonMedicos = new Button();
            botonAdministradores = new Button();
            botonPacientes = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            BotonCitas = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel2.Controls.Add(BotonCitas);
            panel2.Controls.Add(botonTratamientos);
            panel2.Controls.Add(botonMenu);
            panel2.Controls.Add(botonClinicas);
            panel2.Controls.Add(botonMedicos);
            panel2.Controls.Add(botonAdministradores);
            panel2.Controls.Add(botonPacientes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 620);
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
            botonTratamientos.Location = new Point(22, 338);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(155, 43);
            botonTratamientos.TabIndex = 23;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.Transparent;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonMenu.ForeColor = Color.Black;
            botonMenu.Location = new Point(38, 66);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(1);
            botonMenu.Size = new Size(120, 44);
            botonMenu.TabIndex = 18;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            botonMenu.Click += botonMenu_Click;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.White;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonClinicas.Location = new Point(37, 203);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(10);
            botonClinicas.Size = new Size(120, 53);
            botonClinicas.TabIndex = 21;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = SystemColors.HotTrack;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonMedicos.ForeColor = Color.White;
            botonMedicos.Location = new Point(0, 111);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(10);
            botonMedicos.Size = new Size(197, 54);
            botonMedicos.TabIndex = 19;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            botonMedicos.Click += botonMedicos_Click;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAdministradores.Location = new Point(12, 289);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(175, 43);
            botonAdministradores.TabIndex = 22;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonPacientes.Location = new Point(38, 158);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(10);
            botonPacientes.Size = new Size(120, 54);
            botonPacientes.TabIndex = 20;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            botonPacientes.Click += botonPacientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Mulish", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 139);
            label1.Name = "label1";
            label1.Size = new Size(265, 44);
            label1.TabIndex = 3;
            label1.Text = "Agregar Médico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Mulish", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 197);
            label2.Name = "label2";
            label2.Size = new Size(86, 26);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Mulish", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(700, 197);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 5;
            label3.Text = "Apellido:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 230);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 35);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(700, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 35);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Mulish", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(238, 303);
            label4.Name = "label4";
            label4.Size = new Size(65, 26);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(238, 332);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 35);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Mulish", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(700, 303);
            label5.Name = "label5";
            label5.Size = new Size(90, 26);
            label5.TabIndex = 10;
            label5.Text = "Cedula: *";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(700, 332);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(400, 35);
            textBox4.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(210, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(1047, 562);
            panel3.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mulish", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 442);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(168, 67);
            button1.TabIndex = 31;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(28, 330);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(862, 80);
            textBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Mulish", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 301);
            label6.Name = "label6";
            label6.Size = new Size(125, 26);
            label6.TabIndex = 13;
            label6.Text = "Especialidad:";
            // 
            // BotonCitas
            // 
            BotonCitas.BackColor = Color.White;
            BotonCitas.FlatAppearance.BorderColor = Color.White;
            BotonCitas.FlatStyle = FlatStyle.Flat;
            BotonCitas.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonCitas.Location = new Point(12, 253);
            BotonCitas.Name = "BotonCitas";
            BotonCitas.Padding = new Padding(1);
            BotonCitas.Size = new Size(175, 43);
            BotonCitas.TabIndex = 24;
            BotonCitas.Text = "Citas";
            BotonCitas.UseVisualStyleBackColor = false;
            // 
            // Pantalla3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla3";
            Text = "Form3";
            Load += Pantalla3_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button botonTratamientos;
        private Button botonMenu;
        private Button botonClinicas;
        private Button botonMedicos;
        private Button botonAdministradores;
        private Button botonPacientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Panel panel3;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Button BotonCitas;
    }
}