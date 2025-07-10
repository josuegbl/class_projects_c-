using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Product
{
    string name;
    int amount;

    public Product(string name, int amount)
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

    public Product retireFromAmount(Product product)
    {
        if ((this.amount - product.amount) >= 0)
        {
            int newStock = getAmount() - product.amount;
            setAmount(newStock);
        }
        return this;
    }


}
