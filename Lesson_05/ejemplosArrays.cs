using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejemplosArrays
{
    public static void Main(string[] args)
    {
        //int[] numbers;
        //numbers = new int[10];

        // otra forma de inicializar
        //int[] numbers = new int[10];

        //numbers[0] = 1;

        //long[] longs = new long[10];

        //string[] strings = new string[3];
        //string[] strings2 = { "dsfg", "dgdgfg", "dfff" };

        //Console.WriteLine("El tamaño del array de integers es: " + numbers.Length);
        //Console.WriteLine("El tamaño del array de strings2 es: " + strings2.Length);

        //******************************************

        float[] arrFloat = new float[10];
        bool[] arrBool = new bool[4];
        long[] arrLong = new long[3];
        int[] arrInt = new int[4];
        string[] arrString = new string[7];

        arrFloat[0] = 3.4F;
        arrFloat[9] = 8.2F;
        Console.WriteLine("Primer valor y 3er valor de arrFloat; " + arrFloat[0]+ " y " + arrFloat[2]);

        arrBool[1] = true;
        arrBool[2] = true;

        Console.WriteLine("valor arrBool 1: " + arrBool[0]);
        Console.WriteLine("valor arrBool 2: " + arrBool[1]);
        Console.WriteLine("valor arrBool 3: " + arrBool[2]);
        Console.WriteLine("valor arrBool 4: " + arrBool[3]);

        arrLong[0] = 3456L;
        arrLong[1] = 100000L;
        arrLong[2] = arrLong[0] + arrLong[1];

        Console.WriteLine("el tercer valor: " + arrLong[2]);

        arrInt[0] = arrBool[0] ? 1 : -1; //? operador ternario. Funciona como un if.

        //if (arrBool[0])
        //{
        //    arrInt[0] = 1;
        //}
        //else
        //{
        //    arrInt[0] = -1;
        //}
        if (arrBool[1])
        {
            arrInt[1] = 1;
        }
        else
        {
            arrInt[1] = -1;
        }
        if (arrBool[2])
        {
            arrInt[2] = 1;
        }
        else
        {
            arrInt[2] = -1;
        }
        if (arrBool[3])
        {
            arrInt[3] = 1;
        }
        else
        {
            arrInt[3] = -1;
        }

        Console.WriteLine("valores del arrInt: " + arrBool[0] + arrInt[0]);
        Console.WriteLine("valores del arrInt: " + arrBool[1] + arrInt[1]);
        Console.WriteLine("valores del arrInt: " + arrBool[2] + arrInt[2]);
        Console.WriteLine("valores del arrInt: " + arrBool[3] + arrInt[3]);

        arrString[0] = "aaa";
        arrString[1] = "bbb";
        arrString[2] = "ccc";
        arrString[3] = "ddd";
        arrString[4] = "eee";
        arrString[5] = "fff";
        arrString[6] = arrString[0] + arrString[1] + arrString[2] + arrString[3] + arrString[4] + arrString[5];
        Console.WriteLine("el ultimo valor de arrString es " + arrString[6]);

        //**********************************************************



    }
}
