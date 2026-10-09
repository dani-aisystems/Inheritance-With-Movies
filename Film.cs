using System;

class Film
{
    public string Title;
    public int Year;
    public double Rating;
    public string Genre;
    public string Director;
    public int DurationMinutes;
    public bool Watched;

    public Film(string title, int year)
        : this(title, year, 0, "Няма информация", "Няма информация", 0, false)
    {
    }

    public Film(string title, int year, double rating)
        : this(title, year, rating, "Няма информация", "Няма информация", 0, false)
    {
    }

    public Film(string title, int year, double rating, bool watched)
        : this(title, year, rating, "Няма информация", "Няма информация", 0, watched)
    {
    }

    public Film(string title, int year, double rating, string genre,
        string director, int durationMinutes, bool watched)
    {
        Title = title;
        Year = year;
        Rating = rating;
        Genre = genre;
        Director = director;
        DurationMinutes = durationMinutes;
        Watched = watched;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Филм: " + Title);
        ShowCommonInfo();
        ShowWatched();
    }

    public void ShowCommonInfo()
    {
        Console.WriteLine("Година: " + Year);
        Console.WriteLine("Жанр: " + Genre);
        Console.WriteLine("Режисьор: " + Director);

        if (DurationMinutes > 0)
        {
            Console.WriteLine("Продължителност: " + DurationMinutes + " минути");
        }
        else
        {
            Console.WriteLine("Продължителност: Няма информация");
        }

        if (Rating > 0)
        {
            Console.WriteLine("IMDb оценка: " + Rating);
        }
        else
        {
            Console.WriteLine("IMDb оценка: Няма информация");
        }
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
