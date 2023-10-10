using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_HOSPITAL
{
    public partial class Admisiones : Form
    {
        public Admisiones()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Examenes();
            formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Habitaciones();
            formulario.ShowDialog();
        }
    }
}
