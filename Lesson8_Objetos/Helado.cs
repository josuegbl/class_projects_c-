using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

/// <summary>
/// * Crear la clase Helado.
/// Atributos:
///    - string sabor
///  Constructor:
///    - Uno con el sabor
///    
/// - Seleccionar el tipo de acceso apropiado para el atributo sabor, teniendo
/// en cuanta que no usaremos un getter desde las clases derivadas para acceder
/// al sabor de cada helado
/// - Crear las clases Frigopie, SanwichNada y Calipo, que hereden de 
/// Helado
/// - Las tres tienen un constructor con el parametro sabor, que reutiliza el
/// constructor de la clase padre.
/// - Cada helado sobreescribirá el metodo tostring y devolverá el mensaje:
/// "Soy un NOMBREHELADO de SABOR".
/// 
/// </summary>

public class Helado
{
    protected string sabor;

    public Helado(string sabor)
    {
        this.sabor = sabor;
    }

}
