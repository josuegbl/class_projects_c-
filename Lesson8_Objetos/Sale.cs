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

        bool isValidSale = validateSale(sausages);
        if (isValidSale)
        {
            this.products = sausages;
            this.productCounter = sausages.Length;
        }
        else
        {
            Console.WriteLine("No es una compra válida.");
            Console.WriteLine("por favor, compruebe la lista de productos.");
        }
    }

    private bool validateSale(Sausage[] productsToSale)
    {
        bool validSale = true;

        if (productsToSale.Length > 0)
        {
            for (int i = 0; i < productsToSale.Length; i++)
            {
                for (int j = 0; j != i && j < productsToSale.Length; j++)
                {
                    if (productsToSale[i].getName() == productsToSale[j].getName())
                    {
                        validSale = false;
                        i = productsToSale.Length;
                        j = productsToSale.Length;
                    }
                }
            }
        }

        return validSale;
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
            bool isValidSale = validateSale(this.products);
            this.products[this.productCounter] = product;
            this.productCounter++;
        }
    }

    public Sausage[] getProducts()
    {
        return this.products;
    }

}
