using System.Windows.Forms;
using System.Drawing;

namespace CapaEntidad.HPA_UI
{
    public partial class ScreenSettings : UserControl
    {
        public ScreenSettings()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            var lbl = new Label() { Text = "Ajustes", Dock = DockStyle.Top, Height = 60, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Padding = new Padding(20, 0, 0, 0) };

            var panel = new FlowLayoutPanel() { Dock = DockStyle.Top, Height = 200, Padding = new Padding(20), FlowDirection = FlowDirection.TopDown };
            panel.Controls.Add(new CheckBox() { Text = "Habilitar notificaciones", ForeColor = Color.White, AutoSize = true });
            panel.Controls.Add(new CheckBox() { Text = "Modo oscuro", ForeColor = Color.White, AutoSize = true });
            panel.Controls.Add(new Button() { Text = "Guardar cambios", Width = 160, Height = 36 });

            this.Controls.Add(panel);
            this.Controls.Add(lbl);
        }
    }
}
