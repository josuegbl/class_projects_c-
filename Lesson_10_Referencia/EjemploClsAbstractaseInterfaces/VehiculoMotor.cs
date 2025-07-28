using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces;

public abstract class VehiculoMotor : Vehiculo
{
    protected Motor motor;
    protected Person conductor;

    public void arrancar()
    {
        this.motor.arrancar();
    }
     
    public override string? ToString()
    {
        return "el vehiculo tiene " + 
            this.numRuedas + " ruedas " +
            " un motor " + this.motor + 
            " y lo conduce " + this.conductor.getName();
    }
}
