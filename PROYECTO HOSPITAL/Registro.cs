using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PROYECTO_HOSPITAL
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtContra.Text == txtConfContra.Text)
            {
                btnConfirmar.Enabled = true;
                Form formulario = new Login();
                this.Close();
                formulario.Show();
            }

            else
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form formulario = new Login();
            this.Close();
            formulario.Show();
        }
    }
}
