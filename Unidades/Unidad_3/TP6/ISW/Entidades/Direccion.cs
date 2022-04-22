using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW.Entidades
{
    class Direccion
    {
        public Direccion(string ciudad, string calle, string numero, string referencia)
        {
            this.ciudad = ciudad;
            this.calle = calle;
            this.numero = numero;
            this.referencia = referencia;
        }

        string ciudad { get; set; }
        string calle { get; set; }
        string numero { get; set; }
        string referencia { get; set; }
    }
}
