using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

/// <summary>
/// * Queremos modelar el uso de un grifo.
///   - El grifo tendrá un déposito de agua asociado, con una
///   cantidad de litros disponibles.
///   - El grifo se podrá abrir, gastando cada vez que se abra 1 litro
///   de agua.
///   - Ademas el grifo tendrá una valvula asociada que puede
///   estar abierta o cerrada, pudiendo variar su estado.
///   - Si la valvula está cerrada, el grifo no se podrá abrir y 
///   no gastará agua.
///   - Si no queda agua en el deposito, el grifo no se podrá abrir tampoco.
/// </summary>

public  class Grifo
{
    int waterDeposit;
    bool valveIsOpen;

    const bool DEFAULT_VALVE_OPEN = false;

    public Grifo()
    {
    }

    public Grifo(int waterDeposit)
    {
        this.waterDeposit = waterDeposit;
        this.valveIsOpen = Grifo.DEFAULT_VALVE_OPEN;

    }

    public Grifo(int waterDeposit, bool openValve)
    {
        this.waterDeposit = waterDeposit;
        this.valveIsOpen = openValve;
    }

    public void getWater()
    {
        if (this.valveIsOpen && !depositEmpty())
        {
            Console.WriteLine("1L of water served!");
            this.waterDeposit--;
        }
    }

    public void openValve()
    {
        this.valveIsOpen = true;
    }

    public void closeValve()
    {
        this.valveIsOpen = false;
    }

    private bool depositEmpty()
    {
        bool isEmpty = false;
        if (this.waterDeposit == 0)
        {
            isEmpty = true;
            Console.WriteLine("Water deposit is empty");
        }
        return isEmpty;
    }

    public void refillDeposit(int litresOfWater)
    {
        this.waterDeposit = litresOfWater;
    }

    public void showInfo()
    {
        string valveState = this.valveIsOpen ? "open" : "closed";
        Console.WriteLine($"The deposit has {this.waterDeposit} L of water and the valve is " + valveState);
    }
}
