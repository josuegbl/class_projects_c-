using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class DBhandling
{
    const string RENT_FILE = "moviesRented.txt";
    const string ADMIN_FILE = "adminFile.txt";
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

    private static List<Film> getMoviesFromDB(bool isMoviesRentedFile)
    {
        List<Film> movies = new List<Film>();
        string readFile;

        if (isMoviesRentedFile)
        {
            readFile = RENT_FILE;
        }
        else
        {
            readFile = MOVIES_FILE;
        }

        string[] moviesList = File.ReadAllLines(readFile);
        foreach(string line in moviesList)
        {
            movies.Add(getMovieFromDB(line));
        }

        return movies;
    }

    public List<Film> getRentedMovies()
    {
        return getMoviesFromDB(true);
    }

    public List<Film> getMoviesCatalogue()
    {
        return getMoviesFromDB(false);
    }



}
