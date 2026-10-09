using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Film> films = new List<Film>();

        films.Add(new Film("The Shawshank Redemption", 1994, 9.3,
            "Drama", "Frank Darabont", 142, true));

        films.Add(new ActionFilm("Gladiator", 2000, 8.5,
            "Action, Adventure, Drama", "Ridley Scott", 155, true, 15));

        films.Add(new ComedyFilm("Back to the Future", 1985, 8.5,
            "Adventure, Comedy, Sci-Fi", "Robert Zemeckis", 116, false,
            "Michael J. Fox"));

        films.Add(new SuperheroFilm("The Dark Knight", 2008, 9.1,
            "Action, Crime, Drama", "Christopher Nolan", 152, true, 18,
            "Batman"));

        foreach (Film film in films)
        {
            film.ShowInfo();
            film.Play();
            Console.WriteLine("----------");
        }
    }
}
