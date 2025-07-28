using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.Embutidos;
/// <summary>
///  Crear la clase abstracta embutido
///    Atributos: 
///      string ingredientes.
///    Metodos:
///     Metodo preparar que muestra por pantalla como se prepara el 
///     embutido, sin implementacion.
///    Crear los embutidos: salchichon, chorizo y lomo,
///    añadirle los ingredientes al construirlo y que cada
///    uno tenga su propia preparacion.
///    Crear un embutido de cada y mostrar la preparación.
/// </summary>
 public abstract class Embutido
{
    protected string ingredientes;

    public abstract void preparar();

}
