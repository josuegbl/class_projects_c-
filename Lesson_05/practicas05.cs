using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class practicas05
{
    public static void Main(string[] args)
    {
        int x = 1;
        int y = 2;

        if (x == y) 
        {
            Console.WriteLine("Cantidades iguales");
        }
        ///*************************************************************///
        string texto1 = "sdfgas";
        string texto2 = "sdfgas";

        if (texto1 == texto2) 
        {
            Console.WriteLine("texto iguales");
        }
        ///*************************************************************///
        int num1 = 1;
        int num2 = 2;
        int num3 = 4;

        if (num3 >= num1 + num2)
        {
            Console.WriteLine("la suma es menor");
        }

        ///*************************************************************///
        char caracter1 = 'a';
        char caracter2 = 'a';

        if (caracter1 == caracter2 && num1 != num3)
        {
            Console.WriteLine("caracter1 == caracter2 && num1 == num3");
        }

        ///*************************************************************///
        int num4 = 10;
        int num5 = 20;
        int num6 = 10;
        int multi = num4 * num4;
        int sum = num4 + num4;

        if (multi + sum >= num5)
        {
            Console.WriteLine("multi + sum >= num5");
        }

        ///*************************************************************///
        bool variable = true;

        if ( variable && texto1 == texto2)
        {
            Console.WriteLine("variable es true y texto1 == texto2");
        }

        ///*************************************************************///
        int num7 = -10;
        int num8 = -2;

        if (num7 / num8 >= 0  || (num7 - num8) > 2)
        {
            Console.WriteLine("la division es positiva OR la resta es mayor que 2");
        }

        ///*************************************************************///
        char caracter3 = 'a';
        if (caracter3 == caracter1 || caracter3 == caracter2)
        {
            Console.WriteLine("caracter3 es igual a uno de los otros");
        }

        ///*************************************************************///
        bool variable2 = true;

        if ((variable || variable2) && (caracter1 != caracter2))
        {
            Console.WriteLine("variable && variable2 && caracter1 != caracter2");
        }

        ///*************************************************************///
        int numMultiplicado = num1 * num2 * num3;
        if (numMultiplicado <= 20 || numMultiplicado >= 30 || texto1 == texto2)
        {
            Console.WriteLine($"numMultiplicado({numMultiplicado}) <= 20 || numMultiplicado >= 30 || texto1 ({texto1}) == texto2 ({texto2}) ");
        }

    }
}
