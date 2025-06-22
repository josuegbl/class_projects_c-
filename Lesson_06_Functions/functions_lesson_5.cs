using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class functions_lesson_5
{
    public static void Main(string[] args)
    {
        char[] arrayCharToSum = ['a', 'c', 'a', 'f', 'b', 'e', 'd', 'b', 'a', 'b'];
        Console.WriteLine("Suma: " + functions_lesson_5.sumCharArrays(arrayCharToSum));
        //***************************************
        string[] tasks = ["ALL"];
        string text = "  Di Si Esto  ";
        Console.WriteLine(functions_lesson_5.workshopString(tasks, text));
        //***************************************
        functions_lesson_5.generateTriangle('@', 7);
        //***************************************
        Console.WriteLine(functions_lesson_5.stringAnalizer("esto es una prueba"));
    }
    /// Crear una funcion a la que se le pase un array de caracteres, cuyos
    /// posibles valores irán de la 'a' a la 'f'. Devolverá un entero , que 
    /// será la suma de un codigo numerico entero asociado a 
    /// cada letra, devuelto por otra función a la que se le pasará un caracter
    /// y devolverá el código numerico asociado. Por ejemplo, si el array de 
    /// caracteres fuera ['b,'a', 'f', 'a'] y los valores numericos asociados fueran
    /// a = 2, b = -3, f = 50, la función devolvería 51.
    public static int sumCharArrays(char[] arrayCharToSum)
    {
        int charSum = 0;
        foreach (char c in arrayCharToSum)
        {
            charSum += functions_lesson_5.getValueFromChar(c);
        }
        return charSum;
    }
    public static int getValueFromChar(char c)
    {
        switch (c)
        {
            case 'a':
                return 2;
                break;
            case 'b':
                return 5;
                break;
            case 'c':
                return -1;
                break;
            case 'd':
                return 45;
                break;
            case 'e':
                return -3;
                break;
            case 'f':
                return 8;
                break;
            default:
                return 0;
                break;
        }
    }

    /// Crear una función que actúe como un "taller" de strings. Recibirá un strings sobre el que
    /// realizar las tareas, una array de string con las tareas a realizar y devolverá un string con las
    /// tareas realizadas.
    /// Las tareas podrán ser: "TRIM", "UPPERRIZE", "LOWERSIZE" y "ALL".
    /// Si se selecciona "TRIM" una función comprobará si la cadena tiene espacios en blanco, indicando
    /// si no es así. Si tiene espacios en blanco, aplicará el trim de string.
    /// Si se selecciona el "UPPERSIZE" o "LOWERSIZE" una función para cada caso, comprobará si la cadena
    /// está vacía, indicando si es así. Si no está vacía, aplicará la función ToUpper o ToLower de 
    /// string según el caso.
    /// Si se selecciona "ALL" se aplicarán las tres funciones al string.
    public static string workshopString(string[] tasks, string phraseTorepair)
    {
        foreach (string task in tasks)
        {
            if (task == "TRIM")
            {
                phraseTorepair = functions_lesson_5.getTrim(phraseTorepair);
            }
            else if (task == "UPPERRIZE")
            {
                phraseTorepair = functions_lesson_5.getUpperSize(phraseTorepair);
            }
            else if (task == "LOWERSIZE")
            {
                phraseTorepair = functions_lesson_5.getLowerSize(phraseTorepair);
            }
            else
            {
                phraseTorepair = functions_lesson_5.getTrim(phraseTorepair);
                phraseTorepair = functions_lesson_5.getUpperSize(phraseTorepair);
                phraseTorepair = functions_lesson_5.getLowerSize(phraseTorepair);
            }
        }
        return phraseTorepair;
    }

    public static string getTrim(string textToTrim)
    {   
        if (textToTrim.Length > 0)
        {
            if (textToTrim[0] != ' ' && textToTrim[textToTrim.Length - 1] != ' ')
            {
                Console.WriteLine("No tiene espacios en blanco al principio o al final.");
                return textToTrim;
            }
            else
            {
                return textToTrim.Trim();
            }

        }
        else
        {
            return textToTrim;
        }
    }
    public static string getUpperSize(string textToUpperSize)
    {
        if (textToUpperSize.Length == 0)
        {
            Console.WriteLine("El string está vacío");
            return textToUpperSize;
        }
        else
            return textToUpperSize.ToUpper();
    }
    public static string getLowerSize(string textToLowerSize)
    {
        if (textToLowerSize.Length == 0)
        {
            Console.WriteLine("El string está vacío");
            return textToLowerSize;
        }
        else
            return textToLowerSize.ToLower();
    }

    /// Crear una función a la que se le pase una caracter y un entero cualesquiera. No devolverá nada,
    /// pero si el caracter fuera una 'c' y el entero un 10, el objetivo es sacar por pantalla:
    /// Si el caracter fuera una '@' y el numero un 3 saldría por pantalla:
    /// @
    /// @@
    /// @@@
    /// @@
    /// @
    /// NOTA - el objetivo del ejercicio es crear un algoritmo que, recibiendo 
    /// cualquier combinación de parámetros, muestre por pantalla un texto con la
    /// estructura adecuada para esos dos parámetros de entrada. Esta estructura será
    /// un triangulo , compuesto del carácter, y tan "alto" como indique el número.
    public static void generateTriangle(char c, int value)
    {
        for (int i = 1; i < value * 2; i++)
        {
            for (int j = 1, k = (2 * value - 1); (k >= i && i > value) || (j <= i  && i <= value) ; j++, k--)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }

    /// Crear una función que "analice" un string. Esto es, recibirá un string e indicará
    /// qué caracteres aparecen y cuantas veces aparece cada uno.
    /// Pensar un tipo de retorno apropiado para esta función, que pueda imprimir por consola
    /// el "análisis" del string.
    /// Los espacios no contarán para el análisis. 
    /// Existen las funciones char.Parse y char.IsWhiteSpace.
    
    public static string stringAnalizer(string textToAnalize)
    {
        StringBuilder letters = new StringBuilder();
        int[] frequency = new int[textToAnalize.Length];

        foreach(char c in textToAnalize)
        {
            if (!char.IsWhiteSpace(c))
            {
                if (letters.Length == 0)
                {
                    letters.Append(c);
                    frequency[0] = 1;
                }
                else
                {
                    bool isRepeated = false;
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (c == letters[i])
                        {
                            frequency[i] += 1;
                            isRepeated = true;
                            i = letters.Length;
                        }
                    }
                    if (!isRepeated)
                    {
                        letters.Append(c);
                        frequency[letters.Length-1] = 1;
                    }
                }
            }
        }

        string outString = "";
        for (int i = 0; i < letters.Length; i++)
        {
            outString += "la Letra " + letters[i].ToString() + " tiene frequencia " + frequency[i].ToString() + "\n";
        }
        return outString;
    }
}
