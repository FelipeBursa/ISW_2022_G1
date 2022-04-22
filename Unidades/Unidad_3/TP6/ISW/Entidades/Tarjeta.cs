using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW.Entidades
{
    class Tarjeta
    {
        public Tarjeta(string nombre, string apellido, string numero, string fechaVencimiento, string cvc)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numero = numero;
            this.fechaVencimiento = fechaVencimiento;
            this.cvc = cvc;
        }

        string nombre { get; set; }
        string apellido { get; set; }
        string numero { get; set; }
        string fechaVencimiento { get; set; }
        string cvc { get; set; }
    }


}
