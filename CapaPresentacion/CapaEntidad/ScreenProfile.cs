using System.Windows.Forms;
using System.Drawing;

namespace CapaEntidad.HPA_UI
{
    public partial class ScreenProfile : UserControl
    {
        public ScreenProfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            var lbl = new Label() { Text = "Perfil de usuario", Dock = DockStyle.Top, Height = 60, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Padding = new Padding(20, 0, 0, 0) };

            var panel = new Panel() { Dock = DockStyle.Top, Height = 180, Padding = new Padding(20) };
            var avatar = new Panel() { Width = 120, Height = 120, BackColor = Color.FromArgb(70, 70, 70), Margin = new Padding(0, 0, 20, 0) };
            var name = new Label() { Text = "Nombre Apellido", Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White };
            var email = new Label() { Text = "email@ejemplo.com", ForeColor = Color.LightGray };

            var left = new FlowLayoutPanel() { Dock = DockStyle.Left, Width = 400, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(20) };
            left.Controls.Add(avatar);
            var info = new Panel() { Width = 250 };
            info.Controls.Add(name);
            info.Controls.Add(email);
            left.Controls.Add(info);

            this.Controls.Add(left);
            this.Controls.Add(lbl);
        }
    }
}
