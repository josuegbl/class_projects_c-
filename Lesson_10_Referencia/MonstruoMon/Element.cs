using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Element
{
    ElemenType elemenType;
    public Element(ElemenType elemenType) 
    {
        this.elemenType = elemenType;
    }

    public ElemenType getElemenType()
        { return this.elemenType; }

    public ElemenType getWeakness()
    {
        int numValue = this.elemenType.GetHashCode();
        if (numValue == 0)
            return ElemenType.Rayo;
        else
            return (ElemenType)numValue-1;
    }

    public ElemenType getMightiness()
    {
        int numValue = this.elemenType.GetHashCode();
        if (numValue == 3)
            return ElemenType.Agua;
        else
            return (ElemenType)numValue+1;
    }

    public override string ToString()
    {
        return getElemenType().ToString();
    }
}
