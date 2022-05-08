using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_5.Clases
{
    class Estudiante : Persona
    {
        public Estudiante(string name):base(name)
        {
            
        }

        public override void estudiarYexplicar()
        {
            Console.WriteLine("El estudiante esta estudiando...");
        }

        public void verEdad()
        {
            Console.WriteLine($"Mi edad es {this.edad}");
        }
    }
}
