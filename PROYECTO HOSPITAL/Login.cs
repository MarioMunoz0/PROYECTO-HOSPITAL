namespace PROYECTO_HOSPITAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            formulario.ShowDialog();
            this.Hide();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form formulario = new Menu_Principal();
            formulario.ShowDialog();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}