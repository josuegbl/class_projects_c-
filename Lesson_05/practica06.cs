using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class practica06
{
    public static void Main(string[] args)
    {
        int x = 2;
        int y = 1;

        if (x > y)
        {
            Console.WriteLine("Es Mayor");
        }
        else
        {
            Console.WriteLine("No es mayor");
        }

        //*************************************************************
        string cad1 = "es igual";
        string cad2 = "es igual";
        x = 1;
        y = 1;

        if (cad1 == cad2 && x == y)
        {
            Console.WriteLine("todo igual");
        }
        else if (cad1 == cad2)
        {
            Console.WriteLine("cadenas iguales");
        }
        else if (x == y)
        {
            Console.WriteLine("números iguales");
        }
        else
        {
            Console.WriteLine("nada igual");
        }

        //*************************************************************
        bool arroz = true;
        bool pollo = true;
        bool judias = true;

        if (arroz && pollo && judias)
        {
            Console.WriteLine("se puede hacer la paella");
        }
        else
        {
            Console.WriteLine("no se puede hacer la paella");
            if (!arroz)
            {
                Console.WriteLine("falta arroz");
            }
            if (!pollo)
            {
                Console.WriteLine("falta pollo");
            }
            if (!judias)
            {
                Console.WriteLine("falta judías");
            }
        }

        //*************************************************************
        float z = 6;
        bool b = true;

        if (z < 5 && z > 3)
        {
            Console.WriteLine("a lo mejor es 4");
            if (z == 4)
            {
                Console.WriteLine("Es 4");
            }
        }
        else if (z > 5)
        {
            Console.WriteLine("Es mayor que 5");
        }
        else if (z < 3)
        {
            Console.WriteLine("Es menor que 3");
        }
        else if (z == 3 && b)
        {
            Console.WriteLine("es igual a 3");
        }

        //*************************************************************
        char codigoHUevo = '0';

        switch (codigoHUevo)
        {
            case '0':
                Console.WriteLine("0 - Gallinas Ecologicas");
                break;

            case '1':
                Console.WriteLine("1 - Gallinas camperas");
                break;
            case '2':
                Console.WriteLine("2 - Criadas en suelo");
                break;
            case '3':
                Console.WriteLine("3 - Criadas en jaula");
                break;
            default:
                Console.WriteLine("Código incorrecto");
                break;
        }

        //*************************************************************
        float dineroPersona = 10000;
        float hipoteca = 150000;
        float entradaHipoteca = 0.2F;
        bool evaluacionRiesgos = false;

        if (dineroPersona >= entradaHipoteca * hipoteca && evaluacionRiesgos)
        {
            Console.WriteLine("Hipoteca concedida. Cumple con todos los requisitos");
        }
        else if (!evaluacionRiesgos)
        {
            Console.WriteLine("Lo sentimos. Ud. no cumple con la evaluacion de riesgos.");
        }
        else
        {
            Console.WriteLine("Lo sentimos. No dispone suficiente dinero para la entrada del piso.");
        }

        //*************************************************************
        string nombreVengador = "Hulk";

        switch (nombreVengador)
        {
            case "Iron Man":
                Console.WriteLine("Tony Stark");
                break;
            case "Capitan Ameríca":
                Console.WriteLine("Steve Rogers");
                break;
            case "Viuda Negra":
                Console.WriteLine("Natasha Romanoff");
                break;
            case "Hulk":
                Console.WriteLine("Bruce Banner");
                break;
        }

        //*************************************************************
        int peras = 11;
        int manzanas = 10;
        int uvas = 11;

        if (manzanas > peras)
        {
            Console.WriteLine("tengo más manzanas que peras ");
            if (manzanas == 10)
            {
                Console.WriteLine("y son 10 justas");
            }
        }
        else if (manzanas > uvas && manzanas == 10)
        {
            Console.WriteLine("tengo más manzanas que uvas ");
            Console.WriteLine("y son 10 justas");
        }
        else
        {
            if (manzanas == 10)
            {
                Console.WriteLine("¿De que me sirven estas 10 manzanas?");
            }
            else if (manzanas < 5)
            {
                Console.WriteLine("tengo que comprar manzanas que se me acaban");
            }
        }
    

        //*************************************************************
        if (manzanas == 10)
        {
            if (manzanas > peras)
            {
                Console.WriteLine("tengo más manzanas que peras ");
                Console.WriteLine("son 10 justas");
            }
            else if (manzanas > uvas)
            {
                Console.WriteLine("tengo más manzanas que uvas ");
                Console.WriteLine("son 10 justas");
            }
            else
            {
                Console.WriteLine("¿De que me sirven estas 10 manzanas?");
            }
        }
        else
        {
            if (manzanas > peras)
            {
                Console.WriteLine("tengo más manzanas que peras ");
            }
            else if (manzanas < uvas && manzanas < 5)
            {
                Console.WriteLine("tengo que comprar manzanas que se me acaban");
            }
        }

        //*************************************************************
        float ratioEndeudamiento = 0.5F;
        float cantidaDinero = 10000;

        if (ratioEndeudamiento >= 0.8)
        {
            Console.WriteLine("DENEGAR");
        }
        else if (ratioEndeudamiento < 0.2)
        {
            if (cantidaDinero < 10000)
            {
                Console.WriteLine("CONSULTAR");
            }
            else
            {
                Console.WriteLine("CONCEDER");
            }
        }
        else if (ratioEndeudamiento >= 0.2 && ratioEndeudamiento <= 0.5)
        {
            if (cantidaDinero > 20000)
            {
                Console.WriteLine("CONCEDER");
            }
            else
            {
                Console.WriteLine("CONSULTAR");
            }
        }
        else
        {
            Console.WriteLine("CONSULTAR");
        }

        //*************************************************************
        bool perasBaratas = true;
        bool uvasBaratas = false;
        bool uvasEstanTicas = false;
        bool perasEstanRicas = false;

        if (uvasBaratas)
        {
            Console.WriteLine("compar uvas");
        }
        else if (uvasEstanTicas)
        {
            Console.WriteLine("comprar uvas");
        }
        else
        {
            if (perasBaratas && perasEstanRicas)
            {
                Console.WriteLine("Comprar peras, Hay que ahorrar!");
            }
            else
            {
                Console.WriteLine("Nada");
            }

        }
        //**************************************************
        if (uvasBaratas || uvasEstanTicas)
        {
            Console.WriteLine("comprar uvas");
        }
        else if (perasBaratas && perasEstanRicas)
        {
            Console.WriteLine("Comprar peras, Hay que ahorrar!");
        }
        else
        {
            Console.WriteLine("Nada");
        }

        //******************************************************
     }
}