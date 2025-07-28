using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.Embutidos;

public class Chorizo : Embutido
{
    public Chorizo(string ingredientes)
    {
        this.ingredientes = ingredientes;
    }

    public override void preparar()
    {
        Console.WriteLine("El chorizo se hace con " + this.ingredientes);
    }

}
