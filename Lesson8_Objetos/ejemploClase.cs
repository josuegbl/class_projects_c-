using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class ejemploClase
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo Clase");

        Console.WriteLine(
            "Hay " + NameDisplay.getDisplayCount()
             + " displays creados");

        NameDisplay portrait1 = new NameDisplay("Josue");

        Console.WriteLine(
            "Hay " + NameDisplay.getDisplayCount()
             + " displays creados");

        Console.WriteLine(
            "portrait1: " + portrait1.getName()
            );

        portrait1.setName("Carlos");
        Console.WriteLine(
            "portrait1: " + portrait1.getName());

        portrait1.sayName();

        Console.WriteLine(
            portrait1.getStatus()
        );

        NameDisplay portrait2 = new NameDisplay();

        Console.WriteLine(
            "Hay " + NameDisplay.getDisplayCount()
             + " displays creados");

        Console.WriteLine(
            "portrait2: " + portrait2.getName()
            );

        portrait2.sayName();


    }

}
