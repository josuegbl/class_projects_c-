using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos
{
    public class GoatCheese : Cheese
    {
        public GoatCheese(int amount, int fatPercentage) : base("Queso de Cabra", amount, fatPercentage)
        {
            
        }
        public GoatCheese(int fatPercentage) : base("Queso de Cabra", 10, fatPercentage)
        {
            
        }

        public void getTastingNote()
        {
            Console.WriteLine(base.ToString() + TastingNote.noteToGoatCheese());
        }

    }
}
