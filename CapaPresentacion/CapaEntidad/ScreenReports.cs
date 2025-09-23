using System.Windows.Forms;
using System.Drawing;

namespace CapaEntidad.HPA_UI
{
    public partial class ScreenReports : UserControl
    {
        public ScreenReports()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            var lbl = new Label() { Text = "Reportes", Dock = DockStyle.Top, Height = 60, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Padding = new Padding(20, 0, 0, 0) };

            var table = new DataGridView() { Dock = DockStyle.Fill, BackgroundColor = Color.FromArgb(45, 45, 45), ForeColor = Color.White, AllowUserToAddRows = false };
            table.Columns.Add("col1", "ID");
            table.Columns.Add("col2", "Nombre");
            table.Columns.Add("col3", "Estado");
            table.Rows.Add("1", "Elemento A", "Activo");
            table.Rows.Add("2", "Elemento B", "Inactivo");

            this.Controls.Add(table);
            this.Controls.Add(lbl);
        }
    }
}
