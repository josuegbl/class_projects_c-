using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.EjemploClsAbstractaseInterfaces;

public class EjemploClsAbstractaseInterfaces
{
    public static void Main(string[] args)
    {
        Console.WriteLine("En clases Abstractas e interfaces");

        GestorSeguros gSeguros = new GestorSeguros();

        Patinete patinete = new Patinete();

        Bicicleta bicicleta = new Bicicleta();

        Person person = new Person(
            "Josue"
            , "Gomez");

        MotorCoche motorCoche = new MotorCoche(120, "Honda");
        MotorMoto motorMoto = new MotorMoto(80, "Suzuki");

        Coche coche = new Coche(4
                              , motorCoche
                              , person);
        coche.arrancar();
        Console.WriteLine(coche);

        Moto moto = new Moto(2
                           , motorMoto
                           , person);
        moto.arrancar();
        Console.WriteLine(moto);

        gSeguros.asegurar(bicicleta);
        gSeguros.asegurar(moto);
        gSeguros.asegurar(coche);

    }
}
