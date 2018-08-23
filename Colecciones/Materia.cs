using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Materia //por constumbre va en mayuscula y en singular
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        public Materia()
        {
            Nombre = "Historia";
            Identificador = "0";
        }

        public Materia (string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
            
        }
    }
}
