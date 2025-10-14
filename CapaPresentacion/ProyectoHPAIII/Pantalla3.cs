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

        }
    }
}
