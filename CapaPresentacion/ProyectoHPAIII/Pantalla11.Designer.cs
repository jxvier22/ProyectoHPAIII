namespace CapaPresentación
{
    partial class Pantalla11
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
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(248, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 561);
            panel3.TabIndex = 23;
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
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 0;
            label1.Text = "Listado de Pacientes";
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Mulish", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(820, 33);
            button7.Name = "button7";
            button7.Size = new Size(98, 31);
            button7.TabIndex = 25;
            button7.Text = "+ Agregar";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(881, 459);
            dataGridView1.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(656, 38);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(600, 38);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 29;
            label3.Text = "Filtro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 39);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 28;
            label2.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 39);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 27;
            // 
            // Pantalla11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla11";
            Text = "Pantalla11";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button button7;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
    }
}