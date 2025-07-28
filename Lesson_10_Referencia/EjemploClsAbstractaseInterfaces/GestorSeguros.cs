using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces;

public class GestorSeguros
{
    public void asegurar(IAsegurable vehicle)
    {
        Console.WriteLine("Iniciando proceso de asegurar");
        vehicle.asegurar();
        Console.WriteLine("Fin proceso de asegurar");
    }
}
