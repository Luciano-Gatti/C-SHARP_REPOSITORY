using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App_Bancaria
{
    internal class Cuenta_Corriente : Entidad_Bancaria
    {
        double saldoNegativo_Max;

        //Constructor
        public Cuenta_Corriente(string nombre, string apellido, string usuario, string contraseña, string email, string telefono, DateTime fechaCreacion) : base(nombre, apellido, usuario, contraseña, email, telefono, fechaCreacion)
        {
            this.saldoNegativo_Max = 10000.00;
        }

        //Getters y Setters
        public double SaldoNegativo_Max { get => saldoNegativo_Max; set => saldoNegativo_Max = value; }

        //Metodos de la clase
        public override void Extraccion(double extraccion)
        {
            if (Controlar_saldoNegativo(extraccion))
            {
                Saldo -= extraccion;
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.", "ERROR", MessageBoxButtons.OK);
            }
        }

        public bool Controlar_saldoNegativo(double extraccion)
        {
            double control;
            control = Saldo - extraccion;
            if (control > saldoNegativo_Max)
            {
                return false;
            }else
            {
                return true;
            }
        }     
    }
}
