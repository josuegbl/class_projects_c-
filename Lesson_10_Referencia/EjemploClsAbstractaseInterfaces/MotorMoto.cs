using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces
{
    public class MotorMoto : Motor
    {
        public MotorMoto(int caballos
                 , string marca)
        {
            this.caballos = caballos;
            this.marca = marca;
        }

        public override void arrancar()
        {
            Console.WriteLine("Estoy arrancando el motor de la moto");
        }

    }
}
