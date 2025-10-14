namespace CapaPresentación
{
    partial class Pantalla9
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
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 620);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(248, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 553);
            panel3.TabIndex = 26;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(486, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(445, 483);
            dataGridView2.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 483);
            dataGridView1.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Mulish", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(88, 295);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(0, 34);
            textBox4.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 100);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 27);
            label2.Name = "label2";
            label2.Size = new Size(200, 26);
            label2.TabIndex = 27;
            label2.Text = "Detalles del Paciente";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mulish", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(486, 27);
            label1.Name = "label1";
            label1.Size = new Size(206, 26);
            label1.TabIndex = 28;
            label1.Text = "Historial de Admisión";
            // 
            // Pantalla9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pantalla9";
            Text = "Pantalla9";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label1;
    }
}