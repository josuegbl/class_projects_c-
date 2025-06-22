using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class functions_lesson_3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Practica Funciones");

        int[] numbersIntegers = {3, 6, 43, -23, 6};
        string randomText = "Esto Es una Prueba";
        Console.WriteLine(functions_lesson_3.sumArray(numbersIntegers));
        //***********************************

        Console.WriteLine(functions_lesson_3.convertionLowerOrUpper(randomText, functions_lesson_3.sumArray(numbersIntegers)));
        //***********************************
        char[] smsInchar = ['h', 'e', 'm', 'o', 's', ' ', 'a', 'p', 'r', 'e', 'n',
                            'd', 'i', 'd', 'o', ' ', 'f', 'u', 'n', 'c', 'i', 'o',
                            'n', 'e', 's'];
        Console.WriteLine(functions_lesson_3.getVowels(smsInchar));
        //***********************************
        Console.WriteLine(functions_lesson_3.changeCharsByOther(randomText, 'E', 's', 'R'));
        //***********************************
        char[] operationsChar = ['+', '-', '/', '*', '-', '+', 'R', 'R'];//,'+','/','+','+','+','*','+','R','*'];
        Console.WriteLine(functions_lesson_3.doMathsFromCharArr(operationsChar));
        

    }
    /// Crear un funcion a la que se le pase un array de numeros enteros y devuelva su suma
    public static int sumArray(int[] arrayEnteros)
    {
        int suma = 0;
        foreach (int value in arrayEnteros)
        {
            suma += value;
        }
        return suma;
    }

    /// Crear una funcion a la que se le pase un numero entero y una cadena de texto y que 
    /// devuelva una cadena de texto
    /// Si el numero es par la cadena devuelta sera la pasada, pero en mayusculas.
    /// si el numero es impar la cadena devuelta sera la pasada, pero en minusculas.
    public static string convertionLowerOrUpper(string strChain, int numCntrol)
    {
        return (numCntrol % 2 == 0) ? strChain.ToUpper() : strChain.ToLower();
    }

    /// Crear una función a la que se le pase un array de caracteres en minuscula y devuelva un
    /// array de caracteres con los que sean vocales.
    /// NOTA: No pasa nada si en el array devuelto por la funcion "sobran" caracteres al final o hay algunos en blanco.
    public static char[] getVowels(char[] arrChar)
    {
        char[] newChar = new char[arrChar.Length];
        for (int i = 0; i < arrChar.Length; i++)
        {
            switch (arrChar[i])
            {
                case 'a':
                    newChar[i] = 'a';
                    break;
                case 'e':
                    newChar[i] = 'e';
                    break;
                case 'i':
                    newChar[i] = 'i';
                    break;
                case 'o':
                    newChar[i] = 'o';
                    break;
                case 'u':
                    newChar[i] = 'u';
                    break;
            }
        }
        return newChar;
    }

    /// Crear una funcion a la que se le pase una cadena de texto y tres caracteres distintos y devuelva la cadena de texto  
    /// pasada con los dos primeros caracteres sustituidos por el tercero.
    public static string changeCharsByOther(string phrase, char c1, char c2, char changeChar)
    {
        return phrase.Replace(c1, changeChar).Replace(c2, changeChar);
    }

    /// Crear una funcion que reciba como parametro un array de char y devuelva un numero en coma 
    /// flotante, simple precision.
    /// El arrray de char podrá contener los siguiente valores: '/', '*', '+', '-' y 'R'.
    /// A partir de un valor de 1, la función realizará las operaciones algebraicas que indique el 
    /// arrray de char, siendo ambos operandos el numero inicial.
    /// La latra 'R' significa repetir la anterior operacion.
    /// Podrá haber varias 'R' en las operaciones, pero no más de una seguida.
    /// Si una operacion da como resultado 0 o un numero menor, "resetar" el acumulador a 1.
    /// Utilizar distintas funciones para dividir las responsabilidades de las operacions y de la repeticion de la última.
    public static float doMathsFromCharArr(char[] operationsChar)
    {
        float value = 1.0F;
        for (int i = 0; i < operationsChar.Length; i++)
        {
            value = functions_lesson_3.doOperations(operationsChar, i, value);
        }
        return value;
    }

    public static float doOperations(char[] operationsChar, int i, float value)
    {
        char operation = functions_lesson_3.GetRealOperation(operationsChar, i);
        
        switch (operation)
        {
            case '+':
                value = functions_lesson_3.getSumValue(value);
                break;
            case '-':
                value = functions_lesson_3.getRestValue(value);
                break;
            case '*':
                value = functions_lesson_3.getPowerValue(value);
                break;
            case '/':
                value = functions_lesson_3.getDivValue(value);
                break;
        }
        if (value <= 0) value = 1;
        return value;

    }
    public static float getSumValue(float value)
    {
        return value + value;
    }
    public static float getRestValue(float value)
    {
        return value - value;
    }
    public static float getPowerValue(float value)
    {
        return value * value;
    }
    public static float getDivValue(float value)
    {
        return value / value;
    }

    public static char GetRealOperation(char[] arrOp, int index)
    {
        while (arrOp[index] == 'R')
        {
            index--;
        }
        return arrOp[index];
    }
}
