using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.GOT;

public class PersonajeLannister : PersonajesGOT
{
    protected static Lannister casa;

    public PersonajeLannister(string name)
    {
        this.name = name;
        PersonajeLannister.casa = new Lannister();
    }

    public override void presentarse()
    {
        Console.WriteLine($"Mi nombre es {this.name} y {PersonajeLannister.casa.Lema()}");
    }
}
