using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.GOT;
/// <summary>
/// * Vamos a modelar personajes de Juego de Tronos.
/// Necesitaremos una clase base PersojanesJuegodeTronos.
/// Todos los personajes tienen un nombre.
/// Ademas, todos los personajes que vamos a modelar 
/// pertenecen a una casa.
/// Las casas existen al margen de los personajes,
/// o sea que aunque un personaje no existiera, su casa 
/// seguiría existiendo. Cada casa tiene un lema propio.
/// Queremos modelar las siguientes casas:
/// Stark, cuyo lema es "Winter is coming".
/// Lannister, cuyo lema es "A lannister always pays his 
/// debts".
/// Ademas, cada personaje puede presentarse , diciendo su
/// nombre y el lema de la casa a la que pertenece.
/// Queremos ser más especificos y poder crear concretamente
/// personajes de dos casas concretas: Stark y Lannister. No 
/// queremos crear personajes genericos, sino personajes de una
/// casa en concreto. No se crearan personajes de la clase 
/// base, sino de las derivadas.
/// Queremos representar a los siguientes personajes:
///  Ned y Sansa, de la casa Stark.
///  Tyrion y Jaime, de la casa Lannister.
///  
/// Crear en un programa a todos los personajes y hacer que se 
/// presenten.
/// </summary>

public abstract class PersonajesGOT
{
    protected string name;

    public abstract void presentarse();

}
