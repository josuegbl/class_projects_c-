using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class SheepCheese : Cheese
{
    string sheepType;
    public SheepCheese(int amount, string sheepType, int fatPercentage) 
        : base("Queso de Oveja", amount, fatPercentage)
    {
        this.sheepType = sheepType;
    }
    public SheepCheese(string sheepType, int fatPercentage) : base("Queso de Oveja", 10, fatPercentage)
    {
        this.sheepType = sheepType;
    }

    public void getTastingNote()
    {
        Console.WriteLine(base.ToString() + TastingNote.noteToSheepCheese() + TastingSheep.nuance(this.sheepType));
    }
}
