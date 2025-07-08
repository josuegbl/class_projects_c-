using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;
/// <summary>
///  * Crear una clase para gestionar una tienda de embutidos.
///  - La tienda vende salchichones, chorizos y morcillas, de los 
///  cuales tiene una cantidad en la tienda para ir vendiendo.
///  - La tienda podrá hacer ventas, para lo que habrá que indicar qué 
///  se vende y la cantidad que se va a vender.
///  - En cada venta se podrán vender varios tipos de productos, cada uno
///  con una cantidad asociada, pero no se podrá repetir en la misma venta
///  más de una vez el mismo producto.
///  - Por ejemplo se podrá hacer una venta de 3 salchichones. Otra venta
///  podrían ser 2 salchichones, 5 chorizos y 1 morcilla, pero no puede
///  venderse 1 salchichón, 1 salchichon, 2 morcillas.
///  - Cuando se haga una venta, se actualizará el stock de cada embutido.
///  - Si al ir a hacer una venta, no hubiera cantidad suficiente de algún
///  producto, esta no se podrá hacer y se indicará por pantalla.
///  - No hacer falta guardar las ventas en sí, solo hay que ir actualzando
///  la cantidad si y solo sí toda la venta se puede hacer.
///  Por último, la tienda podrá consultar las cantidades de cada producto,
///  para ello podrá llamar a una función que muestre las cantidades 
///  restantes todas a la vez.
/// </summary>

public class SausageStore
{
    Sausage[] products;
    int productCounter;

    public SausageStore()
    {
        this.products = new Sausage[3];
        this.productCounter = 0;
    }

    public void addProductStock(Sausage product)
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

    public void doSale(Sale sale)
    {
        bool isValidSale = validateSale(sale.getProducts());
        bool allowSale = this.saleAllow(sale.getProducts());

        if (allowSale && isValidSale) 
        {
            Console.WriteLine("¡Enhorabuena por comprar en esta tienda!\n");
            foreach (Sausage product in sale.getProducts())
            {
                retireFromStock(product);
            }
        }
    }

    private bool saleAllow(Sausage[] productsToSale)
    {
        bool allowSale = true;
        Sausage invalidProduct = new Sausage("default", 0);

        for (int i = 0; i < productsToSale.Length; i++)
        {
            for (int j = 0; j < this.products.Length; j++)
            {
                if (productsToSale[i].getName() == this.products[j].getName())
                {
                    if (productsToSale[i].getAmount() > this.products[j].getAmount())
                    {
                        allowSale = false;
                        invalidProduct = productsToSale[i];
                        i = productsToSale.Length;
                    }
                    j = this.products.Length;
                }
            }
        }
        if (!allowSale)
        {
            Console.WriteLine("La venta no se puede realizar");
            Console.WriteLine($"No hay stock suficiente de {invalidProduct.getName()}.\n");
        }
        return allowSale; 
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
        if (!validSale)
        {
            Console.WriteLine("No es una compra válida.");
            Console.WriteLine("por favor, compruebe la lista de productos.");
        }
        return validSale;
    }


    private void retireFromStock(Sausage product)
    {
        for (int i = 0; i < this.productCounter; i++)
        {
            if (product.getName() == this.products[i].getName())
            {
                if (product.getAmount() <= this.products[i].getAmount())
                {
                    this.products[i] = this.products[i].retireFromAmount(product);
                }
                break;
            }
        }

    }

    public void getStock()
    {
        Console.WriteLine("El inventario en tienda es el siguiente: \n");
        foreach (Sausage product in this.products)
        {
            Console.WriteLine($" producto: {product.getName()}, stock: {product.getAmount()}");
        }
        Console.WriteLine();
    }
}
