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

        private Label GetLabel2()
        {
            return label2;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Label label2)
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel2.Size = new Size(320, 631);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(320, 680);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 40);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Mulish", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 89);
            label1.Name = "label1";
            label1.Size = new Size(150, 55);
            label1.TabIndex = 3;
            label1.Text = "Clínica";
            label1.Click += label1_Click;
            // 
            // botonTratamientos
            // 
            botonTratamientos.BackColor = Color.White;
            botonTratamientos.BackgroundImageLayout = ImageLayout.None;
            botonTratamientos.FlatAppearance.BorderColor = Color.White;
            botonTratamientos.FlatStyle = FlatStyle.Flat;
            botonTratamientos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonTratamientos.ForeColor = Color.Black;
            botonTratamientos.Location = new Point(0, 400);
            botonTratamientos.Margin = new Padding(3, 4, 3, 4);
            botonTratamientos.Name = "botonTratamientos";
            botonTratamientos.Padding = new Padding(1);
            botonTratamientos.Size = new Size(317, 57);
            botonTratamientos.TabIndex = 17;
            botonTratamientos.Text = "Tratamientos";
            botonTratamientos.UseVisualStyleBackColor = false;
            botonTratamientos.Click += botonTratamientos_Click;
            // 
            // botonMedicos
            // 
            botonMedicos.BackColor = Color.White;
            botonMedicos.FlatAppearance.BorderColor = Color.White;
            botonMedicos.FlatStyle = FlatStyle.Flat;
            botonMedicos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMedicos.Location = new Point(0, 138);
            botonMedicos.Margin = new Padding(3, 4, 3, 4);
            botonMedicos.Name = "botonMedicos";
            botonMedicos.Padding = new Padding(11, 13, 11, 13);
            botonMedicos.Size = new Size(317, 57);
            botonMedicos.TabIndex = 13;
            botonMedicos.Text = "Medicos";
            botonMedicos.UseVisualStyleBackColor = false;
            // 
            // botonAdministradores
            // 
            botonAdministradores.BackColor = Color.White;
            botonAdministradores.FlatAppearance.BorderColor = Color.White;
            botonAdministradores.FlatStyle = FlatStyle.Flat;
            botonAdministradores.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonAdministradores.Location = new Point(-8, 334);
            botonAdministradores.Margin = new Padding(3, 4, 3, 4);
            botonAdministradores.Name = "botonAdministradores";
            botonAdministradores.Padding = new Padding(1);
            botonAdministradores.Size = new Size(325, 57);
            botonAdministradores.TabIndex = 16;
            botonAdministradores.Text = "Administradores";
            botonAdministradores.UseVisualStyleBackColor = false;
            // 
            // botonMenu
            // 
            botonMenu.BackColor = Color.White;
            botonMenu.FlatAppearance.BorderColor = Color.White;
            botonMenu.FlatStyle = FlatStyle.Flat;
            botonMenu.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonMenu.Location = new Point(0, 66);
            botonMenu.Margin = new Padding(3, 4, 3, 4);
            botonMenu.Name = "botonMenu";
            botonMenu.Padding = new Padding(11, 13, 11, 13);
            botonMenu.Size = new Size(317, 64);
            botonMenu.TabIndex = 12;
            botonMenu.Text = "Menú";
            botonMenu.UseVisualStyleBackColor = false;
            // 
            // botonClinicas
            // 
            botonClinicas.BackColor = Color.SteelBlue;
            botonClinicas.FlatAppearance.BorderColor = Color.White;
            botonClinicas.FlatStyle = FlatStyle.Flat;
            botonClinicas.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonClinicas.ForeColor = SystemColors.ButtonHighlight;
            botonClinicas.Location = new Point(0, 269);
            botonClinicas.Margin = new Padding(3, 4, 3, 4);
            botonClinicas.Name = "botonClinicas";
            botonClinicas.Padding = new Padding(11, 13, 11, 13);
            botonClinicas.Size = new Size(317, 57);
            botonClinicas.TabIndex = 15;
            botonClinicas.Text = "Clinicas";
            botonClinicas.UseVisualStyleBackColor = false;
            // 
            // botonPacientes
            // 
            botonPacientes.BackColor = Color.White;
            botonPacientes.FlatAppearance.BorderColor = Color.White;
            botonPacientes.FlatStyle = FlatStyle.Flat;
            botonPacientes.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonPacientes.Location = new Point(0, 204);
            botonPacientes.Margin = new Padding(3, 4, 3, 4);
            botonPacientes.Name = "botonPacientes";
            botonPacientes.Padding = new Padding(11, 13, 11, 13);
            botonPacientes.Size = new Size(317, 57);
            botonPacientes.TabIndex = 14;
            botonPacientes.Text = "Pacientes";
            botonPacientes.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 176);
            label2.Name = "label2";
            label2.Size = new Size(77, 27);
            label2.TabIndex = 5;
            label2.Text = "Buscar";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 178);
            label3.Name = "label3";
            label3.Size = new Size(58, 27);
            label3.TabIndex = 6;
            label3.Text = "Filtro";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(735, 178);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1090, 171);
            button1.Name = "button1";
            button1.Size = new Size(144, 40);
            button1.TabIndex = 8;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(878, 240);
            dataGridView1.TabIndex = 11;
            // 
            // Pantalla14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1280, 720);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;

        // Add this method to your Pantalla14 class (usually in Listado de Clínicas.cs, not the Designer file)
        private void label2_Click(object sender, EventArgs e)
        {
            // You can add any desired logic here, or leave it empty if not needed
        }
    }
}