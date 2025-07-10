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

        //FanF1 carlosFan = new FanF1("Norris");
        //FanF1 JosueFan = new FanF1("Rayo McQueen");

        //FanTenis hijoFan = new FanTenis("Alcaraz");
        //FanTenis todoFan = new FanTenis("Federer");

        //Console.WriteLine(carlosFan);
        //Console.WriteLine(JosueFan);
        //Console.WriteLine(hijoFan);
        //Console.WriteLine(todoFan);

        //Tostadora toaster1 = new Tostadora(230, 5, false);
        //Tostadora toaster2 = new Tostadora(230, 4, true);

        //toaster1.Tostar();
        //Console.WriteLine(toaster1); 

        //toaster2.Tostar();

        //Horno oven1 = new Horno("Canadian Appliancies", 3500, 110, ["timer","grill", "fan"]);

        //oven1.Mostrar();

        //Defender player1 = new Defender("Carlos", "Ciempobasket");

        //player1.defend();
        //player1.showInfo();

        //Striker player2 = new Striker("Mia", "Ciempobasket");

        //player2.strike();
        //player2.showInfo();


        //Sausage salchichas = new Sausage("salchichon", 10);
        //CowCheese quesoVaca = new CowCheese(10, 14, 25);
        //Sausage chorizo = new Sausage("chorizo", 4);

        //Store store = new Store();

        //store.addProductStock(salchichas);
        //store.addProductStock(chorizo);
        //store.addProductStock(quesoVaca);

        //store.getStock();

        //Product[] toBuy = { new Sausage("chorizo", 2), new Sausage("salchichon", 5), new CowCheese(1, 14, 25) };
        //Sale sale = new Sale(toBuy);

        //store.doSale(sale);

        //store.getStock();


        GoatCheese goat = new GoatCheese(10, 25);
        SheepCheese sheep = new SheepCheese(10, "churras", 30);
        CowCheese cow = new CowCheese(14, 53);

        cow.getTastingNote();
        Console.WriteLine();
        goat.getTastingNote();
        Console.WriteLine();
        sheep.getTastingNote();


    }
}
