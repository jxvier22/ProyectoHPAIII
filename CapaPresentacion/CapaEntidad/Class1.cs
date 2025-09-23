namespace CapaEntidad
{
    // WinForms_Pantallas_From_Figma.cs
    // Plantilla con múltiples pantallas (UserControls) y un MainForm que hace de contenedor.
    // Copia este archivo en tu proyecto C# (Windows Forms). Si ya tienes Program.cs, usa Application.Run(new MainForm());

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using CapaEntidad.HPA_UI;

    namespace HPA_UI
    {
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }

        // MainForm: contiene sidebar y panel de contenido donde se cargan pantallas.
        public class MainForm : Form
        {
            private Panel sidebar;
            private Panel contentPanel;
            private Label titleLabel;
            private FlowLayoutPanel menu;
            private Dictionary<string, Func<UserControl>> screenFactories;
            private Dictionary<string, Button> sidebarButtons;

            public MainForm()
            {
                InitializeComponent();
                // Cargar pantalla inicial
                LoadScreen("Inicio");
            }

            private void InitializeComponent()
            {
                this.Text = "HPA - Aplicación";
                this.WindowState = FormWindowState.Maximized;
                this.BackColor = Color.FromArgb(30, 30, 30);

                sidebar = new Panel() { Dock = DockStyle.Left, Width = 240, BackColor = Color.FromArgb(24, 24, 24) };
                contentPanel = new Panel() { Dock = DockStyle.Fill, BackColor = Color.FromArgb(40, 40, 40) };

                titleLabel = new Label() { Text = "Inicio", Dock = DockStyle.Top, Height = 60, TextAlign = ContentAlignment.MiddleLeft, Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = Color.White, Padding = new Padding(20, 0, 0, 0) };

                // Diccionario de pantallas
                screenFactories = new Dictionary<string, Func<UserControl>>()
                {
                    { "Inicio", () => new ScreenHome() },
                    { "Perfil", () => new ScreenProfile() },
                    { "Reportes", () => new ScreenReports() },
                    { "Ajustes", () => new ScreenSettings() },
                    // Espacio para agregar más pantallas:
                    // { "NuevaPantalla", () => new ScreenNuevaPantalla() },
                };

                // Diccionario de botones
                sidebarButtons = new Dictionary<string, Button>();

                // Orden vertical
                menu = new FlowLayoutPanel() { Dock = DockStyle.Top, FlowDirection = FlowDirection.TopDown, WrapContents = false, Padding = new Padding(0, 20, 0, 0), AutoSize = true };
                foreach (var screen in screenFactories.Keys)
                {
                    var btn = MakeSidebarButton(screen);
                    btn.Click += (s, e) => { titleLabel.Text = screen; LoadScreen(screen); };
                    menu.Controls.Add(btn);
                    sidebarButtons[screen] = btn;
                }
                // Espacio para agregar más botones:
                // var btnNueva = MakeSidebarButton("NuevaPantalla");
                // btnNueva.Click += (s, e) => { titleLabel.Text = "NuevaPantalla"; LoadScreen("NuevaPantalla"); };
                // menu.Controls.Add(btnNueva);
                // sidebarButtons["NuevaPantalla"] = btnNueva;

                sidebar.Controls.Add(menu);

                // Top bar
                var topBar = new Panel() { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(35, 35, 35) };
                topBar.Controls.Add(titleLabel);

                this.Controls.Add(contentPanel);
                this.Controls.Add(sidebar);
                this.Controls.Add(topBar);
            }

            private Button MakeSidebarButton(string text)
            {
                return new Button()
                {
                    Text = "  " + text,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = 240,
                    Height = 48,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(24, 24, 24),
                    Margin = new Padding(0, 6, 0, 0)
                };
            }

            // Carga un UserControl en el panel de contenido (emula navegación entre pantallas del Figma)
            private void LoadScreen(string screenName)
            {
                contentPanel.Controls.Clear();
                if (screenFactories.ContainsKey(screenName))
                {
                    var screen = screenFactories[screenName]();
                    screen.Dock = DockStyle.Fill;
                    contentPanel.Controls.Add(screen);
                }
                // Espacio para lógica adicional al cargar pantallas nuevas
            }
        }

        // Espacio para agregar más pantallas:
        // public class ScreenNuevaPantalla : UserControl
        // {
        //     public ScreenNuevaPantalla()
        //     {
        //         InitializeComponent();
        //     }
        //     private void InitializeComponent()
        //     {
        //         // Tu código aquí
        //     }
        // }
    }

    /*
    Instrucciones rápidas:
    1) Crea un nuevo proyecto Windows Forms (o usa tu proyecto existente). Agrega este archivo .cs al proyecto.
    2) Si tienes otro Program.cs, reemplaza su Application.Run con Application.Run(new HPA_UI.MainForm()); o ajusta el namespace.
    3) Para adaptar el diseño visual exactamente al Figma:
       - Sustituye colores, tipografías e imágenes donde aparezcan los controles.
       - Agrega assets (Project > Add > Existing Item) y usa PictureBox para logos/íconos.
       - Divide cada pantalla en UserControls adicionales si Figma tiene muchas variantes.
    4) Si quieres que genere cada pantalla con precisión (posiciones/paddings exactos), sube capturas de cada pantalla del Figma o el archivo .figma exportado y lo adapto línea a línea.
    */

}
