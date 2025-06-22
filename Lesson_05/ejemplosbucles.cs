using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejemplosbucles
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo bucles");
        //**********************************************

        Console.WriteLine("\n FOR");
        

        int i = 0;
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("i es " + i);
        }

        Console.WriteLine("\n WHILE");
        i = 0;
        while (i < 10)
            {
            Console.WriteLine("i es " + i);
            i++;
            }

        i = 0;
        Console.WriteLine("\n DO WHILE");
        do
        {
            Console.WriteLine("i es " + i);
            i++;

        } while (i < 10);

        int[] nums = { 2, 3, 4, 6, 7 };
        Console.WriteLine("\n FOR EACH");
        foreach (int num in nums)
        {
            Console.WriteLine("el numero es; " + num);
        }

        Console.WriteLine("\nTEST  CONTINUE and BRAKE");
        i = 0;

        while (i < 10)
        {
            if (i %  2 == 0)
            {
                Console.WriteLine("Es par, me salto 3 numeros");
                i += 3;
                continue;
            }
            else if (i==7)
            {
                Console.WriteLine("Es el fin");
                break;
            }
            else
            {
                Console.WriteLine("No es par " + i);
            }
            i++;
        }

    }
}
