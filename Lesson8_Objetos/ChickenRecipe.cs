using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

/// <summary>
/// * Queremos hacer una clase que nos gestione las recetas para nuestro
/// caldo de pollo.
/// - El caldo tendrá un listado de ingredientes asociado de como
/// máximo 10 ingredientes.
/// - El caldo podrá tener o no "sustancia".
/// - El caldo empezará sin ingredientes ni sustancia y se le podrán ir
/// añadiendo ingredientes.
/// - El caldo tendrá un número de ingredientes a partir del cual se 
/// considererá que tiene sustancia, que el propio caldo de pollo 
/// "conocerá" de si mismo ya cuando se cree.
/// - Que el caldo tenga sustancia se cambiará solo cuando se llegue al
/// número de ingredientes apropiado. No se podrá cambiar que el caldo
/// tiene o no sustancia directamente, solo a través de añadir ingredientes.
/// - Se podrá pedir al caldo que nos diga la receta, lo que incluirá 
/// si tiene sustancia o no, devuelto como string.
/// NOTA: Si hace falta alguna propiedad más para resolver el ejercicio, añadirla.
/// </summary>
public class ChickenRecipe
{
    string[] ingredients;
    int ingredientCounter;
    bool substance;

    public ChickenRecipe()
    {
        this.ingredients = new string[10];
        this.substance = false;
        this.ingredientCounter = 0;
    }
     
    public void addIngredient(string ingredient)
    {
        if (this.ingredientCounter < 10)
        {
            this.ingredients[this.ingredientCounter] = ingredient;
            this.ingredientCounter++;
        }

        checkIfSusbtance();
    }

    private void checkIfSusbtance()
    {
        if (this.ingredientCounter >= 7) this.substance = true;
    }

    public string hasSusbtance()
    {
        string withSustance = (this.substance) ? "Tiene sustancia" : "No tiene sustancia";

        return withSustance;
    }

    public string recipe()
    {
        string recipe = "";

        for (int i = 0; i < this.ingredientCounter; i++)
        {
            recipe += this.ingredients[i] + "\n";
        }
        recipe += "\n" + hasSusbtance();

        return recipe;
    }
}
