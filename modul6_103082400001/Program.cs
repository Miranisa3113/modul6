class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Mira");

        string[] film = {
            "Venom", "Minions", "Interstellar", "Titanic",
            "Frozen", "Joker", "Spiderman", "Batman",
            "Harry Potter", "Parasite"
        };

        foreach (var f in film)
        {
            SayaTubeVideo video = new SayaTubeVideo("Review Film " + f + " oleh Mira");
            video.IncreasePlayCount(100);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());
    }
}
