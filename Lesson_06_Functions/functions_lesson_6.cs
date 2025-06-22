using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class functions_lesson_6
{
    public static void Main(string[] args)
    {
        //int numberOfChars = 1;
        //string outFunc = functions_lesson_6.getFromConsole(numberOfChars);
        //Console.WriteLine(outFunc);
        ////*****************************************

        //string[] productsAndPrices = ["manzanas", "1,20", "peras", "2,49", "fresas", "8,99", "uvas", "4,49",
        //                              "platanos", "3,78", "calabazas", "3,56", "tomates", "2,49", "melocotones", "4,29"];
        //string[] productsPaid = functions_lesson_6.getShopCar(productsAndPrices, 10.5F);
        //foreach (string product in productsPaid) Console.WriteLine(product);

        functions_lesson_6.vasoMatic2000k(10);
    }
    //*Crear una funcion que reciba un numero entero y devuelva un string.
    //-La funcion ira pidiendo tantos caracteres por consola como indique el numero.
    //-Los caracteres se iran introducionedo por consola uno a uno.
    //-Si el caracter introducido ser puede convertir a un numero, hacerlo.
    //-Todos los caracteres convertidos a numero se iran sumando, guardando el valor de esa suma.
    //-Si el caracter no es numerico, guardalo.
    //-Cuando se llegue al numero de caracteres pedidos, la funcion mostrara por consola la suma acumulada de los caracteres numericos.
    //-La funcion devolvera como resultado un string compuesto por los caracteres introducidos por consola, que habra que mostrar por consola.
    //-NOTA: Consultar la funcion Console.ReadLine.
    //-PISTA. Recordar que se puede "parsear" los strings.
    public static string getFromConsole(int numberOfChars)
    {
        Console.WriteLine("Enter {0} characters one by one : ", numberOfChars);
        int suma = 0;
        string outString = "";
        for (int i = 1; i <= numberOfChars; i++)
        {
            string charFromConsole = Console.ReadLine();
            if (int.TryParse(charFromConsole, out int val))
            {
                suma += val;
            }
            else
            {
                outString += charFromConsole;
            }
        }
        Console.WriteLine("La suma es {0}", suma);
        return outString;
    }

    //* Crear una funcion que reciba un array de string y un numero en coma flotante, simple precision.
    // Devolvera un array de string.
    // -El array contendra nombres de productos y sus precios asociados.
    // -Por cada nombre de producto habra solo un precio asociado.
    // -Yendo en el orden en el que esten los productos del array, ir sumando sus precios mientras no se
    // supere el umbral indicado por el parametro numero de la funcion.
    // -Una vez se supere el umbral, o se hayan precesado todos los prductos, devolver sus nombres en el
    // array de retorno de la funcion.
    // -El programa debera imprimir por pantalla los prodcutos devueltos como resultado de la funcion.
    // -Pensar un contenido y orden adecuado para el array de entrada.
    public static string[] getShopCar(string[] productsAndPrices, float totalToSpend)
    {
        float subTotal = 0;
        string[] products = new string[productsAndPrices.Length / 2];
        for (int i = 0, j = 1; j < productsAndPrices.Length; i +=2, j +=2)
        {
            subTotal += float.Parse(productsAndPrices[j]);
            if (subTotal <= totalToSpend)
            {
                products[i / 2] = productsAndPrices[i];
            }
        }
        return products;
    }

    //*Crear la funcion Vasomatic 2.000K+
    //-La funcion recibira por parametro un numero entero (minimo 4  y maximo 10) y no devolvera nada.
    //-Se pintara en consola un "vaso" de 3 caracteres de ancho y un alto indicado por el numero pasado como parametro.
    //-El vaso empezara "vacio".
    //-El vaso se ira llenando de "agua" (caracteres apropiados de color azul) a razon de un "nivel" cada vez.
    //-Cada vez que se llene un "nivel" del vaso, hacer el programa espere al menos un segundo.
    //-Seguir llenando el vaso hasta que alcance el maximo de llenado.
    //-Cuando el vaso este "lleno" el programa terminara.
    public static void vasoMatic2000k(int height)
    {
        int width = 5;

        if (height >= 4 || height <= 10)
        {

            functions_lesson_6.glass(height, width);
            Console.ResetColor();
            functions_lesson_6.water(height, width);
        }
    }

    public static void glass(int height, int width)
    {
        // Console.SetCursorPosition(Console.CursorTop, Console.CursorLeft);
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (i == height)
                {
                    if (j == 1)
                        Console.Write('╚');
                    else if (j == width)
                        Console.Write('╝');
                    else
                        Console.Write('═');
                }
                else if (j == 1 || j == width)
                {
                    Console.Write('║');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
    public static void water(int height, int width)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        

        for (int i = height-2; i >= 0; i--)
        {
            Console.SetCursorPosition(1, i);

            for (int j = 2; j <= width-1; j++)
            {
                Console.Write(' ');
            }
            Thread.Sleep(1000);
            
        }
        Thread.Sleep(1000);
        Console.ResetColor();
        Console.SetCursorPosition(0, Console.WindowHeight/2);
    }


}
