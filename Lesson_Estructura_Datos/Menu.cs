using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Menu
{
    private ConsolePosition position;

    public Menu()
    {
        this.position = new ConsolePosition();
    }
    public void printMenu()
    {
        getMenu();
        selector();
    }

    public void getSelection(VideoClub club)
    {
        int option = this.position.getPosition()[1] 
                   - ConsolePosition.defaultConsolePosition().getPosition()[1] - 2;

        switch (option)
        {
            case 0:
                getMovieList(club);
                break;
            case 1:
                rentMovie(club);
                break;
            case 2:
                returnMovie();
                break;
            case 3:
                adminMenu();
                break;

        }
    }

    private void getMenu()
    {
        Console.Clear();

        this.position = new ConsolePosition();
        this.position.setCursorPosition();
        Console.Write("MENU VIDEOCLUB Blockbuster");

        this.position.shiftPosition(0, 2);
        this.position.setCursorPosition();
        Console.Write("Peliculas disponibles");

        this.position.shiftPosition(0, 1);
        this.position.setCursorPosition();
        Console.Write("Alquilar Películas");

        this.position.shiftPosition(0, 1);
        this.position.setCursorPosition();
        Console.Write("Devolver Película");

        this.position.shiftPosition(0, 1);
        this.position.setCursorPosition();
        Console.Write("ADMIN MENU (autenticacion)");
    }
    
    public void getMovieList(VideoClub club)
    {
        List<Film> movies = club.GetFilmsByAvailability();

        Console.Clear();
        ConsolePosition position = new ConsolePosition();
        position.setCursorPosition();
        Console.Write("LISTA DE PELICULAS DISPONIBLES");
        position.shiftPosition(-20, 0);
        int count = 0;

        foreach (Film movie in movies)
        {
            position.shiftPosition(0, 1);
            position.setCursorPosition();
            count++;
            Console.WriteLine($"{count}  ->  " + movie);
        }
        position.shiftPosition(0, 2);
        position.setCursorPosition();
        Console.Write("PULSE CUALQUIER TECLA PARA EL MENU");
        Console.ReadKey();
    }

    public void rentMovie(VideoClub club)
    {
        List<Film> movies = club.GetFilmsByAvailability();
        Console.Clear();
        ConsolePosition position = new ConsolePosition();

        position.setCursorPosition();
        Console.WriteLine("Escriba el Nombre de la Pelicula para alquilar ");

        position.shiftPosition(0, 2);
        position.setCursorPosition();
        string name = Console.ReadLine().ToUpper();
        
        foreach (Film movie in movies)
        {
            if (name == movie.getTitle().ToUpper())
            {
                WriteDB.writeRentedMovieToDB(movie);
                movie.decreaseStock();
                WriteDB.writeUpdatedMovieDB(movie);
                
                position.shiftPosition(0, 2);
                position.setCursorPosition();
                Console.WriteLine($"Disfrute su película {movie.getTitle()}");
                Thread.Sleep(2000);
                break;
            }
        }
        

    }

    public void returnMovie(VideoClub club)
    {
        List<Film> movies = club.getFilms();
        Console.Clear();
        ConsolePosition position = new ConsolePosition();

        position.setCursorPosition();
        Console.WriteLine("Escriba el Nombre de la Pelicula a devolver");

        position.shiftPosition(0, 2);
        position.setCursorPosition();
        string name = Console.ReadLine().ToUpper();

        foreach (Film movie in movies)
        {
            if (name == movie.getTitle().ToUpper())
            {
                WriteDB.writeRentedMovieToDB(movie);
                movie.decreaseStock();
                WriteDB.writeUpdatedMovieDB(movie);

                position.shiftPosition(0, 2);
                position.setCursorPosition();
                Console.WriteLine($"Disfrute su película {movie.getTitle()}");
                Thread.Sleep(2000);
                break;
            }

        }

    public void adminMenu()
    {
    }

    public void selector()
    {
        ConsolePosition defaultObjPos = ConsolePosition.defaultConsolePosition();

        int[] defaultPosition = defaultObjPos.getPosition();
        int top = defaultPosition[1];

        this.position = defaultObjPos;
        this.position.shiftPosition(-2, 2);
        this.position.setCursorPosition();
        
        Console.Write("█");

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (this.position.getPosition()[1] > defaultPosition[1] + 2)
                {
                    this.position.setCursorPosition();
                    Console.Write(" ");
                    this.position.shiftPosition(0, -1);
                }
                this.position.setCursorPosition();
                Console.Write("█");

            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (this.position.getPosition()[1] < defaultPosition[1] + 5)
                {
                    this.position.setCursorPosition();
                    Console.Write(" ");
                    this.position.shiftPosition(0, 1);
                }
                this.position.setCursorPosition();
                Console.Write("█");
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                break;
            }
        } while (!Console.KeyAvailable);
    }
}
