using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Movie
{
    string title;
    int rating;
    int duration;
    Genre genre;
    List<Actor> actors;
    Director director;

    public Movie(string title, int rating, int duration, Genre genre, Director director)
    {
        this.title = title;
        this.rating = rating;
        this.duration = duration;
        this.genre = genre;
        this.actors = new List<Actor>();
        this.director = director;
    }

    public Movie(string title, int rating, int duration, Genre genre, List<Actor> actors, Director director)
    {
        this.title = title;
        this.rating = rating;
        this.duration = duration;
        this.genre = genre;
        this.actors = actors;
        this.director = director;
    }

    public void addActor(Actor actor)
    {
        this.actors.Add(actor);
    }

    public void addActorList(List<Actor> actors)
    {
        if (this.actors.Count == 0)
        {
            this.actors = actors;
        }
        else
        {
            foreach(Actor actor in actors)
            {
                this.actors.Add(actor);
            }
        }
    }

    public string getTitle()
    {
        return this.title;
    }

    public int getRating()
    {
        return this.rating;
    }
    public string getMovieGenre()
    {
        return this.genre.ToString();
    }

    public int getDuration()
    {
        return this.duration;
    }

    public List<Actor> GetActors()
    {
        return this.actors;
    }

    public string getMovieInfo()
    {
        string moviInfo = $"Titulo: {this.title}\n" +
                          $"Valoracion: {this.rating}\n" +
                          $"Duracion: {this.duration}\n" +
                          $"Genero: {getMovieGenre()}\n" + 
                          $"Director: {this.director.getInfoDirector()}\n\n" +
                          $"Actores:\n";
        foreach(Actor actor in this.actors)
        {
            moviInfo += actor.getInfoActor();
        }
        return moviInfo;
    }

}
