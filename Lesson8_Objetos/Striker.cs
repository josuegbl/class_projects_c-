using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Striker : Player
{
    public Striker(string name, string team)
        : base(name, team)
    {
    }

    public void strike()
    {
        Console.WriteLine($" player {this.name} is striking");
    }

    public void showInfo()
    {
        Console.WriteLine(this.ToString());
        Console.WriteLine($"Position: striker\n");
    }
}
