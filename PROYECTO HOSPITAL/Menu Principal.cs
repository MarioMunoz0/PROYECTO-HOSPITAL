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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form formulario = new Empleados();
            formulario.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Examenes();
            formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Login();
            formulario.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form formulario = new Empleados();
            formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Pacientes();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Admisiones();
            formulario.ShowDialog();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
