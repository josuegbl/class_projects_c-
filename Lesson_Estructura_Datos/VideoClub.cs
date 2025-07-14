using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;
/// <summary>
/// **Queremos simular el funcionamiento de un antiguo videoclub.
///  
/// - El videoclub tendrá una serie de pelis disponibles en catalogo.
/// - Cada peli tendrá un nombre, un género, stock disponible para 
/// alquiler y si es novedad o no.
/// 
/// - Las pelis estarán almacenadas en un fichero, que se cargará:
///   - Al iniciar la aplicacion
///   - Cada vez que se añada una peli.
/// 
/// - El sistema mostrará un menú en el que cualquier usuario podrá:
///   - Ver las pelis disponibles para alquilar en un listado.
///   - Alquilar una peli disponible (usando su título; se 
///   almacenarán los alquileres en un fichero usando el título de la
///   peli y el precio.
///   - Devolver una peli alquilada (usando su titulo; se pondrá 
///   disponible una vez devuelta y se borrará el alquiler del fichero 
///   de alquileres)
///   - Identificarse como admin (se pedirá un nombre de usuario y passwd)
///   - Salir.
/// 
/// El sistema contará con usuarios admin, que tendrán un nombre de usuario
/// y passwd, almacenados en un fichero.
/// 
/// - SI el usuario se identifica correctamente como admin, se añadirán
/// además al menú las opciones:
///   - Añadir una peli asociada y un precio.
///   - El precio de 3€ para pelis normales y de 5€ para novedades.
///   - Si una peli ya está alquilada y no hay stock, no se podrá 
///   alquilar y no se mostrará en el catálogo de disponibles (pero si 
///   en los alquileres).
/// 
/// </summary>

public class VideoClub
{
    List<Film> movies;

    public VideoClub(List<Film> movies)
    {
        this.movies = movies;
    }
}
