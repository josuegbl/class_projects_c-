using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces;

public class Moto : VehiculoMotor, IAsegurable
{
    public Moto(int numRuedas, Motor motor, Person conductor)
    {
        this.numRuedas = numRuedas;
        this.motor = motor;
        this.conductor = conductor;
    }

    public void asegurar()
    {
        Console.WriteLine("Asegurando el coche");
    }

}
