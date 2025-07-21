using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Menu
{
    private ConsolePosition position;
    private int option;

    public Menu()
    {
        this.position = new ConsolePosition();
        this.option = 0;
    }

    public int getOption()
    {
        return this.option;
    }
    public void printMenu()
    {
        getMenu();
        selector(5);
    }

    private void getMenu()
    {
        Console.Clear();

        this.position = ConsolePosition.defaultConsolePosition();
        Console.Write("MENU VIDEOCLUB Blockbuster");

        this.position.shiftPosition(0, 2);
        Console.Write("Peliculas disponibles");

        this.position.shiftPosition(0, 1);
        Console.Write("Alquilar Películas");

        this.position.shiftPosition(0, 1);
        Console.Write("Devolver Película");

        this.position.shiftPosition(0, 1);
        Console.Write("ADMIN MENU (autenticacion)");
    }

    public void getHeaderMovieList(string message)
    {
        Console.Clear();
        this.position = new ConsolePosition();
        this.position.setCursorPosition();
        Console.Write(message);
        this.position.shiftPosition(-15, 2);

    }

    public void printList(string moviePrint)
    {
        position.shiftPosition(0, 1);
        Console.Write(moviePrint);
    }

    public void getTailMovieList()
    {
        position.shiftPosition(0, 2);
        Console.Write("PULSE CUALQUIER TECLA PARA EL MENU");
        Console.ReadKey();
    }

    public void rentMovieMenu()
    {
        Console.Clear();
        ConsolePosition position = new ConsolePosition();

        position.setCursorPosition();
        Console.WriteLine("Escriba el Nombre de la Pelicula para alquilar ");

        position.shiftPosition(0, 2);
        position.setCursorPosition();
    }

    public void rentMovieMenuSuccess(bool isSuccess)
    {
        position.shiftPosition(0, 2);
        position.setCursorPosition();

        if (isSuccess)
        {
            Console.WriteLine("Disfrute su película");
        }
        else
        {
            Console.WriteLine("Lo sentimos, no hemos encontrado su película.");
        }
        Thread.Sleep(2000);
    }

    public void returnMovieMenu()
    {
        Console.Clear();
        ConsolePosition position = new ConsolePosition();
        Console.WriteLine("Escriba el Nombre de la Pelicula a devolver");
        position.shiftPosition(0, 2);
    }

    public void returnMovieMenuSuccess(bool isSuccess)
    {
        position.shiftPosition(0, 2);

        if (isSuccess)
        {
            Console.WriteLine("Gracias por devolver la película");
        }
        else
        {
            Console.WriteLine("Lo sentimos, esa peli no la tenemos en nuestras bases como alquilada.");
        }
        Thread.Sleep(2000);
    }

    public void adminMenu()
    {
        Console.Clear();

        this.position = new ConsolePosition();
        Console.Write("MENU ADMINISTRADOR");

        this.position.shiftPosition(0, 2);
        Console.Write("Añadir Película");

        this.position.shiftPosition(0, 1);
        Console.Write("Ver películas alquiladas");

        selector(3);

    }

    public string[] menuAdminAuth()
    {
        Console.Clear();
        this.position.shiftPosition(0, 0);
        Console.WriteLine("Necesita autenticación");
        this.position.shiftPosition(0, 2);
        Console.Write("Usuario: ");
        string name = Console.ReadLine();

        Console.Clear();
        this.position.shiftPosition(0, -2);
        Console.WriteLine("Necesita autenticación");
        this.position.shiftPosition(0, 2);
        Console.Write("password: ");
        string passwd = Console.ReadLine();

        return [name, passwd];

    }

    public void selector(int maxTop)
    {
        ConsolePosition defaultObjPos = ConsolePosition.defaultConsolePosition();

        int top = defaultObjPos.getPosition()[1];

        this.position = defaultObjPos;
        this.position.shiftPosition(-2, 2);
        
        Console.Write("█");

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (this.position.getPosition()[1] > top + 2)
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
                if (this.position.getPosition()[1] < top + maxTop)
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
        this.option = this.position.getPosition()[1] - top - 2;
    }
}
