using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos
{

    public static class TastingSheep
    {
        public static string nuance(string race)
        {
            string text;

            switch (race)
            {
                case "churras":
                    text = "Matiz: raza Churras";
                    break;

                case "merinas":
                    text = "Matiz: raza Merinas";
                    break;
                default:
                    text = "Matiz: raza Merinas";
                    break;


            }
            return text;
        }

    }
}
