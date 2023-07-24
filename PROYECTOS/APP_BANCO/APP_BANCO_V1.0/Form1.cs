using System.CodeDom;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_Bancaria
{
    public partial class Form1 : Form
    {
        string email, nombre, apellido, usuario, contraseña, telefono;
        private DateTime fechaCreacion;
        Entidad_Bancaria eb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(180, 180, 180);
            textBox_Contraseña.PasswordChar = '*';
            textBox_Contraseña2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text != null && textBox_Apellido.Text != null && textBox_Usuario.Text != null && textBox_Email.Text != null && textBox_Telefono.Text != null)
            {
                textBox_Nombre.Text = nombre;
                textBox_Apellido.Text = apellido;
                textBox_Usuario.Text = usuario;
                textBox_Email.Text = email;
                textBox_Telefono.Text = telefono;
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser llenados.", "ERROR", MessageBoxButtons.OK);
                return;
            }
            if (textBox_Contraseña.Text == textBox_Contraseña2.Text)
            {
                textBox_Contraseña.Text = contraseña;
            }
            else
            {
                MessageBox.Show("Reintentelo nuevamente.", "CONTRASEÑA INCORRECTA!!", MessageBoxButtons.OK);
                return;
            }
            if (radioButton_CC.Checked)
            {
                Cuenta_Corriente cc = new Cuenta_Corriente(nombre, apellido, usuario, contraseña, email, telefono, fechaCreacion);
                eb.ListaCuentas.Add(cc);
            }
            if (radioButton_CA.Checked)
            {
                Caja_de_Ahorro ca = new Caja_de_Ahorro(nombre, apellido, usuario, contraseña, email, telefono, fechaCreacion);
                eb.ListaCuentas.Add(ca);
            }
            this.Close();
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("INGRESE SOLO NUMEROS", "ALERTA", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void button_CrearCuenta_MouseHover(object sender, EventArgs e)
        {
            button_CrearCuenta.BackColor = Color.Black;
            button_CrearCuenta.ForeColor = Color.White;
        }

        private void button_CrearCuenta_MouseLeave(object sender, EventArgs e)
        {
            button_CrearCuenta.BackColor = Color.MidnightBlue;
            button_CrearCuenta.ForeColor = Color.Black;
        }
    }
}