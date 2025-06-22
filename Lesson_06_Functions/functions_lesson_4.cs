using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_06_Functions;

internal class functions_lesson_4
{
    public static void Main(string[] args)
    {
        string text = "El lado oscuro de la luna";
        Console.WriteLine("El valor de la cadena es: " + functions_lesson_4.wordCalculator(text));
        
        //******************************************
        char charToFind = 'c';
        Console.WriteLine("La cantidad de " + charToFind + " que hay son: " + 
                          functions_lesson_4.charCounter(text, charToFind) );
        
        //******************************************
        string[] chainString = ["Esto es ", "un atraco ", "muy loco.", " Seguimos ", "en ", "combate."];
        int value = 3;
        string[] frankenstring = functions_lesson_4.generateFrankenstring(chainString, value);
        Console.WriteLine("Los valores son: " + frankenstring[0] + " y " + frankenstring[1]);
        
        //******************************************
        Console.WriteLine(functions_lesson_4.doAnagram("carlos"));

       
    }
    /// Crear una funcion que reciba un string y calcule su "valor", un numero entero que
    /// devolverá como resultado.
    /// Para calcular el "valor", cada consonante que contenga valdrá 1, cada vocal 2 y
    /// cada espacio 0.
    /// Sumar los valores de las letras que contiene el string y devolver el resultado.

    public static int wordCalculator(string phraseToCalculate)
    {
        int value = 0;
        foreach (char v in phraseToCalculate)
        {
            value = charCalculator(v, value);
        }
        return value;
    }

    public static int charCalculator(char character, int value)
    {
        if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
        {
            value += 2;
        }
        else if (character != ' ') //Char.IsWhiteSpace(character)

        {
            value += 1;
        }
        return value;
    }

    /// Crear una funcion a la que se le pase una cadena de texto y devuleva un entero
    /// que se corresponda con el numero de letras 'c' que contenga la cadena.
    public static int charCounter(string phraseToCount, char charToFInd)
    {
        int realFreq = 0;

        foreach (char l in phraseToCount)
        {
            if (l == charToFInd) realFreq++;
        }
        return realFreq;
    }

    /// Crear la funcion "Frankenstring". Recibirá un array de string y un numero mayor que 0 y 
    /// menor que el numero de strings que contenga el array pasado como parametro.
    /// Devolverá  un array de strings con dos strings.
    /// El primer string del array devuelto será un string combinando aquellos del array pasado
    /// como parámetro cuya posicion (no indice) en el array sea menor o igual a la indicada por el
    /// numero pasado como parametro.
    /// El segundo string del array devuelto será un string combinando aquellos de la array pasado
    /// como parámetro cuya posicion (no indice) en el array sea mayor a la indicada por el
    /// numero pasado como parametro.
    
    public static string[] generateFrankenstring(string[] arrString, int intparam)
    {
        string firstStringElement = "";
        string secondStringElement = "";
        for (int i = 0; i < arrString.Length; i++)
        {
            if (i+1 <= intparam)
            {
                firstStringElement += arrString[i];
            }
            else
            {
                secondStringElement += arrString[i];
            }
        }
        return [firstStringElement, secondStringElement];
    }

    ///Crear una funcion que haga de generador de anagramas, recibiendo un string, sin espacios
    ///y con los caracteres en minuscula, y devolviendo otro string que sea un anagrama del string
    ///pasado, también sin espacios y en minusculas.
    ///Un anagrama es una palabra que, teniendo las mismas letras que otra, las tiene en distinto
    ///orden.
    ///Generar el anagrama con una mayoría de letras reordenadas al azar (no vale con cambiar
    ///solo una o dos letras o darle la vuelta a la palabra).
    public static string doAnagram(string textToChange)
    {
        StringBuilder newString = new StringBuilder();
        int[] orderIndex = functions_lesson_4.getRandomOrder(textToChange.Length);
        for (int i = 0; i < textToChange.Length; i++)
        {
            newString.Append(textToChange[orderIndex[i]]);
        }
        return newString.ToString();
    }

    private static int[] getRandomOrder(int length)
    {
        Random random = new Random();
        int[] arrIndex = new int[length];

        for (int i = 0; i < length; i++)
        {
            int randomIndex = random.Next(0, length);
            if (i == 0)
            {
                arrIndex[i] = randomIndex;
            }
            else
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j < i)
                    {
                        if (arrIndex[j] == randomIndex)
                        {
                            i--;
                            break;
                        }
                    }
                    else
                    {
                        arrIndex[i] = randomIndex;
                    }
                }
            }
        }
        return arrIndex;
    }
}
