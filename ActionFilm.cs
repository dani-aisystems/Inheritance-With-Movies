using System;

class ActionFilm : Film
{
    public int Explosions;

    public ActionFilm(string title, int year, int explosions)
        : base(title, year)
    {
        Explosions = explosions;
    }

    public ActionFilm(string title, int year, double rating, int explosions)
        : base(title, year, rating)
    {
        Explosions = explosions;
    }

    public ActionFilm(string title, int year, double rating, int explosions, bool watched)
        : base(title, year, rating, watched)
    {
        Explosions = explosions;
    }

    public ActionFilm(string title, int year, double rating, string genre,
        string director, int durationMinutes, bool watched, int explosions)
        : base(title, year, rating, genre, director, durationMinutes, watched)
    {
        Explosions = explosions;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Екшън филм: " + Title);
        ShowCommonInfo();
        Console.WriteLine("Брой екшън сцени: " + Explosions);
        ShowWatched();
    }

    public override void Play()
    {
        Console.WriteLine("Екшън филмът стартира!");
    }
}
