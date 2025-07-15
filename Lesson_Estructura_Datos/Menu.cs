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
        this.position.setCursorPosition();
        Console.Write("MENU VIDEOCLUB Blockbuster");
        getMovieList();
        rentMovie();
        returnMovie();
        adminMenu();
        selector();
        Console.ReadKey();

    }

    public void getMovieList()
    {
        this.position.shiftPosition(0, 2);
        this.position.setCursorPosition();
        Console.Write("Peliculas disponibles");
    }

    public void rentMovie()
    {
        this.position.shiftPosition(0, 1);
        this.position.setCursorPosition();
        Console.Write("Alquilar Películas");
    }

    public void returnMovie()
    {
        this.position.shiftPosition(0, 1);
        this.position.setCursorPosition();
        Console.Write("Devolver Película");
    }

    public void adminMenu()
    {
        this.position.shiftPosition(0, 1);
        this.position.setCursorPosition();
        Console.Write("ADMIN MENU (autenticacion)");
    }

    public void selector()
    {
        this.position.defaultPosition();
        int[] defaultPosition = this.position.getPosition();
        int top = defaultPosition[1];
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
