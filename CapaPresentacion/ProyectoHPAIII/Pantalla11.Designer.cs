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
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
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
    }
}