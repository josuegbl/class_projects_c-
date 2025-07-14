using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;
/// <summary>
///  ** Queremos hacer un catalogador de películas
///  - Cada peli tiene: titulo, valoracion del 1 al 10
///  (entera), genero, duración (entera, en minutos)
///  - Ademas cada peli tendrá un director y uno o varios
///  actores que participen
///  - Cada director tendrá un nombre completo y un numero de
///  pelis dirigidas.
///  - Cada actor tendrá un nombre completo y un genero en el que
///  destaque
///  - Los generos posibles tanto de las pelis como destacados 
///  en los actores serán los mismos (pensar como "compartirlos")
///  - El catalogador contendrá una coleccion de pelis, que empezará 
///  vacía, a la que se podrán ir añadiendo pelis.
/// - Podrá mostrar la info de una peli pedida por parametro 
///  (mostrando la peli, a su vez, la informacion de 
///  su director y actores.)
///  - Permitirá obtener una lista de las pelis con una valoracion igual
///  o superior a la indicada por parámetro.
/// - Permitirá obtener una lista con las pelis en las que participa un
///  actor determinado, indicado por su nombre.
/// 
/// - Permitirá obtener un resumen estadístico, que luego podrá ser
///  mostrado por consola, con la siguiente información:
///     - Pelicula de mayor duración
///     - Pelicula de menor duracion
///     - Media aritmetica de duracion de las peliculas en el catálogo
/// </summary>
public class Catalogue
{
    Dictionary<string, Movie> movies;

    public Catalogue()
    {
        this.movies = new Dictionary<string, Movie>();
    }

    public void addmovie(Movie movie)
    {
        this.movies.Add(movie.getTitle(), movie);
    }

    private Dictionary<string, Movie> getMovies()
    {
        return this.movies;
    }

    public void getMovieInfo(string movieTitle)
    {
        Movie movie = getMovies()[movieTitle];
        Console.WriteLine(movie.getMovieInfo()); 
    }

    private List<Movie> GetMoviesList()
    {
        List<Movie> movies = new List<Movie>();

        foreach (KeyValuePair<string, Movie> item in this.getMovies())
        {
             movies.Add(item.Value);
        }
        return movies;
    }

    public List<Movie> getMoviesByRating(int rating)
    {
        List<Movie> movies = new List<Movie>();

        foreach(KeyValuePair<string, Movie> item in this.getMovies())
        {
            if (item.Value.getRating() >= rating)
            {
                movies.Add(item.Value);
            }
        }
        return movies;
    }

    public List<Movie> getMoviesByActorName(string actorName)
    {
        List<Movie> movies = new List<Movie>();

        foreach (KeyValuePair<string, Movie> item in this.getMovies())
        {
            foreach(Actor actor in item.Value.GetActors())
            {
                if (actor.getName() == actorName)
                {
                    movies.Add(item.Value);
                    break;
                }
            }
        }
        return movies;
    }

    public string getCatalogueStats()
    {
        List<Movie> movies = GetMoviesList();
        List<int> duration = new List<int>();
        int sumDuration = 0;

        foreach(Movie movie in movies)
        {
            sumDuration += movie.getDuration();
            duration.Add(movie.getDuration());
        }

        Movie longestMovie = movies[duration.IndexOf(duration.Max())];
        Movie shortestMovie = movies[duration.IndexOf(duration.Min())];
        
        int average = sumDuration / movies.Count;

        string resume = "Longest movie:\n" + longestMovie.getMovieInfo() + "\n\n" +
                        "Shortest movie:\n" + shortestMovie.getMovieInfo() + "\n\n" +
                        "Average movie duration: " + average.ToString();

        return resume;
    }
}
