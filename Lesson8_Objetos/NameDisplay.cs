using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class NameDisplay
{
    string name; // propiedad o atributo
    bool speakerOn;
    static int displayCount = 0;

    const string DEFAULT_DISPLAY_NAME = "TU NOMBRE";

    public NameDisplay() // método
    //Constructor por defecto. Está especificado de manera explicita
    // El constructor siempre tiene el mismo nombre de la clase.
    // El constructor no tiene tipo de retorno!
    // El constructor suele ser public, pero no tiene por qué serlo siempre.
    {
        this.name = NameDisplay.DEFAULT_DISPLAY_NAME;
        this.speakerOn = false;
        NameDisplay.displayCount++;
    }

    public NameDisplay(string name)
    {
        this.name = name;
        this.speakerOn = false;
        NameDisplay.displayCount++;
    }

    public string getName()
    {
        return this.name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void sayName()
    {
        turnSpeakerOn();
        Console.WriteLine("EL nombre es " + this.name);
        turnSpeakerOff();
    }

    private void turnSpeakerOn()
    {
        Console.WriteLine("Encendiendo el altavoz");
        this.speakerOn = true;
    }

    public static int getDisplayCount()
    {
        return NameDisplay.displayCount;
    }

    private void turnSpeakerOff()
    {
        Console.WriteLine("Apagando el altavoz");
        this.speakerOn = false;
    }

    public string getStatus()
    {
        string speakerStatus = this.speakerOn ?
            " y el altavoz está encendido"
            : " y el altavoz está apagado";

        return "El visor tiene el nombre de "
            + this.name + speakerStatus;
    }

}
