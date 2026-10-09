using System;

class Film
{
    public string Title;
    public int Year;
    public double Rating;
    public bool Watched;

    public Film(string title, int year)
        : this(title, year, 0, false)
    {
    }

    public Film(string title, int year, double rating)
        : this(title, year, rating, false)
    {
    }

    public Film(string title, int year, double rating, bool watched)
    {
        Title = title;
        Year = year;
        Rating = rating;
        Watched = watched;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Филм: " + Title);
        Console.WriteLine("Година: " + Year);
        Console.WriteLine("IMDb оценка: " + Rating);
        ShowWatched();
    }

    public void ShowWatched()
    {
        if (Watched)
        {
            Console.WriteLine("Гледан: Да");
        }
        else
        {
            Console.WriteLine("Гледан: Не");
        }
    }

    public virtual void Play()
    {
        Console.WriteLine("Филмът стартира!");
    }
}
