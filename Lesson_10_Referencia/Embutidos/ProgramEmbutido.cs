using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.Embutidos;

public class ProgramEmbutido
{
    public static void Main(string[] args)
    {
        Console.WriteLine("En embutidos");

        Salchichon salchichon = new Salchichon("carne de cerdo, panceta y otros");
        salchichon.preparar();

        Lomo lomo = new Lomo("solomillo de res, dientes de ajo, Sal, Pimienta");
        lomo.preparar();

        Chorizo chorizo = new Chorizo("carne de cerdo, tocino, pimentón, ajo y sal");
        chorizo.preparar();

    }
}
