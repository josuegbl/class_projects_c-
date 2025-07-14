using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Actor : Person
{
    Genre genre;
    public Actor(string name, Genre genre)
        : base(name)
    {
        this.genre = genre;
    }

    private string getActorGenre()
    {
        return this.genre.ToString();
    }

    public string getInfoActor()
    {
        return $"Nombre: {getName()}\n" +
               $"Género: {getActorGenre()}\n";
    }

}
