class Program
{
    static void Main()
    {
        try
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

                // TEST NORMAL
                video.IncreasePlayCount(100);

                user.AddVideo(video);
            }

            // TEST ERROR (Precondition)
            try
            {
                SayaTubeVideo errorVideo = new SayaTubeVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            // TEST OVERFLOW
            SayaTubeVideo overflowVideo = new SayaTubeVideo("Test Overflow");
            for (int i = 0; i < 1000000; i++)
            {
                overflowVideo.IncreasePlayCount(25000000);
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi error: " + e.Message);
        }
    }
}