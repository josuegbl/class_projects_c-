using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Director : Person
{
    int directedFilms;

    public Director(string name, int directedFilms)
        : base(name)
    {
        this.directedFilms = directedFilms;
    }
    
    private int getDirectedFilms()
    {
        return this.directedFilms;
    }

    public string getInfoDirector()
    {
        return $"Nombre: {getName()}\n" +
               $"Peliculas Dirigidas: {getDirectedFilms()}"; 
    }
}
