using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;
/// <summary>
/// **Queremos simular el funcionamiento de un antiguo videoclub.
///  
/// - El videoclub tendrá una serie de pelis disponibles en catalogo.
/// - Cada peli tendrá un nombre, un género, stock disponible para 
/// alquiler y si es novedad o no.
/// 
/// - Las pelis estarán almacenadas en un fichero, que se cargará:
///   - Al iniciar la aplicacion
///   - Cada vez que se añada una peli.
/// 
/// - El sistema mostrará un menú en el que cualquier usuario podrá:
///   - Ver las pelis disponibles para alquilar en un listado.
///   - Alquilar una peli disponible (usando su título; se 
///   almacenarán los alquileres en un fichero usando el título de la
///   peli y el precio.
///   - Devolver una peli alquilada (usando su titulo; se pondrá 
///   disponible una vez devuelta y se borrará el alquiler del fichero 
///   de alquileres)
///   - Identificarse como admin (se pedirá un nombre de usuario y passwd)
///   - Salir.
/// 
/// El sistema contará con usuarios admin, que tendrán un nombre de usuario
/// y passwd, almacenados en un fichero.
/// 
/// - SI el usuario se identifica correctamente como admin, se añadirán
/// además al menú las opciones:
///   - Añadir una peli asociada y un precio.
///   - Ver los alquileres de las pelis.
///   - El precio de 3€ para pelis normales y de 5€ para novedades.
/// 
/// - Si una peli ya está alquilada y no hay stock, no se podrá 
///   alquilar y no se mostrará en el catálogo de disponibles (pero si 
///   en los alquileres).
/// 
/// </summary>

public class VideoClub
{
    private List<Film> movies;
    private Menu menu;

    public VideoClub()
    {
        this.movies = ReadDB.getMoviesCatalogue();
        this.menu = new Menu();
    }

    public void Main()
    {
        bool goOut = false;
        do
        {
            this.menu.printMenu();
            goOut = getSelection();

        } while (!goOut);
    }

    public bool getSelection()
    {
        bool goOut = false;
        switch (this.menu.getOption())
        {
            case 0:
                getMovieList();
                break;
            case 1:
                rentMovie();
                break;
            case 2:
                returnMovie();
                break;
            case 3:
                adminOptions();
                break;
            case 4:
                goOut = true;
                break;
        }
        return goOut;
    }

    public void getSelectionAdminOptions()
    {
        switch (this.menu.getOption())
        {
            case 0:
                addMovie();
                break;
            case 1:
                getRentedMovies();
                break;
        }
    }

    public void getMovieList()
    {
        this.menu.getHeaderMovieList("LISTA DE PELICULAS DISPONIBLES");

        int count = 0;

        foreach (Film movie in this.GetFilmsByAvailability())
        {
            count++;
            menu.printList($"{count}  ->  " + movie.ToString());
        }
        this.menu.getTailMovieList();
    }

    public void rentMovie()
    {
        menu.rentMovieMenu();

        List<Film> movies = this.GetFilmsByAvailability();
        string name = Console.ReadLine().ToUpper();

        bool rentOK = false;

        foreach (Film movie in movies)
        {
            if (name == movie.getTitle().ToUpper())
            {
                WriteDB.writeRentedMovieToDB(movie);
                movie.decreaseStock();
                WriteDB.writeUpdatedMovieDB(movie);
                rentOK = true;
                break;
            }
        }
        menu.rentMovieMenuSuccess(rentOK);
    }

    public void returnMovie()
    {
        menu.returnMovieMenu();
        string name = Console.ReadLine().ToUpper();
        bool returnOK = false;


        foreach (Film movie in getFilms())
        {
            if (name == movie.getTitle().ToUpper())
            {
                WriteDB.removeMovieFromRentDB(movie);
                movie.increaseStock();
                WriteDB.writeUpdatedMovieDB(movie);
                returnOK = true;
                break;
            }
        }

        menu.returnMovieMenuSuccess(returnOK);
    }

    public void adminOptions()
    {
        string[] credentials = menu.menuAdminAuth();

        User user = new User();
        user.adminPasswdCheck(credentials[0], credentials[1]);

        if (user.getIsAdmin())
        {
            menu.adminMenu();
            getSelectionAdminOptions();
        }
    }

    public void addMovie()
    {
        string[] movieString;

        movieString = menu.addMovieMenu();

        Genre genre = ReadDB.stringToGenre(movieString[1]);

        Film newMovie = new Film(movieString[0], genre, int.Parse(movieString[2]), bool.Parse(movieString[3]));
        addFilm(newMovie);

        WriteDB.writeMovieListToDB(this.movies);

    }

    public void getRentedMovies()
    {
        List<Film> rentedMovies = ReadDB.getRentedMovies();

        this.menu.getHeaderMovieList("LISTA DE PELICULAS RENTADAS");

        int count = 0;

        foreach (Film movie in rentedMovies)
        {
            count++;
            menu.printList($"{count}  ->  " + movie.ToString());
        }
        this.menu.getTailMovieList();
    }

    public List<Film> getFilms()
        { return this.movies; }

    public void addFilm(Film film)
    {
        this.movies.Add(film);
    }

    public static Film GetFilmByName(List<Film> movies, string name)
    {
        Film movie = Film.getDefaultFilm();

        foreach (Film film in movies)
        {
            if (film.getTitle() == name)
            {
                movie = film;
            }
        }

        return movie;
    }

    public List<Film> GetFilmsByAvailability()
    {
        List<Film> availMovies = new List<Film>();
        
        foreach (Film movie in this.movies)
        {
            if(movie.isAvailable())
            {
                availMovies.Add(movie);
            }
        }

        return availMovies;
    }

}
