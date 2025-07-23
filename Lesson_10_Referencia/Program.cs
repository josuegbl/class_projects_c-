

namespace Lesson_10_Referencia;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("En EjemploMemoria");

        int x = 0;

        Console.WriteLine("En el Main x es " + x);

        Test(ref x);
        Console.WriteLine("En el main depues de llamar a la funcion x es " + x);

        Test test = new Test();
        Console.WriteLine("Antes de llamar a la funcion, x en objeto TEST " + test.x);
        Program.testPbject(test);

        Console.WriteLine("depues de la funcion testPbject a la funcoin,x en objeto Test es " + x);


    }

    public static void testPbject(Test test)
    {
        test.x++;
        Console.WriteLine("En la cunfion testObject x en objeto test vale " + test.x);
    }

    public static void Test(ref int x)
    {
        x++;
        Console.WriteLine("En la funcion test x es " + x);
    }
}


