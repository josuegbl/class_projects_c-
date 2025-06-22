using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson_05;

public class ejercicios_arr_bucles
{
    public static void Main(string[] args)
    {
        // Diseña e implementa los siguientes bucles:
        // Usa un bucle while para mostrar cada numero de un array
        // de enteros mientras que el numero a mostrar no sea un 5
        int[] arrInts = {76,73,7,8,5,2,12,5,6};
        
        int i = 0;
        while (i < arrInts.Length)
        {
            if (arrInts[i] != 5)
            { 
                Console.WriteLine(arrInts[i]);
            }
            i++;
        }
        Console.WriteLine("\n");

        //***************
        // Usa un bucle do while para mostrar el contenido de un array
        // de caracteres que el caracter no sea una c
        char[] arrChars = { 'a', 'b', 'd', 'c', 'e' };        
        i = 0;
        do
        {
            if (arrChars[i] != 'c')
            {
                Console.WriteLine(arrChars[i]);
            }
            i++;
        } while (i < arrChars.Length);

        Console.WriteLine("\n");

        //***************
        // Usa un bucle for each para recorrer un array de numeros short y mostrarlos
        short[] arrShorts = { 1, 3, 4, 5, 6, 2, 8, 9};
        i = 0;
        foreach (short s in arrShorts)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\n");

        //***************
        //Usa un bucle apropiado para recorrer un array de booleanos y
        //mostrar su valor por pantalla siempre que sea distinto de false
        bool[] arrBools = { true, true, true, true, false, false, true, true, false};

        for (i=0; i < arrBools.Length; i++)
        {
            if (arrBools[i]) { Console.WriteLine(arrBools[i]); }
        }
        Console.WriteLine("\n");

        //***************
        //Usa un bucle apropiado para ir sumando a un numero el numero 3
        //mientras que la suma total sea menor que 20. Sacar por consola
        //la suma total en ese momento en cada iteracion
        int j = 2;
        while (j < 20)
        {
            j += 3;
            Console.WriteLine(j);
        }
        Console.WriteLine("\n");

        //***************
        //Usa un bucle apropiado para recorrer un array de cadenas de
        //texto e ir mostrando su contenido por pantalla
        string[] arrStrs = {"En ", "esta ", "clase ", "hay ", "tios ", "muy ","listos"};

        for (i=0;i < arrStrs.Length;i++)
        {
            Console.WriteLine(arrStrs[i]);
        }
        Console.WriteLine("\n");

        //***************
        // Usar un bucle para ir recorriendo al mismo tiempo un array
        // de booleanos y otro de numeros, del mismo tamaño. Siempre
        // y cuando el valor del array de booleanos no sea true y el de 
        // numeros un 2, en ese caso terminar el bucle; en caso contrario,
        // si el valor el array de booleanos es true, sacar el numero por pantalla

        for (i=0; i < arrInts.Length; i++)
        {
            if (!arrBools[i] && arrInts[i] == 2)
            {   
                break;
            }
            else if (arrBools[i])
            {
                Console.WriteLine(arrInts[i]);
            }
        }

        //***************



        //***************



        //***************



        //***************



        //***************










    }
}
