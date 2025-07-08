using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class EjemploHerencia
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("En herencia");

        //User josueUser = new User("Josue", 
        //                          "Gomez",
        //                          "josue@email.com");

        //Console.WriteLine(josueUser.doWork());

        //Employee josueEmployee = new Employee("Josue",
        //                                      "Gomez",
        //                                      "boss");

        //Console.WriteLine(josueEmployee.doWork());
        //Console.WriteLine(josueUser);
        //Console.WriteLine(josueEmployee);

        //Frigopie helado1 = new Frigopie("chocomenta");
        //SandwichNata helado2 = new SandwichNata("menta limon");
        //Calipo helado3 = new Calipo("agua de ná");
        //Console.WriteLine(helado1);
        //Console.WriteLine(helado2);
        //Console.WriteLine(helado3);

        FanF1 carlosFan = new FanF1("Norris");
        FanF1 JosueFan = new FanF1("Rayo McQueen");

        FanTenis hijoFan = new FanTenis("Alcaraz");
        FanTenis todoFan = new FanTenis("Federer");

        Console.WriteLine(carlosFan);
        Console.WriteLine(JosueFan);
        Console.WriteLine(hijoFan);
        Console.WriteLine(todoFan);


    }
}
