using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class FanTenis : FanDeporte
{
    string tenistaFavorito;

    public FanTenis(string tenistaFavorito) : base("tenis")
    {
        this.tenistaFavorito = tenistaFavorito;
    }

    public override string ToString()
    {
        return base.ToString() + " y mi tenista favorito es " + this.tenistaFavorito ;
    }
}
