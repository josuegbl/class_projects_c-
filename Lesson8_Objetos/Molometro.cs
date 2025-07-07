using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;


/// <summary>
/// * Crear la clase Molometro
/// Atributos:
///   - int contadorMolines
/// Constructor:
///   - uno sin parametros, inicializa por defecto el contador Molines a 0
/// Metodos:
///   - Metodo "mola", no devuelve nada e incrementa el contrador de molines.
///   - Metodo "noMola", no devuelve nada y que decrementa el contador de molines.
///   - Metodo "molaONoMola" que devuelve una cadena de texto tal que:
///            - S1 el contador de molines es mayor que 0, "Moooola!"
///            - S1 el contador de molines es menor que 0, "no mola"
///            - S1 el contador de molines es igual que 0, "Ni fu ni fa"
/// </summary>

public class Molometro
{
    int contadorMolines;

    public Molometro()
    {
        this.contadorMolines = 0;
    }

    public void mola()
    {
        this.contadorMolines++;
    }

    public void noMola()
    {
        this.contadorMolines--;
    }

    public string molaONoMola()
    {
        string molaNoMola;

        if (this.contadorMolines > 0)
        {
            molaNoMola = "Mooola!";
        }
        else if (this.contadorMolines == 0)
        {
            molaNoMola = "Ni fu ni fa";
        }
        else
        {
            molaNoMola = "no mola";
        }

        return molaNoMola;
    }
}
