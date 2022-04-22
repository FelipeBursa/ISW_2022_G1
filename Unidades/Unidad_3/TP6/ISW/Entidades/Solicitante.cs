using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW.Entidades
{
    class Solicitante
    {
        public Solicitante(string nombre, string apellido, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }

        string nombre { get; set; }
        string apellido { get; set; }
        string email { get; set; }
    }
}
