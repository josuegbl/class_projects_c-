using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;
/// <summary>
///  Queremos hace run modelado de jugadores de baloncesto.
///  Todos los jugadores de basket tendrán un nombre y 
///  pertenecerán a un equipo. Los jugadores de basket
///  pueden ser atacantes o defensores, no ambos a la vez, 
///  y tendrán  un comportamiento apropiado a cada tipo definido.
///  Todos los jugadores de basket podrán mostrar su información,
///  pero solo los atacantes podrán atacar y los defensores 
///  defender.
///  Crear un atacante, hacerlo atacar y mostrar sus datos y crear
///  un defensor y hecerlo defender y mostrar sus datos.
/// </summary>

public class Player
{
    protected string name;
    protected string team;

    public Player(string name, string team)
    {
        this.name = name;
        this.team = team;
    }

    public override string ToString()
    {
        return $"Team: {this.team}\nName: {this.name}";
    }
}
