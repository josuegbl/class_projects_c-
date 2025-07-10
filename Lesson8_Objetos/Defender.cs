using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Defender : Player
{
    public Defender(string name, string team) 
        : base(name, team)
    {
    }

    public void defend()
    {
        Console.WriteLine($" player {this.name} is defending");
    }

    public void showInfo()
    {
        Console.WriteLine(this.ToString());
        Console.WriteLine($"Position: defender\n");
    }
}
