using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_05;

public class practicas05_1
{
    public static void Main(string[] args)
    {
        int x = 1;

        if (x > 10)
        {
            Console.WriteLine("Es mayor que 10");
        }
        else if (x <= 3)
        {
            Console.WriteLine("Es menor o igual que 3");
        }

        ///*************************************************************///
        char c1 = 'a';
        if (c1.Equals('c') || c1.Equals('d') || c1.Equals('f'))
        {
            Console.WriteLine("el caracter es una " + c1);
        }
        else
        {
            Console.WriteLine("no es ninguno de los anteriores");
        }

        ///*************************************************************///
        bool b = false;
        x = 10;
        if (!b)
        {
            Console.WriteLine("el bool no es true");
        }
        else if (x > 10)
        {
            Console.WriteLine("El bool es true y x es mayor que 10");
        }

        ///*************************************************************///
        if (b && x > 10)
        {
            Console.WriteLine("El bool es true y x es mayor que 10");
        }
        else if (!b)
        {
            Console.WriteLine("el bool no es true");
        }

        ///*************************************************************///
        if (!b)
        {
            Console.WriteLine("el bool no es true");
        }
        else if (x > 10)
        {
            Console.WriteLine("El bool es true y x es mayor que 10");
        }
        else if (x < 10)
        {
            Console.WriteLine("El bool es true y x es menor que 10");
        }

        ///*************************************************************///
        c1 = 'r';
        x = 234;

        if (c1.Equals('r') || x != 234)
        {
            if (x < 100)
            {
                Console.WriteLine("es menor que 100");
            }
            else
            {
                Console.WriteLine("no es menor que 100");
            }
        }
        else
        {
            Console.WriteLine("el caracter no es una r y x es 234");
        }
        ///*************************************************************///
        string texto = "precio";
        b = false;
        if (texto.Equals("precio") && !b)
        {
            Console.WriteLine("la cadena dice precio y el bool es falso");
        }
        else if (texto.Equals("precio"))
        {
            Console.WriteLine("la cadena dice precio");
        }
        else
        {
            Console.WriteLine("la cadena no dice precio");
        }

        ///*************************************************************///
        x = 101;
        int y = 120;
        b = true;

        if (x > 100 && y > 100)
        {
            Console.WriteLine("los dos números son mayores que 100");
            if (b)
            {
                Console.WriteLine("además, bool es true");
            }
            else
            {
                Console.WriteLine("además, bool es false");
            }
        }
        else
        {
            Console.WriteLine("al menos uno de los números no es mayor que 100");
        }

        ///*************************************************************///
        x = 10;
        y = 20;
        int z = 30;

        if (x > y && x > z)
        {
            Console.WriteLine("x es mayor que y and z");
            if (y > z)
            {
                Console.WriteLine("y es mayor que z");
            }
            else if (y < z)
            {
                Console.WriteLine("z es mayor que y");
            }
        }
        else
        {
            if (y > x)
            {
                Console.WriteLine("y es mayor que x");
            }
            if (z > x)
            {
                Console.WriteLine("z es mayor que x");
            }
        }



    }
}
