using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Lesson_07_Files;
public class Lesson_07_Files_02
{
    public static void Main(string[] args)
    {
        //sumRandomNumbers(7);
        //showWhenTrue();
        //string[] wordsWichChar= findTheChar('h  ');
        //foreach (string word in wordsWichChar) Console.WriteLine(word);
        //string[] wordsRepeated = matchWords();
        //foreach(string word in wordsRepeated) Console.WriteLine(word);
        splitString();

    }
    //* Crear una función que reciba como parámetro un número entero y no devuelva nada.
    //• La función generará tantos números aleatorios entre 1 y 10 como indique el número.
    //• La función escribirá en un fichero por líneas esos números y, al final del fichero, su suma.
    public static void sumRandomNumbers(int maxRandomRounds)
    {
        Random random = new Random();
        string[] randomNumbersToFile = new string[maxRandomRounds+1];
        int sum = 0;

        for (int i = 0; i < maxRandomRounds; i++)
        {
            int value = random.Next(0, 11);
            sum += value;
            randomNumbersToFile[i] = value.ToString();
        }
        randomNumbersToFile[maxRandomRounds] = sum.ToString();
        File.WriteAllLines("randomNumbersAndSum.txt", randomNumbersToFile);
    }

    //* Crear una función que no reciba ningún parámetro ni devuelva nada.
    //﻿﻿• Leerá de dos ficheros: uno por líneas, que contendrá en cada línea
    //  un valor booleano (true o false) true y false; otro que en cada línea
    //  contenga una palabra palabras por líneas.
    //﻿﻿• Irá recorriendo las palabras leídas y, si el equivalente
    //del indice que ocupa esa palabra en los booleanos leídos es true,
    //mostrará la palabra por consola.
    public static void showWhenTrue()
    {
        string[] arraysOfBoolString = File.ReadAllLines("booleantToRead.txt");
        string[] arraysOfwords = File.ReadAllLines("wordsToPrintIfTrue.txt");
        for (int i = 0; i< arraysOfwords.Length; i++)
        {
            if (bool.Parse(arraysOfBoolString[i]))
            {
                Console.WriteLine(arraysOfwords[i]);
            }
        }
    }

    //* Crear una función que reciba una letra como parámetro y devuelva un array de string.
    //• ﻿﻿La función leerá un fichero por líneas y buscará qué palabras contienen la letra
    //pasada como parámetro, almacenándolas en un array.
    //• ﻿﻿La función devolverá como resultado el array de palabras que contienen la
    //letra pasada como parámetro.
    //NOTA • No hace falta controlar "grano fino" el array devuelto como resultado
    //(se pueden escribir líneas en blanco).
    public static string[] findTheChar(char c)
    {
        string[] arraysOfwords = File.ReadAllLines("wordsToPrintIfTrue.txt");
        string[] wordsWithChar = new string[arraysOfwords.Length];

        for (int i = 0; i < arraysOfwords.Length; i++)
        {
            if (arraysOfwords[i].Contains(c))
            {
                wordsWithChar[i] = arraysOfwords[i];
            }
        }
        return wordsWithChar;
    }

    /// Crear una funcion que no reciba ningun parametro y que devuelva un
    /// Array de strings.
    /// La funcion leerá por lineas dos ficheros que contienen cadenas de texto.
    /// la funcion devolverá un array con aquellas parabras que estén, al menos
    /// una vez, en un fichero y en el otro.
    /// NOTA: No hace falta controlar "grano fino" el array devuelto como resultado 
    /// (se pueden escribir lineas en blanco)
    
    public static string[] matchWords()
    {
        string[] arraysOfwords1 = File.ReadAllLines("wordsList1.txt");
        string[] arraysOfwords2 = File.ReadAllLines("wordsList2.txt");
        string[] wordsMatch = new string[arraysOfwords2.Length];
        int counter = 0;
        foreach (string wordFile1 in arraysOfwords1)
        {
            bool wordAdded = false;
            foreach (string wordAppend in wordsMatch)
            {
                if (wordFile1 == wordAppend) wordAdded = true;
            }
            if (!wordAdded)
            {
                for (int i = 0; i < arraysOfwords2.Length; i++)
                {
                    if (wordFile1 == arraysOfwords2[i])
                    {
                        counter++;
                        wordsMatch[counter] = wordFile1;
                    }
                }
            }
        }
        return wordsMatch;

    }

    /// Crear una funcion que no reciba ningun parametro ni devuelva nada,.
    /// La funcion leera un fichero como un string.
    /// La funcion leerá otro fichero como lineas del que sacará  numeros
    /// enteros positivos.
    /// La funcion ira sacando substrings de la string leida en el fichero de 
    /// entrada, cuya longitud vendrá indicada por los numeros leídos.
    /// Cuando no haya numeros disponibles, o el siguiente substring no pueda 
    /// crearse completo (esto es, se puede crear un substring de 6 caracteres
    /// y "quedan" 3 en el string origen) la funcion escribirá esos strings por 
    /// lineas en otro fichero de salida.

    public static void splitString()
    {
        string text = File.ReadAllText("textToSplit.txt");
        string[] lengthSubstrings = File.ReadAllLines("numberToSplit.txt");
        string[] wordsLines = new string[lengthSubstrings.Length];
        int startIndex = 0;

        
        for (int i = 0; i < lengthSubstrings.Length; i++)
        {
            int length = int.Parse(lengthSubstrings[i]);

            if ((startIndex + length) <= text.Length)
            {
                wordsLines[i] = text.Substring(startIndex, length);
                startIndex += length;
            }

        }
        File.AppendAllLines("textSplitted.txt", wordsLines);

    }
}
