using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.GOT;

public class Stark : CasaGOT
{
    public Stark()
    {
        this.lema = "Winter is coming";
    }

    public override string Lema()
    {
        return this.lema;
    }

}
