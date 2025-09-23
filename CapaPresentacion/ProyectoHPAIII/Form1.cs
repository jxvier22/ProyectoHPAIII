<<<<<<< HEAD
// HPA_Screens.cs
// Implementación de pantallas (UserControls) basadas en el PDF "Asignación 1 HPA III".
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HPA
=======
// Esto es una prueba de commit
//pupu
namespace ProyectoHPAIII
>>>>>>> parent of ff80a30 (Cambie el comentario 2)
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

    // ---------------- MainForm (Menu Principal) ----------------
    public class MainForm : Form
    {
        private Panel sidebar;
        private Button bLogin, bAddMedico, bAddPaciente, bAddClinica, bAddCita, bAddAdmin, bAddTratamiento;
        private Button bListPacientes, bListCitas, bListAdmins, bListTratamientos, bListClinicas;
        private Label title;

        public MainForm()
        {
            Text = "Centro Hospitalario Chopper - Administración";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(30, 30, 30);
            Initialize();
            // pantalla por defecto: abrir LoginScreen como ventana
            OpenScreen(new LoginScreen());
        }

        private void Initialize()
        {
            sidebar = new Panel { Dock = DockStyle.Left, Width = 260, BackColor = Color.FromArgb(24, 24, 24) };
            title = new Label { Text = "Inicio", Dock = DockStyle.Top, Height = 60, ForeColor = Color.White, Font = new Font("Segoe UI", 14, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0), BackColor = Color.FromArgb(35, 35, 35) };

            var menu = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, AutoScroll = true, Padding = new Padding(8) };

            bLogin = MakeBtn("Inicio de sesión");
            bAddMedico = MakeBtn("Agregar Médico");
            bAddPaciente = MakeBtn("Agregar Paciente");
            bAddClinica = MakeBtn("Agregar Clínica");
            bAddCita = MakeBtn("Agregar Cita");
            bAddAdmin = MakeBtn("Agregar Administrador");
            bAddTratamiento = MakeBtn("Agregar Tratamiento");
            bListPacientes = MakeBtn("Listado de Pacientes");
            bListCitas = MakeBtn("Listado de Citas");
            bListAdmins = MakeBtn("Listado de Administradores");
            bListTratamientos = MakeBtn("Listado de Tratamientos");
            bListClinicas = MakeBtn("Listado de Clínicas");

            menu.Controls.AddRange(new Control[] {
                bLogin, new Label(){Height=8,BackColor=Color.Transparent},
                bAddMedico, bAddPaciente, bAddClinica, bAddCita, bAddAdmin, bAddTratamiento,
                new Label(){Height=12,BackColor=Color.Transparent},
                bListPacientes, bListCitas, bListAdmins, bListTratamientos, bListClinicas
            });

            sidebar.Controls.Add(menu);

            Controls.Add(sidebar);
            Controls.Add(title);

            // Eventos de navegación
            bLogin.Click += (s, e) => { title.Text = "Inicio de sesión"; OpenScreen(new LoginScreen()); };
            bAddMedico.Click += (s, e) => { title.Text = "Agregar Médico"; OpenScreen(new AddMedicoScreen()); };
            bAddPaciente.Click += (s, e) => { title.Text = "Agregar Paciente"; OpenScreen(new AddPacienteScreen()); };
            bAddClinica.Click += (s, e) => { title.Text = "Agregar Clínica"; OpenScreen(new AddClinicaScreen()); };
            bAddCita.Click += (s, e) => { title.Text = "Agregar Cita"; OpenScreen(new AddCitaScreen()); };
            bAddAdmin.Click += (s, e) => { title.Text = "Agregar Administrador"; OpenScreen(new AddAdminScreen()); };
            bAddTratamiento.Click += (s, e) => { title.Text = "Agregar Tratamiento"; OpenScreen(new AddTratamientoScreen()); };
            bListPacientes.Click += (s, e) => { title.Text = "Listado de Pacientes"; OpenScreen(new ListPacientesScreen()); };
            bListCitas.Click += (s, e) => { title.Text = "Listado de Citas"; OpenScreen(new ListCitasScreen()); };
            bListAdmins.Click += (s, e) => { title.Text = "Listado de Administradores"; OpenScreen(new ListAdminsScreen()); };
            bListTratamientos.Click += (s, e) => { title.Text = "Listado de Tratamientos"; OpenScreen(new ListTratamientosScreen()); };
            bListClinicas.Click += (s, e) => { title.Text = "Listado de Clínicas"; OpenScreen(new ListClinicasScreen()); };
        }

        private Button MakeBtn(string text)
        {
            return new Button
            {
                Text = text,
                Width = 236,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(28, 28, 28),
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0),
                Margin = new Padding(8, 6, 8, 6)
            };
        }

        private void OpenScreen(Form screen)
        {
            screen.StartPosition = FormStartPosition.CenterParent;
            screen.ShowDialog(this);
        }
    }

    // ---------------- LoginScreen ----------------
    public class LoginScreen : Form
    {
        private TextBox txtUser, txtPass;
        public LoginScreen()
        {
            this.Text = "Inicio de sesión";
            this.Size = new Size(500, 350);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(40) };
            var box = new Panel { Width = 420, Height = 260, BackColor = Color.FromArgb(50, 50, 50), Anchor = AnchorStyles.None };
            box.Location = new Point((panel.Width - box.Width) / 2, 40);
            box.Anchor = AnchorStyles.None;

            var lblTitle = new Label { Text = "Iniciar sesión", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Top = 16, Left = 24 };
            var lblUser = new Label { Text = "Usuario (email):", ForeColor = Color.LightGray, Top = 64, Left = 24 };
            txtUser = new TextBox { Top = 86, Left = 24, Width = 360 };
            var lblPass = new Label { Text = "Contraseña:", ForeColor = Color.LightGray, Top = 122, Left = 24 };
            txtPass = new TextBox { Top = 144, Left = 24, Width = 360, UseSystemPasswordChar = true };

            var btnLogin = new Button { Text = "Entrar", Top = 192, Left = 24, Width = 120, Height = 34 };
            btnLogin.Click += BtnLogin_Click;

            box.Controls.AddRange(new Control[] { lblTitle, lblUser, txtUser, lblPass, txtPass, btnLogin });
            panel.Controls.Add(box);
            Controls.Add(panel);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Validar credenciales (conexión BD) - aquí mostramos un stub
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Login OK (stub). Implementar validación contra la tabla ADMINISTRADOR.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // ---------------- AddMedicoScreen ----------------
    public class AddMedicoScreen : Form
    {
        private TextBox txtCed, txtNombre, txtApellido, txtEspecialidad, txtEmail;
        public AddMedicoScreen()
        {
            this.Text = "Agregar Médico";
            this.Size = new Size(500, 350);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Agregar Médico", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            var form = new Panel { Dock = DockStyle.Top, Height = 260, Padding = new Padding(20) };

            txtCed = CreateField("Cédula (entero):", 0);
            txtNombre = CreateField("Nombre:", 1);
            txtApellido = CreateField("Apellido:", 2);
            txtEspecialidad = CreateField("Especialidad:", 3);
            txtEmail = CreateField("Email:", 4);

            var btnSave = new Button { Text = "Guardar médico", Width = 160, Height = 36, Left = 24, Top = 220 };
            btnSave.Click += BtnSave_Click;

            form.Controls.Add(btnSave);
            Controls.Add(form);
            Controls.Add(top);
        }

        private TextBox CreateField(string label, int row)
        {
            var lbl = new Label { Text = label, ForeColor = Color.LightGray, Left = 24, Top = 8 + row * 40, Width = 200 };
            var txt = new TextBox { Left = 24, Top = 28 + row * 40, Width = 420 };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            return txt;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validaciones básicas y stub de guardado
            if (string.IsNullOrWhiteSpace(txtCed.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Cédula y nombre son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // TODO: Insertar en tabla MEDICO en BD
            MessageBox.Show("Médico guardado (stub). Implementar INSERT a la BD.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // ---------------- AddPacienteScreen ----------------
    public class AddPacienteScreen : Form
    {
        private TextBox txtCed, txtNombre, txtApellido, txtEmail, txtTelefono;
        public AddPacienteScreen()
        {
            this.Text = "Agregar Paciente";
            this.Size = new Size(500, 350);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Agregar Paciente", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            var panel = new Panel { Dock = DockStyle.Top, Height = 260, Padding = new Padding(20) };

            txtCed = CreateField("Cédula (entero):", 0);
            txtNombre = CreateField("Nombre:", 1);
            txtApellido = CreateField("Apellido:", 2);
            txtEmail = CreateField("Email:", 3);
            txtTelefono = CreateField("Teléfono:", 4);

            var btnSave = new Button { Text = "Guardar paciente", Width = 160, Height = 36, Left = 24, Top = 220 };
            btnSave.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtCed.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Cédula y nombre obligatorios.");
                    return;
                }
                MessageBox.Show("Paciente guardado (stub). Implementar INSERT en PACIENTE y TELEFONO_PACIENTE.");
            };

            panel.Controls.Add(btnSave);
            Controls.Add(panel);
            Controls.Add(top);
        }

        private TextBox CreateField(string label, int row)
        {
            var lbl = new Label { Text = label, ForeColor = Color.LightGray, Left = 24, Top = 8 + row * 40, Width = 200 };
            var txt = new TextBox { Left = 24, Top = 28 + row * 40, Width = 420 };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            return txt;
        }
    }

    // ---------------- AddClinicaScreen ----------------
    public class AddClinicaScreen : Form
    {
        private TextBox txtNombre, txtDireccion, txtTelefono;
        public AddClinicaScreen()
        {
            this.Text = "Agregar Clínica";
            this.Size = new Size(500, 300);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Agregar Clínica", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            var panel = new Panel { Dock = DockStyle.Top, Height = 180, Padding = new Padding(20) };

            txtNombre = CreateField("Nombre clínica:", 0);
            txtDireccion = CreateField("Dirección:", 1);
            txtTelefono = CreateField("Teléfono:", 2);

            var btnSave = new Button { Text = "Guardar clínica", Width = 160, Height = 36, Left = 24, Top = 140 };
            btnSave.Click += (s, e) => { MessageBox.Show("Clínica guardada (stub). Implementar INSERT en CLINICA."); };

            panel.Controls.Add(btnSave);
            Controls.Add(panel);
            Controls.Add(top);
        }

        private TextBox CreateField(string label, int row)
        {
            var lbl = new Label { Text = label, ForeColor = Color.LightGray, Left = 24, Top = 8 + row * 40, Width = 200 };
            var txt = new TextBox { Left = 24, Top = 28 + row * 40, Width = 420 };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            return txt;
        }
    }

    // ---------------- AddCitaScreen ----------------
    public class AddCitaScreen : Form
    {
        private DateTimePicker dtFecha;
        private DateTimePicker dtHora;
        private ComboBox cbMedico, cbPaciente, cbClinica, cbTratamiento;
        private TextBox txtMotivo;
        private ComboBox cbEstado;
        public AddCitaScreen()
        {
            this.Text = "Agregar Cita";
            this.Size = new Size(600, 400);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Agregar Cita", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            var panel = new Panel { Dock = DockStyle.Top, Height = 320, Padding = new Padding(20) };

            var lblFecha = new Label { Text = "Fecha:", ForeColor = Color.LightGray, Left = 24, Top = 8 };
            dtFecha = new DateTimePicker { Left = 24, Top = 28, Width = 160, Format = DateTimePickerFormat.Short };
            var lblHora = new Label { Text = "Hora:", ForeColor = Color.LightGray, Left = 220, Top = 8 };
            dtHora = new DateTimePicker { Left = 220, Top = 28, Width = 120, Format = DateTimePickerFormat.Time, ShowUpDown = true };

            cbMedico = new ComboBox { Left = 24, Top = 76, Width = 320, DropDownStyle = ComboBoxStyle.DropDownList };
            cbMedico.Items.Add("Seleccione médico (stub)");
            cbPaciente = new ComboBox { Left = 24, Top = 116, Width = 320, DropDownStyle = ComboBoxStyle.DropDownList };
            cbPaciente.Items.Add("Seleccione paciente (stub)");
            cbClinica = new ComboBox { Left = 24, Top = 156, Width = 320, DropDownStyle = ComboBoxStyle.DropDownList };
            cbClinica.Items.Add("Seleccione clínica (stub)");
            cbTratamiento = new ComboBox { Left = 24, Top = 196, Width = 320, DropDownStyle = ComboBoxStyle.DropDownList };
            cbTratamiento.Items.Add("Seleccione tratamiento (stub)");
            txtMotivo = new TextBox { Left = 24, Top = 236, Width = 520, Height = 60, Multiline = true };
            cbEstado = new ComboBox { Left = 360, Top = 28, Width = 160 };
            cbEstado.Items.AddRange(new string[] { "Pendiente", "Confirmada", "Cancelada", "Completada" });
            cbEstado.SelectedIndex = 0;

            var btnSave = new Button { Text = "Agendar cita", Left = 24, Top = 308, Width = 140, Height = 34 };
            btnSave.Click += BtnSave_Click;

            panel.Controls.AddRange(new Control[] { lblFecha, dtFecha, lblHora, dtHora, cbEstado, cbMedico, cbPaciente, cbClinica, cbTratamiento, txtMotivo, btnSave });
            Controls.Add(panel);
            Controls.Add(top);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validar disponibilidad del médico y luego insertar (stub)
            MessageBox.Show("Validar disponibilidad y crear cita (stub). Implementar lógica de verificación en BD.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // ---------------- AddAdminScreen ----------------
    public class AddAdminScreen : Form
    {
        private TextBox txtNombre, txtApellido, txtEmail;
        private TextBox txtPass;
        public AddAdminScreen()
        {
            this.Text = "Agregar Administrador";
            this.Size = new Size(500, 300);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Agregar Administrador", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            var panel = new Panel { Dock = DockStyle.Top, Height = 220, Padding = new Padding(20) };

            txtNombre = CreateField("Nombre:", 0);
            txtApellido = CreateField("Apellido:", 1);
            txtEmail = CreateField("Email:", 2);
            txtPass = CreateField("Contraseña:", 3);
            txtPass.UseSystemPasswordChar = true;

            var btnSave = new Button { Text = "Crear administrador", Width = 180, Height = 36, Left = 24, Top = 180 };
            btnSave.Click += (s, e) => {
                // TODO: encriptar contraseña antes de guardar (requerimiento no funcional)
                MessageBox.Show("Administrador creado (stub). Implementar INSERT con contraseña encriptada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            panel.Controls.Add(btnSave);
            Controls.Add(panel);
            Controls.Add(top);
        }

        private TextBox CreateField(string label, int row)
        {
            var lbl = new Label { Text = label, ForeColor = Color.LightGray, Left = 24, Top = 8 + row * 40, Width = 200 };
            var txt = new TextBox { Left = 24, Top = 28 + row * 40, Width = 420 };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            return txt;
        }
    }

    // ---------------- AddTratamientoScreen ----------------
    public class AddTratamientoScreen : Form
    {
        private TextBox txtNombre, txtDescripcion, txtCosto;
        public AddTratamientoScreen()
        {
            this.Text = "Agregar Tratamiento";
            this.Size = new Size(500, 300);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Agregar Tratamiento", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            var panel = new Panel { Dock = DockStyle.Top, Height = 240, Padding = new Padding(20) };

            txtNombre = CreateField("Nombre:", 0);
            txtDescripcion = CreateField("Descripción:", 1);
            txtCosto = CreateField("Costo (decimal):", 2);

            var btnSave = new Button { Text = "Guardar tratamiento", Width = 180, Height = 36, Left = 24, Top = 180 };
            btnSave.Click += (s, e) => MessageBox.Show("Tratamiento guardado (stub). Implementar INSERT en TRATAMIENTO.");

            panel.Controls.Add(btnSave);
            Controls.Add(panel);
            Controls.Add(top);
        }

        private TextBox CreateField(string label, int row)
        {
            var lbl = new Label { Text = label, ForeColor = Color.LightGray, Left = 24, Top = 8 + row * 40, Width = 200 };
            var txt = new TextBox { Left = 24, Top = 28 + row * 40, Width = 420 };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            return txt;
        }
    }

    // ---------------- ListPacientesScreen ----------------
    public class ListPacientesScreen : Form
    {
        private DataGridView dgv;
        public ListPacientesScreen()
        {
            this.Text = "Listado de Pacientes";
            this.Size = new Size(600, 400);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Listado de Pacientes", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            dgv = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.FromArgb(45, 45, 45), ForeColor = Color.White, AllowUserToAddRows = false };
            dgv.Columns.Add("cedula", "Cédula");
            dgv.Columns.Add("nombre", "Nombre");
            dgv.Columns.Add("apellido", "Apellido");
            dgv.Columns.Add("email", "Email");

            // Stub: agregar datos de ejemplo
            dgv.Rows.Add("8-1013-1377", "Javier", "Espinosa", "javier@example.com");
            dgv.Rows.Add("8-1018-2161", "Edward", "Liu", "edward@example.com");

            Controls.Add(dgv);
            Controls.Add(top);
            dgv.CellDoubleClick += Dgv_CellDoubleClick;
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var ced = dgv.Rows[e.RowIndex].Cells[0].Value?.ToString();
            MessageBox.Show($"Abrir detalle/editar paciente: {ced} (stub). Implementar navegación a detalle.", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // ---------------- ListCitasScreen ----------------
    public class ListCitasScreen : Form
    {
        private DataGridView dgv;
        public ListCitasScreen()
        {
            this.Text = "Listado de Citas";
            this.Size = new Size(700, 400);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Listado de Citas", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            dgv = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.FromArgb(45, 45, 45), ForeColor = Color.White, AllowUserToAddRows = false };
            dgv.Columns.Add("id", "ID");
            dgv.Columns.Add("fecha", "Fecha");
            dgv.Columns.Add("hora", "Hora");
            dgv.Columns.Add("medico", "Médico");
            dgv.Columns.Add("paciente", "Paciente");
            dgv.Columns.Add("estado", "Estado");

            dgv.Rows.Add("1", "2025-09-16", "09:00", "Dr. X", "Paciente A", "Pendiente");

            Controls.Add(dgv);
            Controls.Add(top);
        }
    }

    // ---------------- ListAdminsScreen ----------------
    public class ListAdminsScreen : Form
    {
        private DataGridView dgv;
        public ListAdminsScreen()
        {
            this.Text = "Listado de Administradores";
            this.Size = new Size(600, 400);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Listado de Administradores", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            dgv = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.FromArgb(45, 45, 45), ForeColor = Color.White, AllowUserToAddRows = false };
            dgv.Columns.Add("id", "ID");
            dgv.Columns.Add("nombre", "Nombre");
            dgv.Columns.Add("apellido", "Apellido");
            dgv.Columns.Add("email", "Email");
            dgv.Rows.Add("1", "Miriam", "Fernandez", "mfernandez@utp.ac.pa");
            Controls.Add(dgv);
            Controls.Add(top);
        }
    }

    // ---------------- ListTratamientosScreen ----------------
    public class ListTratamientosScreen : Form
    {
        private DataGridView dgv;
        public ListTratamientosScreen()
        {
            this.Text = "Listado de Tratamientos";
            this.Size = new Size(600, 400);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Listado de Tratamientos", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            dgv = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.FromArgb(45, 45, 45), ForeColor = Color.White, AllowUserToAddRows = false };
            dgv.Columns.Add("id", "ID");
            dgv.Columns.Add("nombre", "Nombre");
            dgv.Columns.Add("descripcion", "Descripción");
            dgv.Columns.Add("costo", "Costo");
            dgv.Rows.Add("1", "Consulta general", "Evaluación y diagnóstico", "25.00");
            Controls.Add(dgv);
            Controls.Add(top);
        }
    }

    // ---------------- ListClinicasScreen ----------------
    public class ListClinicasScreen : Form
    {
        private DataGridView dgv;
        public ListClinicasScreen()
        {
            this.Text = "Listado de Clínicas";
            this.Size = new Size(600, 400);
            this.BackColor = Color.FromArgb(40, 40, 40);
            var top = new Label { Text = "Listado de Clínicas", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.White, Dock = DockStyle.Top, Height = 60, Padding = new Padding(12, 0, 0, 0) };
            dgv = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.FromArgb(45, 45, 45), ForeColor = Color.White, AllowUserToAddRows = false };
            dgv.Columns.Add("id", "ID");
            dgv.Columns.Add("nombre", "Nombre");
            dgv.Columns.Add("direccion", "Dirección");
            dgv.Columns.Add("telefono", "Teléfono");
            dgv.Rows.Add("1", "Clinica Central", "Av. Principal #123", "(+507) 1234-5678");
            Controls.Add(dgv);
            Controls.Add(top);
        }
    }
}
