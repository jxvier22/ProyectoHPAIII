namespace CapaPresentación
{
    partial class Pantalla8
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
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button7 = new Button();
            richTextBox1 = new RichTextBox();
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 620);
            panel2.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 100);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mulish", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 47);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 0;
            label1.Text = "Agregar Tratamiento";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Mulish", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(88, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 34);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 95);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "ID *";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Mulish", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(88, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(478, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Mulish", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(345, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 34);
            textBox3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 180);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 4;
            label3.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mulish Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(345, 95);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 22;
            label4.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Mulish", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(88, 295);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(0, 34);
            textBox4.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mulish Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 260);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 24;
            label5.Text = "Descripción";
            // 
            // button7
            // 
            button7.Font = new Font("Mulish", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(88, 487);
            button7.Name = "button7";
            button7.Size = new Size(98, 31);
            button7.TabIndex = 25;
            button7.Text = "Guardar";
            button7.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(88, 282);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(478, 185);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(richTextBox1);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(248, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 553);
            panel3.TabIndex = 23;
            // 
            // Pantalla8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla8";
            Text = "Pantalla8";
            Load += Pantalla8_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button7;
        private RichTextBox richTextBox1;
        private Panel panel3;
    }
}