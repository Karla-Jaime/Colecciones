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
            //Declaración e inicializacion de lista de alumnos
            List<Alumno> Alumnos = new List<Alumno>();
            //Declaración t asignacion de valor de alumno1
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Juan Perez";
            alumno1.Materias.Add(new Materia("Historia", "45344fd53"));
            alumno1.Materias.Add(new Materia("Español", "4fd53"));
            alumno1.Materias.Add(new Materia("Aleman", "44wrwer3"));
            alumno1.Materias.Add(new Materia("Geografía", "45DHF8")); //referencia al llamado del constructor


            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Ramon Kim";
            alumno2.Materias.Add(new Materia("Canto", "45344fd53"));
            alumno2.Materias.Add(new Materia("Español", "4fd53"));
            alumno2.Materias.Add(new Materia("Frances", "44wrwer3"));
            alumno2.Materias.Add(new Materia("Geografía", "45DHF8"));

            // alumno2.Materias.Add
            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Mickey";
            alumno3.Materias.Add(new Materia("Canto", "45344fd53"));
            alumno3.Materias.Add(new Materia("Robotica", "4fd53"));
            alumno3.Materias.Add(new Materia("Frances", "44wrwer3"));
            alumno3.Materias.Add(new Materia("Geografía", "45DHF8"));

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Armando";
            alumno4.Materias.Add(new Materia("Algebra", "45344fd53"));
            alumno4.Materias.Add(new Materia("Japones", "4fd53"));
            alumno4.Materias.Add(new Materia("Fisica", "44wrwer3"));
            alumno4.Materias.Add(new Materia("Programacion", "45DHF8"));

            Console.WriteLine("Alumno: " + alumno1.Nombre);
            Console.WriteLine("Número de materias: " + alumno1.Materias.Count);

            foreach (Materia materia in alumno1.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }
            Console.WriteLine("\nAlumno: " + alumno2.Nombre);
            Console.WriteLine("Número de materias: " + alumno2.Materias.Count);
            foreach (Materia materia in alumno2.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }
            
            Console.WriteLine("\nAlumno: " + alumno3.Nombre);
            Console.WriteLine("Número de materias: " + alumno3.Materias.Count);
            foreach (Materia materia in alumno3.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Console.WriteLine("\nAlumno: " + alumno4.Nombre);
            Console.WriteLine("Número de materias: " + alumno4.Materias.Count);
            foreach (Materia materia in alumno4.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }
            Console.ReadLine();
        }
    }
}
