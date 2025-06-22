// See https://aka.ms/new-console-template for more information
float precioTomate = 3.0f;
float precioPatata = 1.0f;
float precioHuevos = 4.0f;
float dinero = 10.0f;
float nuevoDinero = 0.0f;
float gasto = 0;
int tomates = 1;
int patatas = 1;
int huevos = 1;

gasto = tomates * precioTomate + patatas * precioPatata + huevos * precioHuevos;

Console.WriteLine("My First script");
if (gasto <= dinero)
{
    Console.WriteLine($"Te has gastado {gasto} euros");
    nuevoDinero = dinero - gasto;
    Console.Write($"Te quedan {nuevoDinero} euros");

}
else
{
    Console.Write("Not enough money");
}
