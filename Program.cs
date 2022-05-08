using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_5.Clases;

namespace BootCamp_Challenge_5
{
    public class EstudianteProfesorTest
    {
        static void Main(string[] args)
        {

            Ejercicio2();
        }

        static void Ejercicio1()
        {
            //Persona persona = new Persona();
            //persona.Saludar();

            //Console.WriteLine();

            //Estudiante estudiante = new Estudiante();
            //estudiante.setEdad(19);
            //estudiante.Saludar();
            //estudiante.verEdad();
            //estudiante.Estudiar();

            //Console.WriteLine();

            //Profesor profesor = new Profesor();
            //profesor.setEdad(42);
            //profesor.Saludar();
            //profesor.Explicar();

            //Console.ReadKey();
        }

        static void Ejercicio2()
        {
            Persona[] personas = new Persona[3];

            for (int x = 0; x < personas.Length; x++)
            {
                if (x != 0)
                {
                    Console.Write("Nombre del Estudiante: ");
                    personas[x] = new Estudiante(Console.ReadLine());
                }
                else
                {
                    Console.Write("Nombre del profesor: ");
                    personas[x] = new Profesor(Console.ReadLine());
                }
            }

            for(int x=0; x < personas.Length;x++)
            {
                personas[x].Saludar();
                personas[x].estudiarYexplicar();
            }

            Console.ReadKey();
        }
    }
}
