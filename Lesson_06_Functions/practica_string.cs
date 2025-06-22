using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class practica_string
{
    public static void Main(string[] args)
    {
        Console.WriteLine("En Practica String");
        /// Implementa las siguientes operaciones con Strings generando un codigo que:
        /// NOTA: Para diseñar las operaciones propuestas, integrar el aprendizaje previo
        //*****************************
        ///Para dos strings determinados, indica si tienen la letra 'a' 

        string texto1 = "Esta es una de las cadenas";
        string texto2 = "Esta es la otra";
        
        bool validateString1 = texto1.Contains('a');
        bool validateString2 = texto2.Contains('a');

        if (validateString1) Console.WriteLine("'" + texto1 + "' contiene al menos una 'a' ");
        if (validateString2) Console.WriteLine("'" + texto2 + "' contiene al menos una 'a' ");

        Console.WriteLine("\n");

        //*****************************
        /// Para un string determinado, quite los espacios delante y detrás y lo convierta a 
        /// minusculas
        string textWithSpaces = "      SA as as     ";
        Console.WriteLine("Aqui va sin espacios '" + textWithSpaces.Trim().ToLower() + "'");
        Console.WriteLine("\n");

        //*****************************
        /// Para dos cadenas, que sume sus longitudes y, si el resultado es mayor que 10,
        /// muestre la longitud por pantalla
        string textSumLength1 = "josue es ";
        string textSumLength2 = "mi nombre";
        int sumLengths = textSumLength1.Length + textSumLength2.Length;

        if (sumLengths > 10)
        {
            Console.WriteLine("La suma de las longitudes de '" + textSumLength1 
                               + "' y '" + textSumLength2 + "' es mayor que 10");
        }
        Console.WriteLine("\n");

        //*****************************
        /// Para un numero y un string, sacar por pantalla la letra en la
        /// posicion indicada por el numero
        string someText = "QWERTYUIO";
        int positionString = 4;

        Console.WriteLine("El caracter en la posicion " + positionString + " es " + someText[positionString]);

        Console.WriteLine("\n");

        //*****************************
        /// Para un booleano y un string si el booleano es true que convierta
        /// el String a mayusculas y lo muestre por pantalla
        bool convertUpper = true;

        if (convertUpper) Console.WriteLine("La cadena queda: " + texto1.ToUpper());


        Console.WriteLine("\n");

        //*****************************
        ///Para cualquier string, caracter y un numero, si la cadena tiene el
        ///numero de ocurrencias del caracter, que muestre la cadena
        char somecChar = 'a';
        int frequency = 5;
        int realFreq = 0;
        
        foreach (char l in texto1)
        {
            if (somecChar == l) realFreq++;
        }
        if (realFreq == frequency)
        {
            Console.WriteLine(texto1);
        }
        else
        {
            Console.WriteLine("la frequencia real es " + realFreq);
        }

            Console.WriteLine("\n");

        //*****************************
        /// Para un string, que muestre cada uno de sus caracteres por separado

        for (int i = 0; i < someText.Length; i++)
        {
            Console.WriteLine(someText[i]);
        }

        Console.WriteLine("\n");

        //*****************************
        /// Para un string y un caracter indicado, que reemplace las vocales por
        /// el caracter indicado.
        char charToChange = '8';
        string vowels = "AEIOUaeiou";
        string textChanged = texto1;

        foreach (char v in vowels)
        {
            textChanged = textChanged.Replace(v, charToChange);
        }
        Console.WriteLine("El texto nuevo es " + textChanged);

        Console.WriteLine("\n");

        //*****************************
    }
}
