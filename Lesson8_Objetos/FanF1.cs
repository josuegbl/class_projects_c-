using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class FanF1 : FanDeporte
{
    string pilotoFavorito;

    public FanF1(string pilotoFavorito) : base("F1")
    {
        this.pilotoFavorito = pilotoFavorito;
    }

    public override string ToString()
    {
        return base.ToString() + " y mi piloto favorito es " + this.pilotoFavorito;
    }
}
