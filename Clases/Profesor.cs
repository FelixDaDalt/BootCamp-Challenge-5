using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_5.Clases
{
    class Profesor : Persona
    {

        public Profesor(string name): base(name)
        {
           
        }

        public override void estudiarYexplicar()
        {
            Console.WriteLine("El profesor esta explicando!");
        }
    }
}
