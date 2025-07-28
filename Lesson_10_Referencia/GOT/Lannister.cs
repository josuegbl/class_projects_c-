using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.GOT;

public class Lannister : CasaGOT
{
    public Lannister()
    {
        this.lema = "A lannister always pays his debts";
    }

    public override string Lema()
        {
            return this.lema;
        }
}
