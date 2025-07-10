using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;
/// <summary>
/// * Crear la clase AparatoElectrico
/// - Atributos
///  - private int volage
/// - Constructor
///  - Uno con el voltaje
/// - Metodos
///  - Metodo tostring sobrescrito que muestra el voltaje.
///  
/// - Crear la clase tostadora, que hereda de AparatoElectrico
/// - Atributos
///  - int tiempoTostado
///  - bool bandejaExtraible
/// Seleccionar visibilidad adecuada para las propiedades 
/// - Constructor
///  - Uno con todos los parametros, incluido el voltaje
/// - Metodos
///  - Tostar, que saca por pantalla un mensaje "Tostando el pan, 
///  tardará TIMEPOTOSTADO minutos".
///  Si tiene bandeja extraible, tambien aparecerá "Al terminar,
///  puede retirar las migas con la bandeja extraible"
///  
/// Crear dos tostadoras distintas y poner a tostar el pan.
/// 
/// - Crear la clase horno, que hereda de AparatoElectrico
/// - Atributos
///  - string modelo
///  - int potencia
///  - string[] funciones
/// Seleccionar visibilidad adecuada para las propiedades 
/// - Constructor
///  - Uno con todos los parametros, incluido el voltaje
/// - Metodos
///  - Mostrar, que saca por pantalla un mensaje "Este es
///  un horno MODELO con POTENCIA vatios de potencia, VOLTAJE voltios
///  y sus funciones son: FUNCIONES".


public class AparatoElectrico
{
    private int voltage;
    public AparatoElectrico(int voltage)
    {
        this.voltage = voltage;
    }

    public int getVoltage()
    {
        return this.voltage;
    }

    public override string ToString()
    {
        return "El voltaje es" + this.voltage;
    }
}
