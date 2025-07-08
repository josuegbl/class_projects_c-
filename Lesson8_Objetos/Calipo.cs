using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Calipo : Helado
{
    public Calipo(string sabor)
    : base(sabor)
    {

    }

    public override string ToString()
    {

        return $"Soy un Calipo de " + this.sabor;
    }
}
