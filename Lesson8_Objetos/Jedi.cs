using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos
{
    /// * Crea la clase Jedi.
    /// Atributos: 
    ///           - string name - string lightSaberColor
    /// Constructor:
    ///           - uno con todos los parametros.
    /// Metodos: 
    ///           - Metodo showInfo que muestre el siguiente mensaje por pantalla:
    ///           "Soy un Jedi, mi nombre es NOMBRE y el color de mi sable de luz de COLOR".
    ///           Sustituir NOMBRE y COLOT por los valores de las propiedades de cada jedi.
    ///  Crea los siguientes Jedi:
    ///  Luke Skywalker, azul | Mace Windu, morado | Yoda, verde | Qui-Gon Jinn, verde |
    ///  Obi-Wan Kenobi, azul Y muestra sus datos por pantalla.
    /// 
    /// </summary>
    public class Jedi
    {
        string name;
        string saberColor;
        ConsoleColor color;

        public Jedi(string jediName, string lightSaberColor)
        {
            this.name = jediName;
            this.saberColor = lightSaberColor;
            this.color = paintColorSaber(lightSaberColor);
        }

        public void showInfo ()
        {
            Console.Write($"Soy un Jedi, mi nombre es {this.name} y el color de mi sable de luz de ");
            Console.ForegroundColor = this.color;
            Console.WriteLine($"{this.saberColor}");
            Console.ResetColor();
        }

        private ConsoleColor paintColorSaber(string color)
        {
            switch (color)
            {
                case "azul":
                    return ConsoleColor.Blue;
                    break;
                case "verde":
                    return ConsoleColor.Green;
                    break;
                case "morado":
                    return ConsoleColor.DarkMagenta;
                    break;
                default:
                    return ConsoleColor.White;
            }

        }
    }
}
