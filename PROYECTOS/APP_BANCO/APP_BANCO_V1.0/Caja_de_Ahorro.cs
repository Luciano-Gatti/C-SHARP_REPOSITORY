using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Bancaria
{
    internal class Caja_de_Ahorro : Entidad_Bancaria
    {
        //Constructor
        public Caja_de_Ahorro(string nombre, string apellido, string usuario, string contraseña, string email, string telefono, DateTime fechaCreacion) : base(nombre, apellido, usuario, contraseña, email, telefono, fechaCreacion)
        {
        }
    }
}
