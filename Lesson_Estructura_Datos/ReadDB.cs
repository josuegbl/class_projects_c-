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

    private static Film getMovieFromDB(string line)
    {
        string[] movieLine = line.Split(',');

        return new Film(movieLine[0], stringToGenre(movieLine[1].Trim()),
                            int.Parse(movieLine[2].Trim()), getNewly(movieLine[3].Trim()));
    }

    private static bool getNewly(string newlyString)
    {
        return newlyString == "novedad" ? true : false;
    }

    private static Genre stringToGenre(string genreString)
    {
        Genre genre;

        switch (genreString)
        {
            case "Action":
                genre = Genre.ACCION;
                break;

            case "Thriller":
                genre = Genre.THRILLER;
                break;

            case "Fantasy":
                genre = Genre.FANTASTICO;
                break;

            case "Sci-Fi":
                genre = Genre.CIENCIA_FICCION;
                break;

            case "History":
                genre = Genre.HISTORY;
                break;

            case "Comedy":
                genre = Genre.COMEDIA;
                break;

            case "Drama":
                genre = Genre.DRAMA;
                break;

            case "Western":
                genre = Genre.WESTERN;
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

    public static List<Film> getMoviesCatalogue()
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
