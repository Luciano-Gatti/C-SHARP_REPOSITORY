namespace Bingo
{
    public partial class Form1 : Form
    {
        string nombre;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            if (textBox1.Text != "")
            {
                nombre = textBox1.Text;
            }
            else
            {
                nombre = "Anonimus";
            }
            int numero = random.Next(10000, 100000);
            Jugador jugador = new Jugador(nombre, numero);
            Form2 form2 = new Form2(jugador);
            this.Hide();
            form2.ShowDialog();
            
        }
    }
}