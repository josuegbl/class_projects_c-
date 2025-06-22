namespace introProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 1;

            Console.WriteLine("x es " + x);
            Console.WriteLine("y es " + y);


            x = x + y; 
            Console.WriteLine("\nTras la suma");
            Console.WriteLine("x es " + x);
            Console.WriteLine("y es " + y);

            y = x - y;
            Console.WriteLine("\nTras la resta");
            Console.WriteLine("x es " + x);
            Console.WriteLine("y es " + y);

            x = x * y;
            Console.WriteLine("\nTras la multiplicacion");
            Console.WriteLine("x es " + x);
            Console.WriteLine("y es " + y);

            y = x / y;
            Console.WriteLine("\nTras la division");
            Console.WriteLine("x es " + x);
            Console.WriteLine("y es " + y);

            x += y;
            Console.WriteLine("\nTras la suma +=");
            Console.WriteLine("x es " + x);
            Console.WriteLine("y es " + y);

            x = x % y; 
            Console.WriteLine("\nEl resto de dividir x / y es " + x);

            x = 2;
            y = 3;

            Console.WriteLine("\nx es " + x);
            Console.WriteLine("y es " + y);
            
            x = x + x * y;
            Console.WriteLine("\nNew x es " + x);


            // +
            // -
            // ++
            // --

            x = 0;
            Console.WriteLine("\nx es " + x);

            x++;
            Console.WriteLine("\nx es " + x);

            ++x;
            Console.WriteLine("\nx es " + x);

            Console.WriteLine(x++);
            Console.WriteLine(x);
            Console.WriteLine(++x);

        }
    }
}
