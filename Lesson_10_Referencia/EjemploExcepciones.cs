using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia;

public class EjemploExcepciones
{
    public static void Main(string[] args)
    {
        Console.WriteLine("En Ejemplo Excepciones");

        try
        {
            throw new ArgumentNullException("Ha petado");
        } 
        
        catch(FormatException ex)
        {
            Console.WriteLine("FormatException");
            Console.WriteLine("Motivo de la excepcion " + ex.Message);
        }

        catch(Exception ex)
        {
            Console.WriteLine("esta es la exception generica");
            Console.WriteLine("Motivo: " + ex.Message);
        } finally
        {
            Console.WriteLine("Esto se ejecuta siempre");
        }

        Console.WriteLine("HOLAAAAA");
        Console.WriteLine("HOLAAAAA");
        Console.WriteLine("HOLAAAAA");
    }
}
