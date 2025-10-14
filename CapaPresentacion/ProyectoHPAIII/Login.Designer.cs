namespace ProyectoHPAIII
{
    partial class Pantalla2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = CapaPresentación.Properties.Resources.plant_aesthetic_desktop_ybxs8nd06tkc0whu;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(615, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(665, 725);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mulish", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 146);
            label1.Name = "label1";
            label1.Size = new Size(372, 47);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido de Vuelta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 193);
            label2.Name = "label2";
            label2.Size = new Size(403, 26);
            label2.TabIndex = 2;
            label2.Text = "Ingrese sus datos para acceder a su cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 305);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 3;
            label3.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 333);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 33);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mulish", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 390);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 415);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 33);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mulish", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(367, 451);
            label5.Name = "label5";
            label5.Size = new Size(128, 17);
            label5.TabIndex = 7;
            label5.Text = "Olvidé mi contraseña";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(78, 470);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Recordarme por 30 dias";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mulish", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 546);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(419, 39);
            button1.TabIndex = 32;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pantalla2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private CheckBox checkBox1;
        private Button button1;
    }
}