using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Sale
{
    Sausage[] products;
    int productCounter;

    public Sale()
    {
        this.products = new Sausage[3];
        this.productCounter = 0;
    }

    public Sale(Sausage[] sausages)
    {
        this.products = sausages;
        this.productCounter = sausages.Length;
    }

    public void addProductToSale(Sausage product)
    {
        if (this.productCounter == 0)
        {
            this.products[0] = product;
            this.productCounter++;
        }
        else if (this.productCounter < 3)
        {
            this.products[this.productCounter] = product;
            this.productCounter++;
        }
    }

    public Sausage[] getProducts()
    {
        return this.products;
    }

}
