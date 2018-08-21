using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos = new List<Alumno>();

            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "179044";

            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "JM179044";

            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "KG449017";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "KA57537";

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Ramona Chavez";
            alumno2.Matricula = "179044";

            Materia español = new Materia();
            español.Nombre = "Español";
            alumno2.Materias[0].Nombre = "Civica";
            alumno2.Materias[1].Nombre = "Aleman";

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Julio Ramirez";
            alumno3.Matricula = "179044"; 

            alumno3.Materias[0].Nombre = "Geografía";
            alumno3.Materias[1].Nombre = "Etica";
            alumno3.Materias[2].Nombre = "Frances";

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Tom Jerry";
            alumno4.Matricula = "179044";

            alumno4.Materias[0].Nombre = "Historia";
            alumno4.Materias[1].Nombre = "Comunicación";
            alumno4.Materias[2].Nombre = "Aleman";

            //alumno.Materias.RemoveAt(1);//El indice es el elemento que se va a remover
            //alumno.Materias.Clear(); //Para quitar todos los elementos de la lista

            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Número de materias: " + alumno.Materias.Count); //cuenta el # de elementos en la lista


            foreach (Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Alumno: " + alumno2.Nombre);
            Console.WriteLine("Número de materias: " + alumno2.Materias.Count);

            foreach (Materia materia in alumno2.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Alumno: " + alumno3.Nombre);
            Console.WriteLine("Número de materias: " + alumno3.Materias.Count);

            foreach (Materia materia in alumno3.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Alumno: " + alumno4.Nombre);
            Console.WriteLine("Número de materias: " + alumno4.Materias.Count);

            foreach (Materia materia in alumno4.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Console.ReadLine();
        }
    }
}
