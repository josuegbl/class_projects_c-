using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_Files;

public class Ejemplo_ficheros_CRUD
{
    public static void Main(string[] args)
    {
        Console.WriteLine("en Ejemplo_ficheros_CRUD");
        string option;
        do
        {
            Console.Clear();
            Console.WriteLine("\n Bienvenidos al sistema de gestión de usuarios\n");
            Console.WriteLine("Tareas Disponibles");
            Console.WriteLine("1. Listado de usuarios");
            Console.WriteLine("2. Crear un usuarios");
            Console.WriteLine("3. Modificar un usuarios");
            Console.WriteLine("4. Borrar un usuarios");
            Console.WriteLine("0. Salir del sistema");

            Console.WriteLine("\n Introduzca la opcion deseada: ");

            option = Console.ReadLine();

        switch (option)
        {
            case "1":
                Ejemplo_ficheros_CRUD.listUsers();
            break;
            case "2":
                Ejemplo_ficheros_CRUD.createUser();
            break;
            case "3":
                Ejemplo_ficheros_CRUD.modifyUser();
            break;
            case "4":
                Ejemplo_ficheros_CRUD.deleteUser();
            break;
        }

        } while (option != "0");


    }

    private static void listUsers()
    {
        Console.WriteLine("listUsers");

        Console.Clear();

        string[] users = File.ReadAllLines("EjemploFicherosCRUDDATA.txt");

        foreach (string user in users)
        {
            Console.WriteLine(user);
        }
        Console.WriteLine("\n Pulse cualquier tecla para continuar");

        Console.ReadLine();
    }

    private static void createUser()
    {
        Console.WriteLine("createUser()");

        Console.Clear();
        Console.Write("Introduzca el nombre de nuevo usuario: ");

        string name = Console.ReadLine();

        string[] users = File.ReadAllLines("EjemploFicherosCRUDDATA.txt");
        string[] result = new string[users.Length + 1];
        users.CopyTo(result, 0);

        result[result.Length - 1] = name;

        File.WriteAllLines("EjemploFicherosCRUDDATA.txt", result);

    }

    private static void modifyUser()
    {
        Console.WriteLine("modifyUser");
        Console.Write("Introduzca el nombre del usuario a modificar: ");

        string name = Console.ReadLine();

        string[] users = File.ReadAllLines("EjemploFicherosCRUDDATA.txt");

        int userIndex = -1;
        
        for (int i = 0; i < users.Length; i++)
        {
            if (name == users[i])
            {
                userIndex = i;
                break;
            }
        }

        if (userIndex == -1)
        {
            Console.WriteLine("Usuario no encontrado en el sistema");
            Console.WriteLine("\n Pulse cualquier tecla para continuar");
            Console.ReadLine();
            
            return;
        }

        Console.WriteLine("Usuario encontrado en el sistema.");
        Console.WriteLine("Introduzca el nombre del usuario modificado: ");

        string newName = Console.ReadLine();

        users[userIndex] = newName;

        File.WriteAllLines("EjemploFicherosCRUDDATA.txt", users);

    }

    private static void deleteUser()
    {
        Console.WriteLine("deleteUser");
        Console.Write("Introduzca el nombre del usuario a borrar: ");

        string name = Console.ReadLine();

        string[] users = File.ReadAllLines("EjemploFicherosCRUDDATA.txt");

        int userIndex = -1;

        for (int i = 0; i < users.Length; i++)
        {
            if (name == users[i])
            {
                userIndex = i;
                break;
            }
        }

        if (userIndex == -1)
        {
            Console.WriteLine("Usuario no encontrado en el sistema");
            Console.WriteLine("\n Pulse cualquier tecla para continuar");
            Console.ReadLine();

            return;
        }

        Console.WriteLine("Usuario encontrado en el sistema.");

        string[] newUserArray = new string[users.Length - 1];

        for (int i = 0; i < newUserArray.Length; i++)
        {
            if (userIndex == i)
            {
                newUserArray[i] = users[i + 1];
                i++;
            }
            else
            {
                newUserArray[i] = users[i];
            }
        }
        File.WriteAllLines("EjemploFicherosCRUDDATA.txt", newUserArray);
        Console.WriteLine("\n Pulse cualquier tecla para continuar");
        Console.ReadLine();
    }

}
