using System;

class SuperheroFilm : ActionFilm
{
    public string Superhero;

    public SuperheroFilm(string title, int year, double rating, int explosions, string superhero)
        : base(title, year, rating, explosions)
    {
        Superhero = superhero;
    }

    public SuperheroFilm(string title, int year, double rating, int explosions, string superhero, bool watched)
        : base(title, year, rating, explosions, watched)
    {
        Superhero = superhero;
    }

    public SuperheroFilm(string title, int year, double rating, string genre,
        string director, int durationMinutes, bool watched, int explosions, string superhero)
        : base(title, year, rating, genre, director, durationMinutes, watched, explosions)
    {
        Superhero = superhero;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Супергеройски филм: " + Title);
        ShowCommonInfo();
        Console.WriteLine("Брой екшън сцени: " + Explosions);
        Console.WriteLine("Супергерой: " + Superhero);
        ShowWatched();
    }

    public override void Play()
    {
        Console.WriteLine("Супергеройският филм стартира!");
    }
}
