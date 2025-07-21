using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class WriteDB
{
    const string RENT_FILE = "moviesRented.txt";
    const string MOVIES_FILE = "moviesList.txt" ;

    private static void addMovieToDB(string filename, string movieString)
    {
        File.AppendAllLines(filename, [movieString]);
    }

    public static void writeRentedMovieToDB(Film movie)
    {
        string price = movie.getIsNewly() ? "5" : "3";
        string movieRentString = movie.getTitle() + ", " + price;
        addMovieToDB(RENT_FILE, movieRentString);
    }

    public static string writeMovieString(Film movie)
    {
        string movieFileString = movie.getTitle() + ", " + genreToString(movie.getGenre()) +
                                 ", " + movie.getStock() + ", " + getNewly(movie.getIsNewly());
        return movieFileString;
    }

    public static void removeMovieFromRentDB(Film movie)
    {
        removeMovie(RENT_FILE, movie);
    }

    private static void removeMovie(string filename, Film movie)
    {
        int index = -1;
        bool isRepeated = false;
        string[] moviesList = File.ReadAllLines(filename);
        string[] newMoviesList = new string[moviesList.Length - 1];
        
        foreach (string line in moviesList)
        {
            if (!isRepeated)
            {
                string[] movieLine = line.Split(',');
                if (movieLine[0] != movie.getTitle())
                {
                    index++;
                    newMoviesList[index] = line;
                }
                else
                {
                    isRepeated = true;
                }
            }
            else
            {
                index++;
                newMoviesList[index] = line;
            }

        }
        File.WriteAllLines(filename, newMoviesList);
    }

    public static void writeUpdatedMovieDB(Film movie)
    {
        int index = -1;
        string[] moviesList = File.ReadAllLines(MOVIES_FILE);
        string[] newMoviesList = new string[moviesList.Length];

        foreach (string line in moviesList)
        {
            index++;
            string[] movieLine = line.Split(',');
            if (movieLine[0] != movie.getTitle())
            {
                newMoviesList[index] = line;
            }
            else
            {
                newMoviesList[index] = writeMovieString(movie);
            }
        }
        File.WriteAllLines(MOVIES_FILE, newMoviesList);
    }

    private static string getNewly(bool isNewly)
    {
        return isNewly ? "novedad" : " ";
    }

    private static string genreToString(Genre genre)
    {
        string genreString;
        
        switch (genre)
        {
            case Genre.ACCION:
                genreString = "Action";
                break;

            case Genre.THRILLER:
                genreString = "Thriller";
                break;

            case Genre.FANTASTICO:
                genreString = "Fantasy";
                break;

            case Genre.CIENCIA_FICCION:
                genreString = "Sci-Fi";
                break;

            case Genre.HISTORY:
                genreString = "History";
                break;

            case Genre.COMEDIA:
                genreString = "Comedy";
                break;

            case Genre.DRAMA:
                genreString = "Drama";
                break;

            case Genre.WESTERN:
                genreString = "Western";
                break;

            default:
                genreString = "Action";
                break;
        }
        return genreString;
    }

}
