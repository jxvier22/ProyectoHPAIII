using System.Windows.Forms;
using System.Drawing;

namespace CapaEntidad.HPA_UI
{
    public partial class ScreenHome : UserControl
    {
        public ScreenHome()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            var lbl = new Label() { Text = "Bienvenido al Home", AutoSize = false, Dock = DockStyle.Top, Height = 60, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0) };

            var cardsPanel = new FlowLayoutPanel() { Dock = DockStyle.Top, Height = 180, AutoScroll = true, Padding = new Padding(20) };
            for (int i = 1; i <= 3; i++)
            {
                var card = new Panel() { Width = 300, Height = 140, BackColor = Color.FromArgb(55, 55, 55), Margin = new Padding(10), Padding = new Padding(10) };
                var h = new Label() { Text = "Tarjeta " + i, Dock = DockStyle.Top, Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.White };
                var body = new Label() { Text = "Descripción breve...", Dock = DockStyle.Fill, ForeColor = Color.LightGray };
                card.Controls.Add(body);
                card.Controls.Add(h);
                cardsPanel.Controls.Add(card);
            }

            var mainPanel = new Panel() { Dock = DockStyle.Fill, Padding = new Padding(20) };
            var info = new Label() { Text = "Aquí va contenido principal similar al Figma.", Dock = DockStyle.Top, Height = 200, ForeColor = Color.LightGray };
            mainPanel.Controls.Add(info);

            this.Controls.Add(mainPanel);
            this.Controls.Add(cardsPanel);
            this.Controls.Add(lbl);
        }
    }
}
