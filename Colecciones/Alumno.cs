using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }

        public List<Materia> Materias { get; set; }//dentro se establece el tipo de dato, en este caso es una clase.

        public Alumno() //El constructor se debe llamar igual que la clase
        {
            Materias = new List<Materia>();
        }

    }
}
