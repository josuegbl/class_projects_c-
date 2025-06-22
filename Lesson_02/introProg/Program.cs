using System.Numerics;

namespace introProg;

public class Program
{
    public static void Main(string[] args)
    {
        //int numeroPpl = 20;
        //int sandMorcilla = 10;
        //int sandChorizo = 4;
        //int sandSalchichon = 5;
        //int cantidadSand = 0;
        //int restoSand = 0;
        //int restoPpl = 0;

        //cantidadSand = sandChorizo + sandMorcilla + sandSalchichon;
        //restoSand = cantidadSand - numeroPpl;
        //Console.WriteLine("Hay " + cantidadSand + " bocadillos");
        //if (restoSand < 0)
        //{
        //    restoPpl = numeroPpl - cantidadSand;
        //    Console.WriteLine("Se queda(n) " + restoPpl + " persona(s) sin bocadillos");
        //}
        //else
        //{ 
        //    Console.WriteLine("Quedan " + restoSand + " bocadillos");
        //}

        // Integrals
        byte Abyte = 1; //8 bits
        short aShort = 2; // 16 bits
        int aInt = 3; //32 bits
        long aLong = 4; // 64 bits 

        Console.WriteLine("Mi byte vale" + Abyte);
        Console.WriteLine("Mi short vale " + aShort);
        Console.WriteLine("Mi int vale " + aInt);
        Console.WriteLine("Mi long vale " + aLong);

        // Floating point
        float aFloat = 5.5F; // 32 bits
        double aDouble = 6.6; // 64 bits
        decimal aDecimal = 7.7M; // 128 bits

        Console.WriteLine("Mi float vale" + aFloat);
        Console.WriteLine("Mi double vale" + aDouble);
        Console.WriteLine("Mi decimal vale" + aDecimal);
        
        // Text
        char aChart = 'a'; // 16 bits UNICODE
        string aString = "Josue";

        Console.WriteLine("Mi char vale " + aChart);
        Console.WriteLine("Mi string vale " + aString);

        bool aBoolean = true; // 1 bit

        Console.WriteLine("Mi bool vale " + aBoolean);
        Console.WriteLine($"mi bool vale {aBoolean}"); // interpolation

        // Format method has bunch of options. it is the most flexible method to build strings
        Console.WriteLine(string.Format("mi bool vale {0}", aBoolean));
        
        Console.WriteLine(@"c:\path\to\smtg");
        Console.WriteLine("c:\\path\"to\\smtg");

        string s ="""
            fdg sdf
            sdf gdf
            hyh
            """;

        const float PI = 3.14159264F;


        double moleculasAgua = 0;
        byte numeroDedos = 0;
        const float pi = 3.141592F;
        string bankAccount = "";
        int hojasArbol = 0;
        float longitudCometa = 0;
        string movilNumero = "";
        const double masaH = 0;
        char letra = 'A';
        string tipoHormiga = "";
        string plantillaEquipoRugby = "";
        string tallaCamisa = "M";
        bool hoyHaceSol = false;
        short ELO = 2800;
        float volumenFuente = 0;
        decimal salarioMedio = 25000.00M;
        bool gustoTortillaPatataCebolla = true;
        string ratioDeuda = "AAA";
        float temperaturaSol = 5000;
        int cantidadLentejaGuiso = 10000;
        char inicialName = 'A';
        double granosArena = 0;
        bool eresFeliz = true;
        string problemasHabitat = "muchos";
        short año = 2025;
        decimal precioSalmon = 11.5M;
        byte aprecioRobustianoEnAlcornoque = 9;
        byte turnoCarniceria = 99;
        short horasReelVistas = 0;
        byte handicapGolf = 24;
        string ingredientesAtascaburras = string.Empty;
        byte mayoriaJuntaVecinos = 45;
        float interesAnualPrestamo = 5.3F;
        const byte numeroTeclasQwerty = 50;
        const int numeroCaracteresDonQuijote = 500000;
        bool planchaEncendida = false;

        // ÒPERADORES

        // = ASIGNACION
        // + Suma
        // - Resta
        // * Multiplicacion
        // / Division
        // % Modulo

        // Aritmetico logicos
        // +=
        // -=
        // *=
        // /=





    }
}