namespace CapaPresentación
{
    partial class Pantalla13
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
            button1 = new Button();
            botonMenu = new Button();
            botonTratamientos = new Button();
            botonClinicas = new Button();
            botonAdministradores = new Button();
            botonMedicos = new Button();
            botonPacientes = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 58);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(botonMenu);
            panel2.Controls.Add(botonTratamientos);
            panel2.Controls.Add(botonClinicas);
            panel2.Controls.Add(botonAdministradores);
            panel2.Controls.Add(botonMedicos);
            panel2.Controls.Add(botonPacientes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 447);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 219);
            button1.Name = "button1";
            button1.Padding = new Padding(1);
            button1.Size = new Size(280, 43);
            button1.TabIndex = 31;
            button1.Text = "Citas";
            button1.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMenu.Location = new Point(3, 18);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(10, 10, 10, 10);
            botonMenu.Size = new Size(277, 48);
            botonMenu.TabIndex = 25;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.SteelBlue;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonTratamientos.ForeColor = Color.White;
            botonTratamientos.Location = new Point(3, 316);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(277, 43);
            botonTratamientos.TabIndex = 30;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = SystemColors.ButtonHighlight;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonClinicas.ForeColor = Color.Black;
            botonClinicas.Location = new Point(3, 170);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(10, 10, 10, 10);
            botonClinicas.Size = new Size(282, 43);
            botonClinicas.TabIndex = 28;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonAdministradores.Location = new Point(3, 268);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(277, 43);
            botonAdministradores.TabIndex = 29;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            botonAdministradores.Click += botonAdministradores_Click;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMedicos.Location = new Point(3, 72);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(10, 10, 10, 10);
            botonMedicos.Size = new Size(277, 43);
            botonMedicos.TabIndex = 26;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonPacientes.Location = new Point(3, 122);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(10, 10, 10, 10);
            botonPacientes.Size = new Size(277, 43);
            botonPacientes.TabIndex = 27;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Mulish", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 58);
            label1.Name = "label1";
            label1.Size = new Size(223, 44);
            label1.TabIndex = 4;
            label1.Text = "Tratamientos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 143);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 7;
            label2.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 143);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(712, 142);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(656, 142);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 8;
            label3.Text = "Filtro";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(948, 133);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(126, 30);
            button2.TabIndex = 10;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(326, 200);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 180);
            dataGridView1.TabIndex = 12;
            // 
            // Pantalla13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pantalla13";
            Text = "Pantalla13";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button botonMenu;
        private Button botonTratamientos;
        private Button botonClinicas;
        private Button botonAdministradores;
        private Button botonMedicos;
        private Button botonPacientes;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}