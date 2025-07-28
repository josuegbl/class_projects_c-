using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.Embutidos
{
    public class Salchichon : Embutido
    {
        public Salchichon(string ingredientes)
        {
            this.ingredientes = ingredientes;
        }

        public override void preparar()
        {
            Console.WriteLine("El salchichon se hace con " + this.ingredientes);
        }
    }
}
