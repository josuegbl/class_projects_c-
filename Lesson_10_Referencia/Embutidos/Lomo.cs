using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.Embutidos
{
    public class Lomo : Embutido
    {
        public Lomo(string ingredientes)
        {
            this.ingredientes = ingredientes;
        }

        public override void preparar()
        {
            Console.WriteLine("El lomo se hace con " + this.ingredientes);
        }

    }
}
