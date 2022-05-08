using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_5.Clases
{
    abstract class Persona
    {
        protected int edad;
        protected string name;

        public Persona(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"mi nombre es: {this.name}";
        }

        public abstract void estudiarYexplicar();

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine($"Buenos dias, soy: {this.name}");
        }



    }
}
