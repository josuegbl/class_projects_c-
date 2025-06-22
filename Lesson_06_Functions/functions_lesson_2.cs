using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class functions_lesson_2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Functions");
        //*****************************
        functions_lesson_2.returnTwoStrings("String 1 y ...", "String 2, tachan!");
        //*****************************
        bool validateComparison = functions_lesson_2.compareTwoNUmbers(2, 2);
        Console.WriteLine("Los numeros son iguales? " + validateComparison);
        //*****************************
        int maximumFromArray = functions_lesson_2.getMaximumFromArray([-341, -7, -322, -53, -767, -1]);
        Console.WriteLine("El maximo numero del array es: " + maximumFromArray);
        //*****************************
        float sumaFromArray = functions_lesson_2.sumFloats([12, -1.34F, -1, 7]);
        Console.WriteLine("La suma del array es: " + sumaFromArray);
        //*****************************
        char[] smsInchar = ['h', 'e', 'm', 'o', 's', ' ', 'a', 'p', 'r', 'e', 'n',
                            'd', 'i', 'd', 'o', ' ', 'f', 'u', 'n', 'c', 'i', 'o',
                            'n', 'e', 's', ' ', 'h', 'o', 'y', '!'];
        string mergeArray = functions_lesson_2.mergeChars(smsInchar);
        Console.WriteLine(mergeArray);
        //*****************************
        int[] composeArr = functions_lesson_2.composeArrayIntegers(3, 6, 7);

        Console.WriteLine("El array es : ");
        for (int i = 0; i < composeArr.Length; i++)
        {
            Console.Write(composeArr[i] + ", ");
        }
        Console.WriteLine("\n");


    }

    public static int test()
    {
        return 1;
    }

    /// Diseña los siguientes prototipos de funciones e incluye
    /// la linea de retorno de la funcion si aplica
    /// 
    /// Una funcion que no devuelva nada y reciba dos string como parametros
    public static void funtionReturnVoidEnterTwoStrings(string string1, string string2)
    {
    }


    /// UNa funcion que devuelva un booleano y reciba dos enteros como parametro
    public static bool functionReturnBoolEnterTwoInts(int a, int b)
    {
        return true;
    }

    /// Una funcion que devuelva un entero y reciba como parametro
    /// un array de enteros
    public static int functionReturnIntEnterArrayInts(int[] a)
    {
        return a[0];
    }

    /// UNa funcion que devuelva un numero en coma flotante y reciba como 
    /// parametro un array de numeros en coma flotante
    public static float functionReturnFloatEnterArrayFloat(float[] a)
    {
        return a[0];
    }

    /// Una funcion que devuelva un string y reciba como parametro
    /// un array de caracteres
    public static string functionReturnStringEnterArrayChar(char[] a)
    {
        string varString ="lo que sea";
        return varString;
    }

    /// una funcion que devuelva un array de enteros y reciba
    /// tres enteros como parametros

    public static int[] functionReturnArrayIntEnterThreeInts(int a, int b, int c)
    {
        return [ a, b, c];
    }

    /// Diseña e implementa las siguientes funciones. Prueba las funciones llamandolas 
    /// desde la funcion Main e incluye el codigo utilizado para la llamada.

    /// una funcion que no devuelva nada y reciba dos strings como parametros.
    /// la función mostrará por pantalla los dos strings
    public static void returnTwoStrings(string s1, string s2)
    {
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }

    /// Una funcion que devuelva un booleano y reciba dos enteros como parametro.
    /// La funcion devolverá true si los dos numeros son iguales; false en caso contrario
    public static bool compareTwoNUmbers(int number1, int number2)
    {
        return (number1 == number2) ? true : false;
    }

    /// Una función que devuelva un entero y reciba como parametro un array de enteros.
    /// La funcion devolverá el máximo de los números que contenga el array.
    public static int getMaximumFromArray(int[] arrInt)
    {
    int max = arrInt[0];

    for (int i=1; i < arrInt.Length; i++)
    {
        if (arrInt[i] > max)
        {
            max = arrInt[i];
        }
    }
    return max;
    }

    /// UNa funcion que devuelva un numero en coma flotante y reciba como parametro un
    /// array de numeros en coma flotante. La funcion devolvera la suma de los numeros
    /// del array.
    public static float sumFloats(float[] arrFloats)
    {
        float suma = 0F;
        foreach (float val in arrFloats)
        {
            suma += val;
        }
        return suma;
    }

    /// UNa funcion que devuelva un String y reciba como parametro un array de caracteres.
    /// La función devolverá un String compuesto por los carcteres, en orden, del array.
    public static string mergeChars(char[] arrCDhar)
    {
        string mergeCHars = "";
        foreach(char c in arrCDhar)
        {
            mergeCHars += c;
        }
        return mergeCHars;
    }

    /// Una funcion que devuelva un array de enteros y reciba tres enteros como parametro.
    /// La funcion devolvera un array compuesto de los numeros pasados como parametro.
    public static int[] composeArrayIntegers(int a, int b, int c)
    {
        return [a, b, c];
    }
}
