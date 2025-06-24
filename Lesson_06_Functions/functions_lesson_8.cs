//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.ConstrainedExecution;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_06_Functions;

//public class functions_lesson_8
//{
//    public static void Main(string[] args)
//    {
//        bool[] kk = functions_lesson_8.watchSegment1();
//    }
//    //TODO!!!!
//    // * Simular un display de 7 segmentos.
//    // - La función recibirá un número como parámetro y lo mostrará por pantalla.
//    // - Se podrán pintar los números del 0 al 9.
//    // - Los números se "pintarán" en la pantalla "iluminando" los segmentos necesarios para "construir" ese número.
//    // - Cada número necesitará un conjunto de segmentos "iluminados" para verse en pantalla.
//    // - Habrá que preparar unas coordenadas, que formen un rectángulo, para los segmentos en general y para cada segmento en particulas.
//    // - EXTRA: Crear un efecto en el que los números vayan apareciendo en pantalla de forma consecutiva, del 0 al 9,
//    // dejando un espacio de tiempo entre cada uno.

//    public static bool[][] watchSegment1()
//    {
//        return [[true, false, false]
//              , [false, false, false]
//              , [false, false, false]];
//    }
//    public static bool[][] watchSegment2()
//    {
//        return [[false, true, false]
//              , [false, false, false]
//              , [false, false, false]];
//    }
//    public static bool[][] watchSegment3()
//    {
//        return [[false, false, true]
//              , [false, false, false]
//              , [false, false, false]];
//    }
//    public static bool[][] watchSegment4()
//    {
//        return [[false, false, false]
//              , [false, true, false]
//              , [false, false, false]];
//    }
//    public static bool[][] watchSegment5()
//    {
//        return [[false, false, false]
//              , [false, false, false]
//              , [true, false, false]];
//    }
//    public static bool[][] watchSegment6()
//    {
//        return [[false, false, false]
//              , [false, false, false]
//              , [false, true, false]];
//    }
//    public static bool[][] watchSegment7()
//    {
//        return [[false, false, false]
//              , [false, false, false]
//              , [false, false, true]];
//    }

//    public static bool[][] getNumberZero()
//    {

//    }
//    public static bool[][] getNumberOne()
//    {

//    }
//    public static bool[][] getNumberTwo()
//    {

//    }
//    public static bool[][] getNumberThree()
//    {

//    }
//    public static bool[][] getNumberFour()
//    {

//    }
//    public static bool[][] getNumberFive()
//    {

//    }
//    public static bool[][] getNumberSix()
//    {

//    }
//    public static bool[][] getNumberSeven()
//    {

//    }
//    public static bool[][] getNumberEigth()
//    {

//    }
//    public static bool[][] getNumberNine()
//    {

//    }
//}
