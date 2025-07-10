using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Tostadora : AparatoElectrico
{
    int toastTimelapse;
    bool removableTray;
    public Tostadora(int voltage, int toastTimelapse, bool removableTray)
        : base(voltage)
    {
        this.toastTimelapse = toastTimelapse;
        this.removableTray = removableTray;
    }

    public void Tostar()
    {
        Console.WriteLine($"Tostando el pan, tardará {this.toastTimelapse} minutos");
        
        if (this.removableTray) 
            Console.WriteLine("Al terminar, puede retirar las migas con la bandeja extraible");
    }

}
