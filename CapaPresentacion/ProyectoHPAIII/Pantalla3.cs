using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Pantalla3 : Form
    {
        public Pantalla3()
        {
            InitializeComponent();
        }

        private void Pantalla3_Load(object sender, EventArgs e)
        {

        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipla menu = new MenuPrincipla();
            menu.Show();
            this.Hide();
        }

        private void botonMedicos_Click(object sender, EventArgs e)
        {

        }

        private void botonPacientes_Click(object sender, EventArgs e)
        {
            Pantalla4 pacientes = new Pantalla4();
            pacientes.Show();
            this.Hide();
        }

        private void botonClinicas_Click(object sender, EventArgs e)
        {
            Pantalla5 clinicas = new Pantalla5();
            clinicas.Show();
            this.Hide();
        }

        private void BotonCitas_Click(object sender, EventArgs e)
        {
            Pantalla6 Citas = new Pantalla6();
            Citas.Show();
            this.Hide();
        }

        private void botonAdministradores_Click(object sender, EventArgs e)
        {
            Pantalla7 Admins = new Pantalla7();
            Admins.Show();
            this.Hide();
        }

        private void botonTratamientos_Click(object sender, EventArgs e)
        {
            Pantalla8 Trats = new Pantalla8();
            Trats.Show();
            this.Hide();
        }
    }
}
