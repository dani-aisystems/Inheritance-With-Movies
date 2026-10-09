using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Film> films = new List<Film>();

        films.Add(new Film("The Shawshank Redemption", 1994, 9.3, true));
        films.Add(new ActionFilm("Gladiator", 2000, 8.5, 15, true));
        films.Add(new ComedyFilm("Back to the Future", 1985, 8.5, "Michael J. Fox", false));
        films.Add(new SuperheroFilm("The Dark Knight", 2008, 9.1, 18, "Batman", true));

        foreach (Film film in films)
        {
            film.ShowInfo();
            film.Play();
            Console.WriteLine("----------");
        }
    }
}
