using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class ReadDB
{
    const string RENT_FILE = "moviesRented.txt";
    const string MOVIES_FILE = "moviesList.txt" ;

    public static void addMovieToDB(Film movie)
    {

    }

    private static Film getMovieFromDB(string line)
    {
        string[] movieLine = line.Split(',');

        return new Film(movieLine[0], stringToGenre(movieLine[1]),
                            int.Parse(movieLine[2]), bool.Parse(movieLine[3]));
    }

    private string genreToString(Genre genre)
    {
        return genre.ToString();

    }

    private static Genre stringToGenre(string genreString)
    {
        Genre genre;

        switch (genreString.ToUpper())
        {
            case "ACCION":
                genre = Genre.ACCION;
                break;
            case "THRILLER":
                genre = Genre.THRILLER;
                break;
            case "FANTASTICO":
                genre = Genre.FANTASTICO;
                break;
            case "CIENCIA_FICCION":
                genre = Genre.CIENCIA_FICCION;
                break;
            case "BELICO":
                genre = Genre.BELICO;
                break;
            case "COMEDIA":
                genre = Genre.COMEDIA;
                break;
            case "DRAMA":
                genre = Genre.DRAMA;
                break;
            default:
                genre = Genre.ACCION;
                break;
        }
        return genre;
    }

    public List<Film> getRentedMovies()
    {
        List<Film> movies = new List<Film>();

        string[] moviesList = File.ReadAllLines(RENT_FILE);
        foreach (string line in moviesList)
        {
            string[] movieLine = line.Split(',');

            Film film = VideoClub.GetFilmByName(getMoviesCatalogue(), movieLine[0]);

            movies.Add(film);
        }

        return movies;
    }

    public List<Film> getMoviesCatalogue()
    {
        List<Film> movies = new List<Film>();

        string[] moviesList = File.ReadAllLines(MOVIES_FILE);
        foreach (string line in moviesList)
        {
            movies.Add(getMovieFromDB(line));
        }
        return movies;
    }



}
