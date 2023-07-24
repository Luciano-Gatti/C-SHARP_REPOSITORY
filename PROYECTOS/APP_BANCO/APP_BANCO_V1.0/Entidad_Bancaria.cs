using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Bancaria
{
    abstract class Entidad_Bancaria
    {
        private string email, nombre, apellido, usuario, contraseña, telefono;
        private double saldo;
        private DateTime fechaCreacion;
        List<Entidad_Bancaria> listaCuentas; 

        //Constructor
        protected Entidad_Bancaria(string nombre, string apellido, string usuario, string contraseña, string email, string telefono, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.email = email;
            this.saldo = 0.00;
            this.telefono = telefono;
            this.fechaCreacion = fechaCreacion;
            listaCuentas = new List<Entidad_Bancaria>();
        }

        //Getters y Setters
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        protected string Usuario { get => usuario; set => usuario = value; }
        protected string Contraseña { get => contraseña; set => contraseña = value; }
        protected string Email { get => email; set => email = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        protected string Telefono { get => telefono; set => telefono = value; }
        protected DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        internal List<Entidad_Bancaria> ListaCuentas { get => listaCuentas; set => listaCuentas = value; }

        //Metodos de las clases
        public virtual void Extraccion(double extraccion)
        {
            if (saldo < extraccion)
            {
                saldo -= extraccion;
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.", "ERROR", MessageBoxButtons.OK);
            }
        }

        public virtual void Deposito(double deposito)
        {
            saldo += deposito;
        }
        
    }
}
