using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

/// <summary>
///  * Vamos a modelar el juego de los Monstruomones,
///  - Un monstruomon tendrá un nombre, un tipo, una cantidad entera
///  de vida, una cantidad entera de fuerza, una cantidad entera de
///  defensa y un conjunto de ataques, que serán también de un tipo.
///  Además podrá atacar.
///  - Cada tipo de monstruomon tiene un tipo contra el que es fuerte
///  y otro contra el que es débil. Será neutral para el resto de 
///  tipos. El tipo neutral es neutral para todos los tipos.
///  - Un monstruomon de un tipo determinado siempre será 
///  fuerte/debil contra el mismo tipo.
///  - Los ataques podrán ser usados por varios monstruomones 
///  diferentes y tendrán un nombre, un daño y un tipo.
///  - Los tipos, de monstruomones y ataques, posibles son: agua,
///  fuego, rayo, tierra y neutral.
///  - Los ataques neutrales quitarán tanta vida como fuerza tenga el 
///  Monstruomon que ataque y daño que haga el ataque, menos la defensa
///  del Monstruomon que reciba el ataque.
///  - Los ataques de un tipo no neutral, afectarán de forma
///  distinta;
///     - Tendrán un daño base correspondiente a la fuerza del
///     Monstruomon mas el daño del ataque.
///     - Si el tipo del ataque es neutral contra el defensor, hará el daño base.
///     - Si el tipo del ataque es fuerte contra el defensor, hará el doble 
///     del daño base.
///     - Si el tipo del ataque es debil contra el defensor, hará la mitad 
///     del daño base.
///     - Al daño se le restará la defensa del Monstruomon, lo que
///     dará el daño final.
///  - Los monstruomnoes podrán combatir.
///  - Un combate tiene dos Monstruomones participantes y un
///  resultado (quien gana/pierde)
///  - La aplicacion se iniciará y mostrará un menú principal en el
///  que el jugador podrá elegir que monstruomon usa para el combate
///  y contra cual combate.
///  - El combate se hará por turnos:
///    - Empezará siempre el jugador.
///    - El jugador podrá elegir un ataque de los disponibles de su 
///    Monstruomon.
///    - La PC elegirá un ataque al azar.
///    - Se irán alternando los turnos hasta que un Monstruomon se quede 
///    sin vida, perdiendo el combate.
///  EXTRA: Hacer que en los combates puedan participar varios Monstruomones,
///  pudiendo cambiarlos durante el combate.
///  EXTRA: Guardar/cargar los Monstruomones desde un fichero.
///  EXTRA: Crear MonstruomonMastros, con atributos (fuerza, defensa...) 
///  que modifiquen los de sus Monstruomones.
///  EXTRA: Algunos ataques tendrán un número de veces máxima que se podrán usar
///  en un combate; el resto, se podrán usar todas las veces que se quiera.
///  EXTRA: Algunos Monstruomones podrán defenderse, siendo una 
///  opcion más en el combate. Duplicarán su defensa en ese turno, 
///  pero no podrán atacar.
///  EXTRA: Guardar los resultados de cada combate en un fichero y poder consultarlo.
///  EXTRA: Guardar cada turno de cada combate en un fichero y
///  sacar estats (total combates, total turnos, combate con más turnos,
///  daño total, ataque más usado, mayor daño en un ataque....)
/// </summary>
public class VGMonstruoMon
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();

        menu.printMenu();

        

    }
}
