using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Sausage
{
    string name;
    static int amount;
   

    public Sausage()
    {

    }

    public Sausage(string name, int amount)
    {
        this.name = name;
        Sausage.amount = amount;
    }

    public string getName()
    {
        return this.name;
    }

    public int getAmount()
    {
        return Sausage.amount;
    }

    public void retireFromStock(int amount)
    {
        if ((amount - Sausage.amount) > 0 )
        {
            Sausage.amount -= amount;
        }
    }






}
