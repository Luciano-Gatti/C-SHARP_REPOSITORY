using System.Drawing.Drawing2D;
namespace LUDO_V3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F5EEDC");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNuevoJuego_Click(object sender, EventArgs e)
        {
            FormInicio form2 = new FormInicio();
            this.Hide();
            form2.ShowDialog();
        }
    }
}