using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.GOT
{
    public class PersonajeStark : PersonajesGOT
    {
        protected static Stark casa;

        public PersonajeStark(string name)
        {
            this.name = name;
            PersonajeStark.casa = new Stark();
        }

        public override void presentarse()
        {
            Console.WriteLine($"Mi nombre es {this.name} y {PersonajeStark.casa.Lema()}");
        }
    }
}
