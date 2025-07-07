using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;
/// * Crea la clase EquipoFutbol.
///  Atributos: 
///           - string name - string goalKeeper - string defense - string midfielder - string striker
///           - bool inChampions - bool inCup
///           - int yearFounded
///  Metodos:
///           - Metodo showTeamData, muestra por pantalla todos los atributos del menu.
///           - Para los atributos tipo boolean, mostrar un mensaje apropiado, no el valor booleano directamente
public class FootballTeam
{
    string name;
    string goalKeeper;
    string defense;
    string midfielder;
    string striker;
    
    int yearFounded;

    bool inChampions;
    bool inCup;

    public FootballTeam(string teamName, string goalKeeper, string defense, string midfielder,
                        string striker, int yearFounded, bool inChampions, bool inCup)
    {
        this.name = teamName;
        this.goalKeeper = goalKeeper;
        this.defense = defense;
        this.midfielder = midfielder;
        this.striker = striker;
        this.yearFounded = yearFounded;
        this.inCup = inCup;
        this.inChampions = inChampions;
    }

    public void showTeamData()
    {
        string teamData = $"Team name: {this.name}\n GoalKeeper: {this.goalKeeper}\n " +
                          $"Defense: {this.defense}\n Midfielder: {this.midfielder}\n " +
                          $"Striker: {this.striker}\n Year Founded: {this.yearFounded}\n ";

        string isInCup = this.inCup ?
                         "Is playing the Cup\n"
                        :"Is not playing the Cup\n";
        
        string isInChampions = this.inChampions ?
                               "Is playing Champions\n"
                              :"Is not playing Champions\n";

        Console.WriteLine(teamData + isInCup + isInChampions);
            
    }

}
