using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_Files;

public class Lesson_07_Files_03
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Escriba una palabra de la que quiera su definición: ");
        //string word = Console.ReadLine();
        //Console.WriteLine(Lesson_07_Files_03.getDefinition(word));
        //Console.WriteLine("Teclee cualquier letra para salir");
        //Console.ReadLine();

        //Console.WriteLine("Escriba el nombre del trabajador: ");
        //string worker = Console.ReadLine();

        //string[] workedDays = Lesson_07_Files_03.getWorkedDays(worker);
        //Console.WriteLine("Días trabajados: ");
        //foreach (string day in workedDays)
        //{
        //    Console.WriteLine(day);
        //}
        //Console.WriteLine("Teclee cualquier letra para salir");
        //Console.ReadLine();
        //moveCursorFromFile();
        tasksLoading();

    }
    /// ** Realizar los siguientes ejercicios de lectura de ficheros.
    /// . Para cada ejercicio habrá que generar, al menos, una función
    /// específica para alojar el código, que será llamada desde el Main.
    ///. Seleccionar los parametros de entrada/salida necesarios para
    ///la funcionalidad propuestas.
    ///. Generar los ficheros de entrada/salida necesarios para hacer 
    ///las pruebas.

    /// * Crear una funcion a la que se le pase una palabra como
    /// parametro y devuelva su definicion.
    /// - El programa sacará los datos de un fichero que contendrá, en 
    /// una cadena, la palabra y su descripcion
    /// - "Separar" las palabras y las descripciones por algún
    /// delimitador, para distinguir una de otra.
    /// - Si no se encuentra la palabra, indicarlo por consola.
    /// NOTA: Consultar la función "Split" de string.

    public static string getDefinition(string word)
    {
        string[] definitions = File.ReadAllLines("fileDefinitions.txt");
        string meaning = "";
        bool wordDefined = false;

        foreach(string definition in definitions)
        {
            string[] wordDefinition = definition.Split(":");

            if (wordDefinition[0].ToLower() == word.ToLower())
            {
                meaning = wordDefinition[1];
                wordDefined = true;

                break;
            }
            
        }
        if (!wordDefined)
            meaning = "La palabra " + word + " no está en el diccionario";
        return meaning;

    }

    /// * Crear una funcion que reciba un string como parametro y devuelva un
    /// array de string
    /// - Leerá de un fichero en el que, en cada linea, habrá un nombre y una 
    /// lista de días de la semana, que se corresponderán con los que trabaja
    /// la persona.
    /// - La  funcion buscará el nombre en el listado y devolverá los días de la 
    /// semana que trabaja la persona en el array reslutado
    /// - Si no se encuentra el nombre de la persona, se indicará por consola y 
    /// se devolverá un array vacío.
    /// NOTA: No hace falta controlar "grano fino" el tamaño del array de
    /// retorno (puede contener espacios no usados.)
    public static string[] getWorkedDays(string workerName)
    {
        string[] allNamesInfo = File.ReadAllLines("fileNameWorkedDays.txt");
        string[] workedDays = new string[5];
        bool nameFound = false;

        foreach (string nameInfo in allNamesInfo)
        {
            string[] namesAndWorkedDays = nameInfo.Split(":");

            if (namesAndWorkedDays[0] == workerName)
            {
                workedDays = namesAndWorkedDays[1].Split(",");
                nameFound = true;
                break;
            }

        }
        if (!nameFound) Console.WriteLine("{0} no se encuentra en nuestra base de datos", workerName);
            
        return workedDays;
    }

    /// * Crear una funcion que no devuelva nada y no reciba nada.
    /// - la funcion leerá "movimientos" de un fichero de origen.
    /// - Cada linea del fichero de origen contendrá un "movimiento". 
    /// - Cada "movimiento" podrá ser NORTE, SUR, ESTE u OESTE.
    /// - Empezando en el centro de la pantalla, poner un "cursor" que
    /// vaya haciendo los movimientos moviendose un espacio en la dirección
    /// indicada por el movimiento.
    /// - Dejar un espacio de tiempo entre cada movimiento.
    /// - Cada vez que el "cursor" se mueva, borrará el movimiento
    /// anterior, habiendo siempre un solo cursor en la pantalla.
    /// - Controlar que el "cursor" no pueda salirse de los márgenes 
    /// de la consola, pero no cortar la serie de movimientos, simplemente
    /// no hacer ese movimiento en concreto.
    /// - Cuando la funcion haya ejecutado todos los movimientos, el
    /// cursor volvera a la posición inicial y ejecutará los movimientos
    /// de nuevo, siguiendo así hasta que se finalice manualmente el programa.

    public static void moveCursorFromFile()
    {

        while (true)
        {
            string filename = "movements.txt";
            Console.Clear();
            if (!File.Exists(filename)) generateFile(filename);

            string[] movements = File.ReadAllLines(filename);

            doMovements(movements);

        }
    }

    public static void generateFile( string filename)
    {
        Random random = new Random();
        int length = 200;
        string[] cardinalsPoints = ["NORTE", "SUR", "ESTE", "OESTE"];
        string[] tofillFile = new string[length];

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(0, 4);
            tofillFile[i] = cardinalsPoints[index];
        }
        File.WriteAllLines(filename, tofillFile);

    }

    public static int[] getInitialCoords()
    {
        int top = Console.WindowHeight / 8;
        int left = Console.WindowWidth / 2;

        return [top, left];
    }

    private static void doMovements(string[] movements)
    {
        int[] coords = getInitialCoords();
        int speed = 50;

        foreach (string movement in movements)
        {
            
            speed = changeSpeed(speed);
            Thread.Sleep(speed);

            paintCursor(coords, true);
            coords = getNewCoords(movement, coords);
            paintCursor(coords, false);
        }

    }

    private static int changeSpeed(int speed)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (speed > 20)
                {
                    speed -= 20;
                }
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (speed < 500)
                {
                    speed += 20;
                }
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                System.Environment.Exit(0);
            }

        }
        return speed;
    }

    private static void paintCursor(int[] coords, bool paintSpace)
    {
        if (paintSpace)
        {
            Console.SetCursorPosition(coords[1], coords[0]);
            Console.Write(" ");
        }
        else
        {
            Console.SetCursorPosition(coords[1], coords[0]);
            Console.Write("█");
        }

    }

    private static int[] getNewCoords(string movement, int[] coords)
    {
        if (movement == "NORTE")
        {
            if (coords[0] > 0)
            {
                coords[0]--;
            }
        }
        else if (movement == "SUR")
        {
            int maxTop = 2 * getInitialCoords()[0];
            if (coords[0] < maxTop-1)
            {
                coords[0]++;
            }
        }
        else if (movement == "ESTE")
        {
            int maxLeft = 2 * getInitialCoords()[1];
            if (coords[1] < maxLeft-1)
            {
                coords[1]++;
            }
        }
        else
        {
            if (coords[1] > 0)
            {
                coords[1]--;
            }

        }

        return coords;
    }
    /// * Crear una funcion que no reciba ningun parametro ni devuelva nada.
    /// - Leerá de un fichero por lineas un listado de tareas y su
    /// duracion en segundos.
    /// - Cada linea contendrá el nombre de la terea y su duración en
    /// segundos tal que NOMBRE_TAREA, TIEMPO.
    /// - El tiempo vendrá indicado en segundos, con un mínimo de 1 
    /// y un maximo de 10, numeros enteros sin decimales.
    /// - el programa "hará" cada tarea, mostrando una barra de progreso 
    /// con consola, que se irá lleando cada segundo en una cantidad
    /// proprcional a la duración de la tarea.
    /// - El programa mostrará un porcentaje de completitud de la tarea,
    /// empezando por el 0% y terminando en el 100%, sin decimales.
    /// - El programa mostrará también el nombre de la tarea que se está 
    /// realizando.
    /// - El programa irá realizando las tareas de forma secuencial,
    /// hasta completar la última y terminará entonces.
    
    public static void tasksLoading()
    {
        paintLoadBarLimits();
        
        string[] tasksAndTime = File.ReadAllLines("tasksAndTimeSpend.txt");

        foreach (string taskWithTime in tasksAndTime)
        {
            Thread.Sleep(1000);
            string[] line = taskWithTime.Split(",");

            int timeLapse = int.Parse(line[1]);
            paintLoadingBar(30, true);
            writeTask(line[0]);

            for (int i = 0; i <= timeLapse; i++)
            {
                int lengthToPaint = getLength(i, timeLapse);

                paintLoadingBar(lengthToPaint, false);

                writePercentage(i, timeLapse);

                Thread.Sleep(1000);
            }
        }
    }

    private static int getLength(int time, int timeLapse)
    {
        return 30 * time / timeLapse;
    }

    private static void writeTask(string task)
    {
        Console.ResetColor();
        Console.SetCursorPosition(getInitialCoords()[1] - 10, 1);
        Console.Write(new string(' ', 30));
        Console.SetCursorPosition(getInitialCoords()[1] - 10, 1);
        Console.Write("COMPLETANDO {0}", task);
    }

    private static void paintLoadingBar(int pixelsToPaint, bool resetColor)
    {
        int top = getInitialCoords()[0];
        int left = getInitialCoords()[1];
        int jMax = pixelsToPaint - 15;
        
        for (int i = 1; i <= 4; i++)
        {
            for (int j = -15; j < jMax; j++)
            {
                Console.SetCursorPosition(left + j, top + i);
                if (resetColor)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                    Console.Write("█");
            }
        }
    }

    private static void writePercentage(int currentTime, int totalTime)
    {
        int top = getInitialCoords()[0];
        int left = getInitialCoords()[1];
        Console.ResetColor();
        Console.SetCursorPosition(getInitialCoords()[1], 10);
        Console.Write(new string(' ', 10));
        Console.SetCursorPosition(getInitialCoords()[1], 10);
        Console.Write("{0} %", 100 * currentTime / totalTime);

    }

    private static void paintLoadBarLimits()
    {
        int top = getInitialCoords()[0];
        int left = getInitialCoords()[1];


        for (int i = 0; i < 6; i++)
        {
            for (int j = -16; j < 16; j++)
            {
                Console.SetCursorPosition(left + j, top + i);
                if (j == -16 && i == 0)
                {
                    Console.Write("╔");
                }
                else if (j == 15 && i == 0)
                {
                    Console.Write("╗");
                }
                else if (j == -16 && i == 5)
                {
                    Console.Write("╚");
                }
                else if (j == 15 && i == 5)
                {
                    Console.Write("╝");
                }
                else if (i == 0 || i == 5)
                {
                    Console.Write("═");
                }
                else if (j == -16 || j == 15)
                {
                    Console.Write("║");
                }
            }
        }

    }
}
