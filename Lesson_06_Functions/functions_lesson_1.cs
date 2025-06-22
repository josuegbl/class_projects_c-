namespace Lesson_06_Functions;

// Introduccion a funciones
public class ejemplo_string
{
    public static void Main(string[] args)
    {
        Console.WriteLine("En ejemploi String");
        string name = "Josue";

        Console.WriteLine("\nMi nombre es " + name);


        //name = "OtroNombre";
        //Console.WriteLine("\nMi nombre es " + name);

        // StringBuilder: para trabajar con strings como arrays.

        string newName = name.Substring(1);
        Console.WriteLine("Mi nombre sigue siendo " + name);
        Console.WriteLine("Y esta es otra string " + newName);

        Console.WriteLine("El primer caracter de name es " + name[0]);
        Console.WriteLine("El cuarto caracter de name es " + name[3]);

        string tests = "Esto es una prueba";

        Console.WriteLine("La primera e está en la posicion " + tests.IndexOf('e'));

        Console.WriteLine("La pcadena contiene una a es " + tests.Contains('a'));

        Console.WriteLine("La cadena sin espacios delante ni detras es " + tests.Trim());

        Console.WriteLine("La cadena en minusculas es " + tests.ToLower());

        Console.WriteLine("La cadena en mayusculas es " + tests.ToUpper());

        Console.WriteLine("La cadena con aes en vez de es es " + tests.Replace('e', 'a'));

        Console.WriteLine("\nMi nombre tiene " + name.Length + " caracteres" );

        // REGEX: Expresiones regulares. Es un mundo nuevo y excitante.

        int x = int.Parse("23");
        Console.WriteLine("x es " + x);

        string empty = "";
        string empty2 = string.Empty; // no se puede usar indistintamente

        //string test = null;
        //Console.WriteLine("test tiene " + test.Length + " caracteres"); Hace una exception porque test está a null

        // TERNARY OPERATOR
        x = 0;
        int ternaryTest;
        if (x <= 0) ternaryTest = 0;
        else ternaryTest = 1;

        Console.WriteLine("ternaryTest vale " + ternaryTest);

        ternaryTest = x <= 0 ? 0 : 1;

        Console.WriteLine("ternaryTest vale " + ternaryTest);

        // Math
        // Array
        // string
        // int
        // Char
        // CROSSCUTTING -> LOG
        
    }
    
}
