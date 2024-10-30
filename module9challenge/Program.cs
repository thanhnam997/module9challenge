using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creating a list of Video Games
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Resident Evil 5", Genre = "Survival Horror", Rating = 4});
            games.Add(new VideoGame { Name = "Stardew Valley", Genre = "Cozy Game", Rating = 3.2});
            games.Add(new VideoGame { Name = "My Time at Portia", Genre = "Adventure", Rating = 3.5});
            games.Add(new VideoGame { Name = "Cult of the Lamb", Genre = "Dungeon Crawl", Rating = 4});
            games.Add(new VideoGame { Name = "Baldur's Gate 3", Genre = "Role Playing Game", Rating = 5}); 
        

            //Use a LINQ query to create a new list that only contains games with a rating of 4 or higher
            var topRatedGames = (from game in games
                              where game.Rating >= 4
                              select game).ToList();
        
            //Use orderby LINQ query to sort by game name
            var sortedGames = (from game in topRatedGames
                            orderby game.Name
                            select game).ToList();
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}
