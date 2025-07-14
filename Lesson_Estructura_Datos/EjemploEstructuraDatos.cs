using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class EjemploEstructuraDatos
{
    static void Main1(string[] args)
    {
        Console.WriteLine("En ejemploEstructuraDatos");

        List<string> list = new List<string>();

        list.Add("Hola");
        list.Add("Mundo");
        list.Add("!");

        foreach (string stringItem in list)
        {
            Console.WriteLine(stringItem);
        }

        Console.WriteLine("\n\n");

        list.Add("Más");
        list.Add("Cosas");

        foreach (string stringItem in list)
        {
            Console.WriteLine(stringItem);
        }

        Console.WriteLine("\n\n");

        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);
        Console.WriteLine(list[4]);

        Console.WriteLine("\n\n");
        list[1] = "Curso";
        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);
        Console.WriteLine(list[4]);

        Console.WriteLine("\n\n");

        foreach (string stringItem in list)
        {
            Console.WriteLine(stringItem);
        }

        Console.WriteLine("La lista contiene " + list.Count + " elementos");
        Console.WriteLine("La lista contiene el elemento Hola  " + list.Contains("Hola"));
        Console.WriteLine("La lista contiene el elemento Mundo  " + list.Contains("Mundo"));
        Console.WriteLine("La lista contiene el elemento Curso  " + list.Contains("Curso"));
        Console.WriteLine(list.Remove("Curso"));
        Console.WriteLine("La lista contiene el elemento Curso  " + list.Contains("Curso"));
        Console.WriteLine("La lista contiene " + list.Count + " elementos");
        Console.WriteLine("El index del elemento Más es " + list.IndexOf("Más"));

        list.Insert(2, "Muchas");
        foreach (string stringItem in list)
        {
            Console.WriteLine(stringItem);
        }

        Console.WriteLine("La lista contiene " + list.Count + " elementos");

        Console.WriteLine("La capacidad de la lista es " + list.Capacity);

        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");
        list.Add("Muchas");

        Console.WriteLine("La lista contiene " + list.Count + " elementos");

        Console.WriteLine("La capacidad de la lista es " + list.Capacity);

        list.Clear();

        Console.WriteLine("La lista contiene " + list.Count + " elementos");

        Console.WriteLine("La capacidad de la lista es " + list.Capacity);


        List<int> inst = new List<int>() { 2, 4, 6, 8 };


        Console.WriteLine("\nDICTIONARY\n");

        Dictionary<string, string> completeNames = new Dictionary<string, string>();

        completeNames.Add("Josue", "Gomez");
        completeNames.Add("Otro", "Nombre");
        completeNames.Add("Nuevo", "Nombre");

        foreach (KeyValuePair<string, string> item in completeNames)
        {
            Console.WriteLine("Key es " + item.Key + " y el Value es " + item.Value);
        }

        Console.WriteLine("El dict contiene " + completeNames.Count + " elementos");

        completeNames["Manolo"] = "Perez";

        Console.WriteLine("El dict contiene " + completeNames.Count + " elementos");


        string apellidoDeManolo = completeNames["Manolo"];
        Console.WriteLine(apellidoDeManolo);


        Console.WriteLine("El dict contiene la Key Josue es " + completeNames.ContainsKey("Josue"));
        Console.WriteLine("El dict contiene la Value Gomez es " + completeNames.ContainsValue("Gomez"));

        Console.WriteLine(completeNames.Remove("Manolo"));

        Console.WriteLine("El dict contiene la Key Manolo es " + completeNames.ContainsKey("Manolo"));

        Dictionary<string, int> stockProducts = new Dictionary<string, int>()
        { {"Salchichon" , 3 }
            , {"Morcilla" , 30 }
            ,{"Chorizo" , 2 }
        };
        // Enum.GetValues necesitamos que sea iterable, por eso se pone de esta forma.
        foreach (TipoProducto tipoProducto in Enum.GetValues(typeof(TipoProducto)))
        {
            Console.WriteLine(tipoProducto);
        }

        // esto te devuelve los valores numéricos.
        foreach (int tipoProducto in Enum.GetValues(typeof(TipoProducto)))
        {
            Console.WriteLine(tipoProducto);
        }


    }

}
