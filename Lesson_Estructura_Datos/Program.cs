namespace Lesson_Estructura_Datos;

public class Program
{
    static void Main(string[] args)
    {
        //Director quentin = new Director("Quentin Tarantino", 10);

        //Actor samuel = new Actor("Samuel L. Jackson", Genre.ACCION);
        //Actor pitt = new Actor("Brad Pitt", Genre.ACCION);
        //Actor dicaprio = new Actor("Leonardo Di Caprio", Genre.THRILLER);
        //Actor waltz = new Actor("Christoph Waltz", Genre.BELICO);
        //Actor cage = new Actor("Nicolas Cage", Genre.ACCION);

        //Movie django = new Movie("Django unchained", 9, 165, Genre.ACCION, quentin);
        //django.addActor(samuel);
        //django.addActor(dicaprio);
        //django.addActor(waltz);

        //Movie basterds = new Movie("Inglourious Basterds", 8, 153, Genre.BELICO, quentin);
        //basterds.addActor(pitt);
        //basterds.addActor(waltz);

        //Movie hollywood = new Movie("Once Upon a Time in Hollywood", 7, 146, Genre.DRAMA, quentin);
        //hollywood.addActor(pitt);
        //hollywood.addActor(dicaprio);

        //Movie pulp = new Movie("Pulp Fiction", 9, 154, Genre.ACCION, quentin);
        //pulp.addActor(cage);
        //pulp.addActor(samuel);

        //Catalogue catalogo = new Catalogue();
        //catalogo.addmovie(django);
        //catalogo.addmovie(basterds);
        //catalogo.addmovie(hollywood);
        //catalogo.addmovie(pulp);

        //catalogo.getMovieInfo(hollywood.getTitle());
        //List<Movie> movies = catalogo.getMoviesByRating(8);
       
        //foreach(Movie movie in movies)
        //{
        //    Console.WriteLine(movie.getMovieInfo());
        //}

        //List<Movie> moviesByActor = catalogo.getMoviesByActorName(samuel.getName());

        //foreach (Movie movie in moviesByActor)
        //{
        //    Console.WriteLine(movie.getMovieInfo());
        //}

        //Console.WriteLine(catalogo.getCatalogueStats());
        
        VideoClub club = new VideoClub();

        club.Main();
    }

    


}
