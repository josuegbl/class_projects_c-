using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Horno : AparatoElectrico
{
    string model;
    int power;
    string[] functions;

    public Horno(string model, int power, int voltage, string[] functions)
        : base(voltage)
    {
        this.model = model;
        this.power = power;
        this.functions = functions;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Este es un horno {this.model}");
        Console.WriteLine($"con {this.power} vatios de potencia, " + getVoltage() + " voltios");
        Console.WriteLine($" y sus funciones son:");
        foreach(string function in this.functions)
        {
            Console.WriteLine(function);
        }
    }
}
