using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Sausage
{
    string name;
    int amount;
   

    public Sausage()
    {

    }

    public Sausage(string name, int amount)
    {
        this.name = name;
        this.amount = amount;
    }

    public string getName()
    {
        return this.name;
    }

    public int getAmount()
    {
        return this.amount;
    }

    public void retireFromStock(int amount)
    {
        if ((amount - this.amount) > 0 )
        {
            this.amount -= amount;
        }
    }






}
