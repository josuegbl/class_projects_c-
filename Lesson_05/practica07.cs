using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class practica07
{
    public static void Main(string[] args)
    {
        string texto1 = "Hola ";
        string texto2 = "Mundo. ";
        string texto3 = "Bienvenidos a ";
        string texto4 = "Clase";
        string cadenaResultante = string.Empty;
        bool boolTexto1 = true;
        bool boolTexto2 = true;
        bool boolTexto3 = true;
        bool boolTexto4 = true;

        if (boolTexto1)
        {
            cadenaResultante += texto1;
        }
        if (boolTexto2)
        {
            cadenaResultante += texto2;
        }
        if (boolTexto3)
        {
            cadenaResultante += texto3;
        }
        if (boolTexto4)
        {
            cadenaResultante += texto4;
        }
        Console.WriteLine("La cadena resultante es: " + cadenaResultante);

        //*************************************************************
        int lengthCadena1 = 6;
        int lengthCadena2 = 3;
        boolTexto1 = false;
        boolTexto2 = false;

        if (texto1.Length > lengthCadena1)
        {
            boolTexto1 = true;
        }
        if (texto2.Length > lengthCadena2)
        {
            boolTexto2 = true;
        }

        if (boolTexto1 && boolTexto2)
        {
            Console.WriteLine("las dos son true");
        }
        else if (!boolTexto1 && boolTexto2)
        {
            Console.WriteLine("solo la segunda es true");
        }
        else if (boolTexto1 && !boolTexto2)
        {
            Console.WriteLine("solo la primera es true");
        }
        else
        {
            Console.WriteLine("ninguna es true");
        }

        Console.WriteLine("los valores de los bools son: " + boolTexto1 + " y " + boolTexto2);
        //*************************************************************
        int numero = 1;
        char aChar = 'a';
        texto1 = "POSITIVO";

        if (aChar == 'a' || aChar == 'e' || aChar == 'i' || aChar == 'o' || aChar == 'u')
        {
            if (numero < 0)
            {
                Console.WriteLine(aChar);
            }
            else if (numero == 0)
            {
                Console.WriteLine("el numero es " + numero);
            }
            else
            {
                if (texto1 == "POSITIVO")
                {
                    Console.WriteLine(texto1);
                }
                else
                {
                    Console.WriteLine("CASI POSITIVO");
                }
            }
        }
        else
        {
            Console.WriteLine(aChar);
        }
        //*************************************************************


        //*************************************************************
        string favoritoLogan = "Roman";
        bool KendalQuiere = true;
        bool RomanlQuiere = false;
        bool ShivQuiere = true;
        bool ConnorQuiere = false;
        string nombreSucesores = "";

        if (!KendalQuiere && !RomanlQuiere && !ShivQuiere && !ConnorQuiere)
        {
            Console.WriteLine("Nadie quiere suceder");
        }
        else if (favoritoLogan == "Kendal" && KendalQuiere)
        {
            Console.WriteLine("Kendal es el sucesor");
        }
        else if (favoritoLogan == "Roman" && RomanlQuiere)
        {
            Console.WriteLine("Roman es el sucesor");
        }
        else if (favoritoLogan == "Shiv" && ShivQuiere)
        {
            Console.WriteLine("Shiv es el sucesor");
        }
        else if (favoritoLogan == "Connor" && ConnorQuiere)
        {
            Console.WriteLine("Connor es el sucesor");
        }
        else
        {
            if (KendalQuiere)
            {
                nombreSucesores += "Kendall ";
            }
            if (RomanlQuiere)
            {
                nombreSucesores += "Roman ";
            }
            if (ShivQuiere)
            {
                nombreSucesores += "Shiv ";
            }
            if (ConnorQuiere)
            {
                nombreSucesores += "Connor ";
            }
            Console.WriteLine("Los posibles sucesores son: " + nombreSucesores);
        }

        //*************************************************************
        float dineroCliente = 54211;
        float percentOwnCompany1 = 0.25F;
        float percentOwnCompany2 = 0.1F;
        float percentOwnCompany3 = 0.6F;
        float percentOwnCompany4 = 0.26F;
        float dividendoCOmpany1 = 100;
        float dividendoCOmpany2 = 654;
        float dividendoCOmpany3 = 1904;
        float dividendoCOmpany4 = 807;
        float dividendosCliente = percentOwnCompany1 * dividendoCOmpany1
                                  + percentOwnCompany2 * dividendoCOmpany2
                                  + percentOwnCompany3 * dividendoCOmpany3
                                  + percentOwnCompany4 * dividendoCOmpany4;


        float dineroDisponible = dineroCliente + dividendosCliente;
        Console.WriteLine("El dinero total disponible es :" + dineroDisponible);
        Console.WriteLine("El ratio de la cartera es: " + dividendosCliente/dineroCliente);

        if (dividendosCliente > 1000)
        {
            Console.WriteLine("BUENO");
        }
        else if (dividendosCliente >= 500 || dividendosCliente <= 1000)
        {
            Console.WriteLine("ESTANDAR");
        }
        else
        {
            Console.WriteLine("BAJO");
        }
    

    //*************************************************************
    //Dado un numero natural (del 0 al 9), si este es par, sacarlo por pantalla;
    // en el caso que no sea par, mostrar el numero que es por pantalla usando 
    //una cadena de texto (si es un siete, mostrar "SIETE") y evaluar si es mayor o menor
    // que el mayor valor de otros tres numeros enteros, mostrando por pantalla si lo es o no.
        int x = 7;
        int y = 1;
        int z = 5;
        int a = 8;
        int mayor = 0;

        if (x % 2 == 0)
        {
            Console.WriteLine("ES PAR: " + x);
        }
        else
        {
            if (y >= z && y >= a)
            {
                mayor = y;
            }
            else if (z >= y && z >= a)
            {
                mayor = z;
            }
            else
            {
                mayor = a;
            }

            if (x > mayor)
            {
                Console.WriteLine("es mayor que " + mayor);
            }
            else
            {
                Console.WriteLine("No es mayor que " + mayor);
            }
            switch (x)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                default:
                    Console.WriteLine("NUEVE");
                    break;
            }
        }

    //*************************************************************

    //*************************************************************

    //*************************************************************

    //*************************************************************
    }
}
