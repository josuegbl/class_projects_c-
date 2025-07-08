using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

/// <summary>
///  * Crear la clase FanDeporte.
///    - Atributos:
///      - string deporte
///    - Constructor:
///      - uno con el parametro deporte
///    - Metodos: 
///      - Metodo tostring sobreescrito que devuelve el mensaje
///      "soy un fan del DEPORTE"
///    - Seleccionar visibilidad adecuada para la propiedad deporte.
///  
///   - Crear la clase FanF1, que heres de FanDeporte.
///     - Atributos:
///      - string pilotoFavorito.
///     - Constructor:
///      - Uno con los dos parámetros.
///     - Metodos:
///      - Metodo tostring que devuelve el mensaje "So un fan del 
///      deporte DEPORTE y mi piloto favorito es PILOTOFAVORITO"
///   - Seleccionar visibilidad adecuada para la propiedad PilotoFavorito.
///   
///   - Crear la clase FanTenis, que heres de FanDeporte.
///     - Atributos:
///      - string tenistaFavorito.
///     - Constructor:
///      - Uno con los dos parámetros.
///     - Metodos:
///      - Metodo tostring que devuelve el mensaje "So un fan del 
///      deporte DEPORTE y mi tenista favorito es TENISTAFAVORITO"
///   - Seleccionar visibilidad adecuada para la propiedad tenistaFavorito.
///   
///   - Crear 2 fan de la F1 y dos fnas del tenis y mostrar los 4 por pantalla.
/// 
/// </summary>
public class FanDeporte
{
    protected string deporte;

    public FanDeporte(string deporte)
    {
        this.deporte = deporte;
    }

    public override string ToString()
    {
        return "Soy un fan del " + this.deporte;
    }
}
