namespace Lesson8_Objetos;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Orientacion a Objetos! \n");

        //FootballTeam teamGuti = new FootballTeam("Guti_EPA", "Victor Valdez", "Arbeloa", 
        //                                         "Iniesta de mi via", "Mesi GOAT", 2014, false, true);

        //teamGuti.showTeamData();

        //Jedi luke = new Jedi("Luke Skywalker", "azul");
        //Jedi windu = new Jedi("Mace Windu", "morado");
        //Jedi yoda = new Jedi("Yoda", "verde");
        //Jedi qui = new Jedi("Qui-Gon Jinn", "verde");
        //Jedi obi = new Jedi("Obi-Wan Kenobi", "azul");

        //luke.showInfo();
        //windu.showInfo();
        //yoda.showInfo();
        //qui.showInfo();
        //obi.showInfo();

        //Molometro estoMola = new Molometro();

        //estoMola.mola();
        //Console.WriteLine(estoMola.molaONoMola() + "\n");

        //estoMola.noMola();
        //estoMola.noMola();
        //Console.WriteLine(estoMola.molaONoMola() + "\n");

        //estoMola.mola();
        //Console.WriteLine(estoMola.molaONoMola() + "\n");

        //Grifo bottle = new Grifo(1);

        //bottle.showInfo();

        //bottle.openValve();

        //bottle.showInfo();

        //bottle.getWater();

        //bottle.getWater();

        //bottle.showInfo();

        //Door frontDoor = new Door();

        //frontDoor.closeDoor();

        //frontDoor.openDoor();

        //frontDoor.openDoor();

        //frontDoor.isOpenOrClose();

        //frontDoor.closeDoor();

        //ChickenRecipe recipe1 = new ChickenRecipe();

        //recipe1.addIngredient("Pollo troceado");
        //recipe1.addIngredient("agua");
        //recipe1.addIngredient("sal");
        //recipe1.addIngredient("fideos");
        //recipe1.addIngredient("zanahoria");
        //recipe1.addIngredient("pimienta");
        //recipe1.addIngredient("cebolla");
        //recipe1.addIngredient("cilantro");
        //recipe1.addIngredient("orégano");

        //Console.WriteLine("Ingredientes: \n");
        //Console.WriteLine(recipe1.recipe());
        //Console.WriteLine(recipe1.hasSusbtance());

        Sausage salchichas = new Sausage("salchicha", 10);
        Sausage chorizo = new Sausage("chorizo", 4);
        Sausage morcilla = new Sausage("morcilla", 6);

        SausageStore store = new SausageStore();

        store.addProductStock(salchichas);
        store.addProductStock(chorizo);
        store.addProductStock(morcilla);

        store.getStorage();

        //Sausage salchichasToBuy = new Sausage("salchicha", 1);
        //Sausage chorizoToBuy = new Sausage("chorizo", 6);
        //Sausage morcillaToBuy = new Sausage("morcilla", 2);

        Sausage[] toBuy = { new Sausage("chorizo", 2) , new Sausage("morcilla", 10), new Sausage("salchicha", 1) };
        Sale sale = new Sale(toBuy);

        store.doSale(sale);

        store.getStorage();

    }
}
