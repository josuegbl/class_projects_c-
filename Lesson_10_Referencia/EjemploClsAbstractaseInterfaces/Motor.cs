using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces;


// La clase abstracta no se instancia. Lo que se instancia 
// son las clases concretas (MotorMoto y MotorCoche)
public abstract class Motor
{
    protected int caballos;
    protected string marca;

    public virtual void arrancar()
    {
        Console.WriteLine("Este es el arrancar generico");
    }

    public override string? ToString()
    {
        return this.marca + " de " +
               this.caballos + " caballos";
    }

}
