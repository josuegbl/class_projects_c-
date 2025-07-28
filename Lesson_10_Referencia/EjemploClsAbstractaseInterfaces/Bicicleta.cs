using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces;

public class Bicicleta : Vehiculo, IAsegurable
{
    public void asegurar()
    {
        Console.WriteLine("Asegurando la bici");
    }
}
