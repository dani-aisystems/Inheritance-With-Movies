using System;

class ComedyFilm : Film
{
    public string MainActor;

    public ComedyFilm(string title, int year, double rating, string mainActor)
        : base(title, year, rating)
    {
        MainActor = mainActor;
    }

    public ComedyFilm(string title, int year, double rating, string mainActor, bool watched)
        : base(title, year, rating, watched)
    {
        MainActor = mainActor;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Комедиен филм: " + Title);
        Console.WriteLine("Година: " + Year);
        Console.WriteLine("IMDb оценка: " + Rating);
        Console.WriteLine("Главен актьор: " + MainActor);
        ShowWatched();
    }

    public override void Play()
    {
        Console.WriteLine("Комедийният филм стартира!");
    }
}
