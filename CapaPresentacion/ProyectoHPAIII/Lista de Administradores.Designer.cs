namespace CapaPresentación
{
    partial class Pantalla12
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
            botonTratamientos = new Button();
            botonMedicos = new Button();
            botonAdministradores = new Button();
            botonMenu = new Button();
            botonClinicas = new Button();
            botonPacientes = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.White;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonTratamientos.ForeColor = Color.Black;
            botonTratamientos.Location = new Point(0, 265);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(277, 43);
            botonTratamientos.TabIndex = 23;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMedicos.Location = new Point(0, 68);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(10, 10, 10, 10);
            botonMedicos.Size = new Size(277, 43);
            botonMedicos.TabIndex = 19;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.SteelBlue;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonAdministradores.ForeColor = SystemColors.ButtonHighlight;
            botonAdministradores.Location = new Point(0, 215);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(277, 43);
            botonAdministradores.TabIndex = 22;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMenu.Location = new Point(0, 14);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(10, 10, 10, 10);
            botonMenu.Size = new Size(277, 48);
            botonMenu.TabIndex = 18;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.White;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonClinicas.ForeColor = Color.Black;
            botonClinicas.Location = new Point(0, 166);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(10, 10, 10, 10);
            botonClinicas.Size = new Size(277, 43);
            botonClinicas.TabIndex = 21;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonPacientes.Location = new Point(0, 118);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(10, 10, 10, 10);
            botonPacientes.Size = new Size(277, 43);
            botonPacientes.TabIndex = 20;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 52);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Controls.Add(botonMenu);
            panel2.Controls.Add(botonPacientes);
            panel2.Controls.Add(botonTratamientos);
            panel2.Controls.Add(botonClinicas);
            panel2.Controls.Add(botonMedicos);
            panel2.Controls.Add(botonAdministradores);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 52);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 453);
            panel2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 133);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 27;
            label2.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(462, 133);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(748, 133);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(692, 133);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 28;
            label3.Text = "Filtro";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(934, 126);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(126, 30);
            button1.TabIndex = 30;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Mulish", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 52);
            label1.Name = "label1";
            label1.Size = new Size(274, 44);
            label1.TabIndex = 31;
            label1.Text = "Administradores";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(308, 179);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 180);
            dataGridView1.TabIndex = 32;
            // 
            // Pantalla12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1104, 505);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pantalla12";
            Text = "Pantalla12";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonTratamientos;
        private Button botonMedicos;
        private Button botonAdministradores;
        private Button botonMenu;
        private Button botonClinicas;
        private Button botonPacientes;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}