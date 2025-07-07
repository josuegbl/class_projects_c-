using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

/// <summary>
///  * Vamos a modelar el comportamiento de una puerta, que podrá estar 
///  abierta o cerrada.
///  - La puerta empezará cerrada.
///  - La puerta se podrá abrir y cerrar, lo que se avisará
///  por pantalla si se puede hacer o no.
///  - La puerta no se puede cerrar si ya está cerrada,
///  lo que ahrá que avisar por pantalla y lo mismo
///  pasaría si queremos abrirla si ya está abierta.
///  - Se le podrá "preguntar" a la puerta su estado, si está
///  abierta o cerrada, de lo cual informará devloviendo un mensaje
///  como resultado
/// </summary>
public class Door
{
    bool isOpen;

    public Door()
    {
        this.isOpen = false;
    }

    public void openDoor()
    {
        if (!this.isOpen)
        {
            this.isOpen = true;
            Console.WriteLine("The door is opening.");
        }
        else
        {
            Console.WriteLine("The door is already open, so you cannot open it again.");
        }

    }

    public void closeDoor()
    {
        if (this.isOpen)
        {
            this.isOpen = false;
            Console.WriteLine("The door is closing.");
        }
        else
        {
            Console.WriteLine("The door is already closed, so you cannot close it again.");
        }
    }

    public void isOpenOrClose()
    {
        string status = (this.isOpen) ? "open" : "closed";

        Console.WriteLine($"The door is {status}");
    }
}
