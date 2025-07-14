using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Film
{
    private string title;
    private Genre genre;
    private int stock;
    private bool isNewly;

    public Film(string name, Genre genre, int stock, bool isNewly)
    {
        this.title = name;
        this.genre = genre;
        this.stock = stock;
        this.isNewly = isNewly;
    }
    
    public Genre getGenre()
    {
        return this.genre;
    }

    public string getTitle()
    {
        return this.title;
    }

    public int getStock()
    {
        return this.stock;
    }

    public bool getIsNewly()
    {
        return this.isNewly;
    }

}
