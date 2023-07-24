using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Bancaria
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }


        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
