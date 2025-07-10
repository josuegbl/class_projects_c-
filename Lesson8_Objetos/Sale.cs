using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Sale
{
    Product[] products;
    int productCounter;

    public Sale()
    {
        this.products = new Product[3];
        this.productCounter = 0;
    }

    public Sale(Product[] products)
    {
        this.products = products;
        this.productCounter = products.Length;
    }

    public void addProductToSale(Product product)
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

    public Product[] getProducts()
    {
        return this.products;
    }

}
