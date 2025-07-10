using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public static class TastingNote
{
    public static string noteToGoatCheese()
    {
        return "Nota de Cata: \nCorteza natural dura enmohecida de color grisáceo.\n" +
               "Interior blanco/amarillento, pasta compacta con escasa presencia de ojos.\n" +
               "Muy cremoso y mantecoso al paladar, de sabor ligeramente ácido y con un toque salado.\n" +
               "Tiene una fuerte presencia láctica.";
    }

    public static string noteToSheepCheese()
    {
        return "Textura muy cremosa, intensidad de ahumado ligero.\n" +
               " Un queso muy sabroso y aromático gracias al proceso de ahumado natural con un\n" +
               " blaind de madera completamente natural, al que se le somete creando un queso con \n" +
               "mucho carácter que hará las delicias de los aﬁcionados a la comida ahumada.\n";
    }

    public static string noteToCowCheese()
    {
        return "Corteza natural dura enmohecida de color blanquecino.\n" +
               "Interior amarillento, pasta cremosa y con poca presencia de ojos. Puede presentar textura\n" +
               " errática, con bordes ligeramente más blandos debido a la elaboración artesanal y el \n" +
               "tratado natural.Cremoso y mantecoso, de sabor intenso con retrogusto ligeramente ácido.\n";
    }
}
