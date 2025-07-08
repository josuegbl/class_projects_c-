using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Frigopie : Helado
{
    public Frigopie(string sabor)
        : base(sabor)
    {

    }

    public override string ToString()
    {
        return $"Soy un Frigopie de " + this.sabor;
    }
}
