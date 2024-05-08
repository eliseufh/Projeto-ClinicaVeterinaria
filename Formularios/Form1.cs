using clinicaVeterinaria.Formularios;

namespace clinicaVeterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Consulta k = new Consulta();
            k.Show();
            this.Hide();
        }

        private void btn_animal_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }
    }
}
