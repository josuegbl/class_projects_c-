namespace Lesson_07_Files;

public class Lesson_07_Files_01
{
    static void Main(string[] args)
    {
        //Console.WriteLine("En EjemploFicheros");
        //string test = File.ReadAllText("testStringInput.txt");

        //File.WriteAllText("testStringOutput.txt", test);

        //Console.WriteLine(test);

        //string[] testlines = File.ReadAllLines("testLinesInput.txt");

        //foreach (string line in testlines)
        //{
        //    Console.WriteLine(line);
        //}

        //testlines[2] = testlines[2] + "PRUEBA";
        //File.WriteAllLines("testLinesOutput.txt", testlines);

        //File.AppendAllText("testStringOutput.txt", "PRUEBA APPEND");

        //string[] moreWords =
        //{
        //    "en", "clase", "con", "gente"
        //};

        //File.AppendAllLines("testLinesOutput.txt", moreWords);

        Console.WriteLine(readFileAsString());
        readTenChains();
        readNumbersFromFile();

    }
    /// Realizar los siguientes ejercicios de lectura de ficheros.
    /// . Para casa ejercicio habrá que generar, al menos, una función
    /// específica para alojar el codigo, que será llamada desde el Main.

    /// Crear una funcion que no reciba ningun parametro y devuelva un entero.
    /// . Leer un fichero de entrada como string y escribir su longitud en otro
    /// de salida.
    /// . Ademas, devolver como resultado de la función la longitud del string leido y 
    /// sacar por consola dicha longitud (desde el Main).

    public static int readFileAsString()
    {
        string text = File.ReadAllText("fileToReadfunc1.txt");
        int lenghtString = text.Length;

        //File.Create("fileToWritefunc1.txt").Dispose();
        File.WriteAllText("fileToWritefunc1.txt", lenghtString.ToString());
        return lenghtString;
    }

    /// Crear una funcion que no reciba ningun parametro y que no devuelva nada.
    /// . La funcion leerá por lineas un fichero que contenga al menos 10 cadena de 
    /// texto.
    /// . La funcion generará tres numeros aleatorios, que se han de corresponder con los
    /// posibles "indices" del fichero leído.
    /// . Las posiciones indicadas por los números aleatorios se convertirán a mayúsculas.
    /// . Una vez terminado el proceso, la función volverá a escribir por líneas en
    /// el mismo fichero de entrada

    public static void readTenChains()
    {
        string[] chainsFromFile = File.ReadAllLines("fileReadTenChains.txt");
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(0, chainsFromFile.Length);
            chainsFromFile[index] = chainsFromFile[index].ToUpper();
        }

        File.AppendAllLines("fileReadTenChains.txt", chainsFromFile);
    }

    /// Crear una funcion que no reciba ningun parametro y no devuelva nada.
    /// - Leer un fichero por lineas, que contenga los 10 primeros numeros naturales,
    /// en orden, escritos por parabras (Cero, Uno....)
    /// . Escribir un fichero por lineas. Si el equivalente entero de la palabra leída 
    /// (Cero -> 0, Uno -> 1...) es par, poner la palabra en mayuscula.
    /// Si el valor es impar, escribir el numero en el fichero tal que: 
    /// "El numero NUMERO es impar".
    public static void readNumbersFromFile()
    {
        string[] chainsFromFile = File.ReadAllLines("fileReadNumbersFromFile.txt");
        string[] numbersAndComments = new string[chainsFromFile.Length];

        for (int i = 0; i < chainsFromFile.Length; i++)
        {
            if (i % 2 == 0)
            {
                numbersAndComments[i] = chainsFromFile[i].ToUpper(); 
            }
            else
            {
                numbersAndComments[i] = "El número " + i.ToString() + " es impar";
            }
        }
        //File.Create("fileWriteNumbersFromFile.txt").Dispose();
        File.WriteAllLines("fileWriteNumbersFromFile.txt", numbersAndComments);

    }

}
