using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos
{
    public class CowCheese : Cheese
    {
        int milkingDays;

        public CowCheese(int amount, int milkingDays, int fatPercentage) : base("Queso de vaca", amount, fatPercentage)
        {
            this.milkingDays = milkingDays;
        }

        public CowCheese(int milkingDays, int fatPercentage) : base("Queso de vaca", 10, fatPercentage)
        {
            this.milkingDays = milkingDays;
        }

        public string nuance()
        {
            string text;

            if (this.milkingDays <= 3)
            {
                text = "Matiz: Menos de 72h de ordeñada. Sabor suave";
            }
            else if (this.milkingDays <= 10)
            {
                text = "Matiz: menos de 10 días de ordeñada. Sabor equilibrado";
            }
            else
            {
                text = "Matiz: más de 10 días de ordeñada. Sabor fuerte";
            }
            return text;
        }

        public void getTastingNote()
        {
            Console.WriteLine(base.ToString() + TastingNote.noteToCowCheese() + nuance());
        }
    }
}
