using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.GOT
{
    public class ProgramGOT
    {
        public static void Main(string[] args)
        {
            PersonajeLannister jaime = new PersonajeLannister("Jaime");
            PersonajeLannister tyrion = new PersonajeLannister("Tyrion");

            PersonajeStark ned = new PersonajeStark("Ned");
            PersonajeStark arya = new PersonajeStark("Arya");

            ned.presentarse();
            tyrion.presentarse();
            jaime.presentarse();
            arya.presentarse();

        }
    }
}
