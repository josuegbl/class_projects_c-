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

    public void setName(string name)
    {
        this.name = name;
    }

    public int getAmount()
    {
        return this.amount;
    }

    public void setAmount(int amount)
    {
        this.amount = amount;
    }

    public Sausage retireFromAmount(Sausage sausage)
    {
        if ((this.amount - sausage.amount) >= 0)
        {
            int newStock = getAmount() - sausage.amount;
            setAmount(newStock);
        }
        return this;
    }
}
