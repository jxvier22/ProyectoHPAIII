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
            BotonMenu = new Button();
            BotonMedicos = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 89);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(BotonMedicos);
            panel2.Controls.Add(BotonMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 504);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(225, 553);
            panel3.Name = "panel3";
            panel3.Size = new Size(857, 40);
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
            // BotonMenu
            // 
            BotonMenu.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonMenu.Location = new Point(12, 68);
            BotonMenu.Name = "BotonMenu";
            BotonMenu.Size = new Size(213, 37);
            BotonMenu.TabIndex = 0;
            BotonMenu.Text = "Menú";
            BotonMenu.UseVisualStyleBackColor = true;
            // 
            // BotonMedicos
            // 
            BotonMedicos.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonMedicos.Location = new Point(12, 111);
            BotonMedicos.Name = "BotonMedicos";
            BotonMedicos.Size = new Size(213, 37);
            BotonMedicos.TabIndex = 1;
            BotonMedicos.Text = "Medicos";
            BotonMedicos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 154);
            button2.Name = "button2";
            button2.Size = new Size(213, 37);
            button2.TabIndex = 2;
            button2.Text = "Pacientes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 197);
            button3.Name = "button3";
            button3.Size = new Size(213, 37);
            button3.TabIndex = 3;
            button3.Text = "Clínicas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(47, 156, 202);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(47, 156, 202);
            button4.Location = new Point(12, 240);
            button4.Name = "button4";
            button4.Size = new Size(213, 37);
            button4.TabIndex = 4;
            button4.Text = "Citas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 283);
            button5.Name = "button5";
            button5.Size = new Size(213, 37);
            button5.TabIndex = 5;
            button5.Text = "Administradores";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(9, 326);
            button6.Name = "button6";
            button6.Size = new Size(213, 37);
            button6.TabIndex = 6;
            button6.Text = "Tratamientos";
            button6.UseVisualStyleBackColor = true;
            // 
            // Pantalla14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 593);
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
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button BotonMedicos;
        private Button BotonMenu;
    }
}