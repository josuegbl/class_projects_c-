using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;
/// <summary>
/// Queremos modelar una elaboracion de quesos monovariedad de leche.
/// Todos los quesos tienen una variedad de leche, una nota de cata 
/// y un porcentaje de contenido graso. Según el tip de leche que se use,
/// ese porcentaje de contenido graso variará. Además de todos los quesos
/// se podrá obtener un índice de contenido graso, que podrá ser A, B o C.
/// según su porcentaje de grasa sea menor o igual al 25%, menor o igual al 
/// 50 % o mayor al 50 %, respectivamente.
/// 
/// Habrá tres tipos de quesos: de leche de cabra, de leche de oveja y de leche de vaca.
/// 
/// El queso de cabra no tiene particularidades además de las ya descritas.
/// 
/// El queso de oveja tiene una particularidad: la leche de oveja puede 
/// ser de varios tipos de oveja (churras, merinas...) y según la leche que 
/// sea esto modificará la nota de cata, añadiendole matices que dependerán
/// del tipo de oveja,devolverá el matiz que hay que aplicar a la nota de
/// cata (hay que hacer este otro  código también).
/// 
/// El queso de vaca tiene una particularidad: según el tiempo en días que 
/// haya transcurrido desde que se haya ordeñado la leche, esta modificará
/// la nota de cata, añadiendole matices. Cada queso de vaca "sabrá", en base
/// a este tiempo, qué matiz añadir a la nota de cata.
/// 
/// Crear un queso de cada tipo y mostrar su indice de contenido graso y su nota de cata.
/// </summary>

public class Cheese : Product
{
    protected char fatClassification;

    public Cheese(string cheeseType, int amount, int fatPercentage)
        : base(cheeseType, amount)
    {
        this.fatClassification = getFatClassification(fatPercentage);
    }

    private char getFatClassification(int fatPercentage)
    {
        char classifier;
        if (fatPercentage <= 25)
        {
            classifier = 'A';
        }
        else if (fatPercentage <= 50)
        {
            classifier = 'B';
        }
        else
        {
            classifier = 'C';
        }
            return classifier;
    }

    public override string ToString()
    {
        return $"Queso: {this.getName()} \nÍndíce graso: {this.fatClassification}\n";
    }


}
