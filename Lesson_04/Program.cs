using System.Net.Security;

namespace Lesson_04;

public class Program
{
    public static void Main(string[] args)
    {
        //int x = 0;
        //x++;
        //Console.WriteLine("la suma de 0 y 1 es " +  x);

        //x = 4 - 3 - 5;
        //Console.WriteLine("el resultado de la operacion  4 - 3 - 5 es " + x);

        //x = 2 + 3 - 10;
        //Console.WriteLine("el resultado de la operacion  2 + 3 - 10 es " + x);

        //x = 7 * 3 * 21;
        //Console.WriteLine("el resultado de la operacion  7 * 3 * 21 es " + x);

        //x = 9 / 3;
        //Console.WriteLine("el resultado de la operacion  9 / 3 es " + x);

        //x = 5 * 3 - 3;
        //Console.WriteLine("el resultado de la operacion  5 * 3 - 3 es " + x);

        //x = 25 + 31 - (10 + 2);
        //Console.WriteLine("el resultado de la operacion  25 + 31 - (10 + 2) es " + x);

        //x = 4 * 3 * 12 / 8;
        //Console.WriteLine("el resultado de la operacion  4 * 3 * 12 / 8 es " + x);

        //x = 4 + 3 + 10 / 5;
        //Console.WriteLine("el resultado de la operacion  4 + 3 + 10 / 5 es " + x);

        //x = (4 / 2 + 25) + (3 - 6);
        //Console.WriteLine("el resultado de la operacion  (4 / 2 + 25) + 3 - 6 es " + x);

        //x = (3 - 5 ) + (10 - 2) + (3 - 1);
        //Console.WriteLine("el resultado de la operacion  (3 - 5 ) + (10 - 2) + (3 - 1) es " + x);

        //float y = 0.0F;
        //y = ((8 / 4) - (35 / 3.0F)) + (3 * 8);
        //Console.WriteLine("el resultado de la operacion  ((8 / 4) - (35.0 / 3.0)) + (3 * 8) es " + y);

        //x = ((3 * 8) / 2) + (10 + 22);
        //Console.WriteLine("el resultado de la operacion  ((3 * 8) / 22) + (10 + 22) es " + x);

        //x = (3 * 8 / 2) + (10 + 22);
        //Console.WriteLine("el resultado de la operacion  (3 * 8 / 2) + (10 + 22) es " + x);

        //y = 11 * 3 / 2.0F  - 1;
        //Console.WriteLine("el resultado de la operacion  11 * 3 / 2.0  - 1 es " + y);

        //x = 10 + 218 + (1 - 3 - 8);
        //Console.WriteLine("el resultado de la operacion  10 + 218 + (1 - 3 - 8) es " + x);

        //x = (30 / 6 + 10 * 4) - 100 - 20 / 5;
        //Console.WriteLine("el resultado de la operacion  (30 / 6 + 10 * 4) - 100 - 20 / 5 es " + x);

        //x = 1 + 2 + 10 - 3 * 4;
        //Console.WriteLine("el resultado de la operacion  1 + 2 + 10 - 3 * 4 es " + x);

        //x = (3 + 5 + 10 - 23) * 4;
        //Console.WriteLine("el resultado de la operacion  (3 + 5 + 10 - 23) * 4 es " + x);



        ////CONDICIONALES
        //int num1 = 1;
        //int num2 = 2;
        //if (num1 == num2)
        //{
        //    Console.WriteLine("Es igual");
        //}
        //else
        //{
        //    Console.WriteLine("No es igual");
        //}

        /////***************************************///

        //if (num1 + num2 > 10)
        //{
        //    Console.WriteLine("La suma es mayor que 10");
        //}

        /////***************************************///
        
        //if ((num1 - num2) < 10)
        //{
        //    Console.WriteLine("la resta es menor que 10");
        //}

        /////***************************************///

        //if (num1 + num2 > 10)
        //{
        //    Console.WriteLine("La suma es mayor que 10");
        //}
        //else if ((num1 - num2) > 10)
        //{
        //    Console.WriteLine("la resta es mayor que 10");
        //}

        /////***************************************///

        //char aChar = 'a';
        //if (aChar == 'a' || aChar == 'e' || aChar == 'i' || aChar == 'o' || aChar == 'u')
        //{
        //    Console.WriteLine("es una vocal");
        //}
        //else 
        //{
        //    Console.WriteLine("no es una vocal");
        //}

        /////***************************************///

        //if (aChar == 's' && (num1 - num2) > 0)
        //{
        //    Console.WriteLine("OK");
        //}
        //else if (aChar == 's')
        //{
        //    Console.WriteLine("CASI OK");
        //}
        //else 
        //{
        //    Console.WriteLine("OTRO CASO");
        //}

        /////***************************************///

        //string aStr = "TRES";
        //int numStr = 0;

        //if (aStr == "CERO") numStr = 0;
        //if (aStr == "UNO") numStr = 1;
        //if (aStr == "DOS") numStr = 2;
        //if (aStr == "TRES") numStr = 3;
        //if (aStr == "CUATRO") numStr = 4;
        //if (aStr == "CINCO") numStr = 5;
        //if (aStr == "SEIS") numStr = 6;
        //if (aStr == "SIETE") numStr = 7;
        //if (aStr == "OCHO") numStr = 8;
        //if (aStr == "NUEVE") numStr = 9;
        ////if (num1 == numStr)

        /////***************************************///

        //// si una cadena de texto es igual a otra...
        //string cadena1 = "sadfdaf";
        //string cadena2 = "asasf";
        //string cadena3 = "asasf";
        //if (cadena1 == cadena2 || cadena1 == cadena3 || cadena2 == cadena3) 
        //{
        //    Console.WriteLine("Algunas de las cadenas de texto son iguales");
        //}

        /////***************************************///


        //if (num1 / num2 == 1)
        //{
        //    Console.WriteLine("Mismo numero");
        //}
        //else if (num1 / num2 == 4) 
        //{
        //    Console.WriteLine("el resultado es 4");
        //}

        /////***************************************///

        //int num3 = 10;

        //if ((num1 * num2 * num3) <= 100)
        //{
        //    if (num1 > 10 || num2 > 10 || num3 > 10)
        //    {
        //        Console.WriteLine("un numero es mayor que 10");
        //    }
        //}
        //else 
        //{
        //    Console.WriteLine("Otro resultado");
        //}

        /////***************************************///

        //char car1 = '2';
        //char car2 = '1';
        //bool emparejarChat = false;

        //char num2char1 = Convert.ToChar(num1);
        //char num2char2 = Convert.ToChar(num2);
        //char car3 = '5';

        //if (car1 == num2char1)
        //{
        //    emparejarChat = true;
        //}
        //else
        //{
        //    emparejarChat = false;
        //}
        //if (car3 == car1) 
        //{
        //    if (emparejarChat)
        //    {
        //        Console.WriteLine("el numero emparejado es " + num1);
        //    }
        //    else
        //    {
        //        Console.WriteLine("el numero emparejado es " + num2);
        //    }
        //}
        //if (car3 == car2)
        //{
        //    if (emparejarChat)
        //    {
        //        Console.WriteLine("el numero emparejado es " + num2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("el numero emparejado es " + num1);
        //    }
        //}

        /////***************************************///

        //string ajustar = "Ajustar";

        //if (ajustar == "Ajustar")
        //{
        //    if ((num1 + num2) > 150)
        //    {
        //        Console.WriteLine("Ajuste pendiente");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ajuste no necesario");
        //    }
        //}
        //else 
        //{
        //    Console.WriteLine("Ajuste no solicitado");
        //}

        /////***************************************///

        //if (num1 / num2 > 5)
        //{
        //    if (cadena1 == cadena2)
        //    {
        //        Console.WriteLine("las cadenas son iguales");
        //    }
        //    else
        //    {
        //        Console.WriteLine("las cadenas no son iguales");
        //    }
        //}
        //else if (num1 / num2 == 5) 
        //{ 
        //    Console.WriteLine("las division es 5");
        //}

        ///***************************************///
        float altura = 1.80f;
        float alturaMinima = 1.30f;
        if (altura > alturaMinima)
        {
            Console.WriteLine("Se puede subir a la atraccion");
        }
        else
        {
            Console.WriteLine("No se puede subir a la atraccion");
        }

        ///***************************************///
        bool esInvierno = false;
        float volumenArena = 20.0F;

        if (esInvierno)
        {
            volumenArena *= 1.1F;
            Console.WriteLine("Es invierno, así que el volumen de arena es: " + volumenArena);
        }
        else 
        {
            Console.WriteLine("No es invierno, asi que el volumen de arena es: " + volumenArena);
        }
        ///***************************************///
        float volumenBotijo = 10.0F;
        float extracion1 = 11.0F;
        float extracion2 = 3.0F;
        float extracion3 = 3.0F;

        if (extracion1 >= volumenBotijo)
        {
            Console.WriteLine("El botijo se ha quedado sin agua en la extraccion 1");
        }
        else
        {
            volumenBotijo -= extracion1;
            Console.WriteLine($"Quedan {volumenBotijo} litros de agua en el botijo tras la extraccion 1");
            if (extracion2 >= volumenBotijo)
            {
                Console.WriteLine("El botijo se ha quedado sin agua en la extraccion 2");
            }
            else
            {
                volumenBotijo -= extracion2;
                Console.WriteLine($"Quedan {volumenBotijo} litros de agua en el botijo tras la extraccion 2");
                if (extracion3 >= volumenBotijo)
                {
                    Console.WriteLine("El botijo se ha quedado sin agua en la extraccion 3");
                }
                else 
                {
                    volumenBotijo -= extracion3;
                    Console.WriteLine($"Quedan {volumenBotijo} litros de agua en el botijo");
                }

            }
        }
        ///***************************************///
        bool bandera1 = true;
        bool bandera2 = true;

        if (bandera1 && bandera2)
        {
            Console.WriteLine("el avion puede ir a pista a despegar");
        }
        else
        {
            Console.WriteLine("el avion no puede despegar");
        }

        ///***************************************///
        int producto1 = 0;
        int producto2 = 0;
        int producto3 = 0;
        int producto4 = 0;
        int compra1 = 0;
        int compra2 = 0;
        int compraTotal = 0;
        float precioProducto1 = 5.21F;
        float precioProducto2 = 3.42F;
        float precioProducto3 = 8.61F;
        float precioProducto4 = 3.42F;
        float dineroGastadoCompra1 = 0;
        float dineroGastadoCompra2 = 0;
        float dineroGastadoTotal = 0;

        producto2 = 5;
        if (producto1 != 0)
        {
            dineroGastadoCompra1 = producto1 * precioProducto1;
            compra1 = producto1;
        }
        else if (producto2 != 0)
        {
            dineroGastadoCompra1 = producto2 * precioProducto2;
            compra1 = producto2;
        }
        else if (producto3 != 0)
        {
            dineroGastadoCompra1 = producto3 * precioProducto3;
            compra1 = producto3;
        }
        else
        {
            dineroGastadoCompra1 = producto4* precioProducto4;
            compra1 = producto4;
        }
        Console.WriteLine("El cliente ha gastado "+ dineroGastadoCompra1 + 
            " y ha comprado "+ compra1 + "productos en la compra 1" );

        producto1 = 3;

        if (producto1 != 0)
        {
            dineroGastadoCompra2 = producto1 * precioProducto1;
            compra2 = producto1;
        }
        else if (producto2 != 0)
        {
            dineroGastadoCompra2 = producto2 * precioProducto2;
            compra2 = producto2;
        }
        else if (producto3 != 0)
        {
            dineroGastadoCompra2 = producto3 * precioProducto3;
            compra2 = producto3;
        }
        else
        {
            dineroGastadoCompra2 = producto4 * precioProducto4;
            compra2 = producto4;
        }
        compraTotal = compra1 + compra2;
        dineroGastadoTotal = dineroGastadoCompra1 + dineroGastadoCompra2;
        Console.WriteLine("El cliente ha gastado " + dineroGastadoCompra2 + 
            " y ha comprado " + compra2 + "productos en la compra 2");
        Console.WriteLine("El cliente ha gastado " + dineroGastadoTotal + 
            " y ha comprado " + compraTotal + "productos en las dos compras");

        ///***************************************///
        string tecla1 = "DO";
        string tecla2 = "RE";
        string tecla3 = "MI";
        string tecla4 = "FA";
        string tecla5 = "SI";
        string notaPiano = "DOREMI";

        if (notaPiano == (tecla1 + tecla2 + tecla3)
           || notaPiano == (tecla2 + tecla3 + tecla1)
           || notaPiano == (tecla3 + tecla1 + tecla2))
        {
            Console.WriteLine("ESCALA");
        }
        else
        {
            Console.WriteLine(notaPiano);
        }
        ///***************************************///
        double comisionCuentaJoven = 4.50;
        double comisionCuentaAdulto = 3.15;
        double comisionCuentaTerceraEdad = 2.50;
        int cantidadCuentaJoven = 2;
        int cantidadCuentaAdulto = 3;
        int cantidadCuentaTerceraEdad = 0;
        double totalComisiones = 0;

        if (cantidadCuentaJoven > 0)
        { 
            totalComisiones += cantidadCuentaJoven * comisionCuentaJoven;
        }
        if (cantidadCuentaAdulto > 0)
        {
            totalComisiones += cantidadCuentaAdulto * comisionCuentaAdulto;
        }
        if (cantidadCuentaTerceraEdad > 0)
        {
            totalComisiones += cantidadCuentaTerceraEdad * cantidadCuentaTerceraEdad;
        }

        Console.WriteLine("El total de comisiones es " + totalComisiones + " Euros" );
        
        ///***************************************///
        string ingrediente1 = "HUEVO";
        string ingrdiente2 = "PATATAS";
        string listaIngredientes = " ";
        string missingIngredientes = string.Empty;

        if (listaIngredientes == ingrediente1 + ", " + ingrdiente2 || listaIngredientes == ingrdiente2 + ", " + ingrediente1)
        {
            Console.WriteLine("Se puede hacer la tortilla");
        }
        else
        {
            if (listaIngredientes != ingrediente1)
            {
                missingIngredientes += ingrediente1;
                missingIngredientes += " ";
            }
            if (listaIngredientes != ingrdiente2)
            {
                missingIngredientes += ingrdiente2;
                missingIngredientes += " ";
            }

                Console.WriteLine("No se puede hacer la tortilla, falta " + missingIngredientes);
        }

        ///***************************************///
        int horasJornadaDiario = 8;
        int horasJornadasFinde = 4;
        int totalHorasTrabajadas = 0;
        bool jornada1EsFinde = true;
        bool jornada2EsFinde = false;
        bool jornada3EsFinde = true;
        bool jornada4EsFinde = false;

        if (jornada1EsFinde)
        {
            totalHorasTrabajadas += horasJornadasFinde;
        }
        else
        {
            totalHorasTrabajadas += horasJornadaDiario;
        }
        if (jornada2EsFinde)
        {
            totalHorasTrabajadas += horasJornadasFinde;
        }
        else
        {
            totalHorasTrabajadas += horasJornadaDiario;
        }
        if (jornada3EsFinde)
        {
            totalHorasTrabajadas += horasJornadasFinde;
        }
        else
        {
            totalHorasTrabajadas += horasJornadaDiario;
        }
        if (jornada4EsFinde)
        {
            totalHorasTrabajadas += horasJornadasFinde;
        }
        else
        {
            totalHorasTrabajadas += horasJornadaDiario;
        }

        Console.WriteLine("El trabajador ha trabajado " + totalHorasTrabajadas + " horas al mes");

        ///***************************************///
        float kmRecorridos = 544.5F;
        float umbralKm = 498F;
        float consumoGasolinaPorKm = 0.067F;
        float consumoGasolina = 0;
        float volumenDeposito = 40.5F;

        if (kmRecorridos > umbralKm)
        {
            Console.WriteLine("Se ha superado el umbral de " + umbralKm + " km.");
        }
        consumoGasolina = consumoGasolinaPorKm * kmRecorridos;
        if (consumoGasolina >= 0.9 * volumenDeposito)
        {
            Console.WriteLine("Entrando en reserva de gasolina");
        }

        ///***************************************///
        bool sennalHDMI = true;
        bool sennalDisplayPort = true;
        bool primeroDisplayPort = false;

        if (!sennalHDMI && !sennalDisplayPort)
        {
            Console.WriteLine("No se recibe señal.");
        }
        else if (sennalHDMI && !sennalDisplayPort)
        {
            Console.WriteLine("Se recibe señal por HDMI. DisplayPort apagado.");
        }
        else if (!sennalHDMI && sennalDisplayPort)
        {
            Console.WriteLine("Se recibe señal por DisplayPort. HDMI apagado.");
        }
        else
        {
            Console.WriteLine("Se recibe señal por ambos puertos. ");
            if (primeroDisplayPort)
            {
                Console.WriteLine("Se está usando DisplayPort");
            }
            else
            {
                Console.WriteLine("Se está usando HDMI");
            }
        }
        ///***************************************///
        float pesoPersona1 = 75;
        float pesoPersona2 = 75;
        float pesoPersona3 = 75;
        float pesoPersona4 = 70;
        float limitePeso = 300;
        float pesoTotal = 0;
        int contadorPersonas = 0;

        contadorPersonas++;
        pesoTotal += pesoPersona1;
        if (pesoTotal > limitePeso)
        {
            Console.WriteLine("Se ha superado el límite de peso en " + (pesoTotal - limitePeso) + " kilos");
            Console.WriteLine("han subido " + contadorPersonas + " personas");
        }
        else
        {
            contadorPersonas++;
            pesoTotal += pesoPersona2;
            if (pesoTotal > limitePeso)
            {
                Console.WriteLine("Se ha superado el límite de peso en " + (pesoTotal - limitePeso) + " kilos");
                Console.WriteLine("han subido " + contadorPersonas + " personas");
            }
            else
            {
                contadorPersonas++;
                pesoTotal += pesoPersona3;
                if (pesoTotal > limitePeso)
                {
                    Console.WriteLine("Se ha superado el límite de peso en " + (pesoTotal - limitePeso) + " kilos");
                    Console.WriteLine("han subido " + contadorPersonas + " personas");
                }
                else
                {
                    contadorPersonas++;
                    pesoTotal += pesoPersona4;
                    if (pesoTotal > limitePeso)
                    {
                        Console.WriteLine("Se ha superado el límite de peso en " + (pesoTotal - limitePeso) + " kilos");
                        Console.WriteLine("han subido " + contadorPersonas + " personas");
                    }
                    else
                    {
                        Console.WriteLine("han subido " + contadorPersonas + " personas.");
                        Console.WriteLine("La cantidad de peso total es " + pesoTotal + " kilos");
                        Console.WriteLine("Faltaron " + (limitePeso - pesoTotal) + " kilos para llegar al limite aceptado");
                    }

                }

            }

        }
        ///***************************************///

    }
}
