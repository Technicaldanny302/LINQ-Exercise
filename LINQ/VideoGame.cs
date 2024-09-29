using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class VideoGame
    {
        public static void Games()
        {
            List<string> allGames = new List<string>() { "HALO", "COD", "MARIO" };

            var games = allGames.OrderBy(game => game.Length);

            foreach (var game in games)
            {
                Console.WriteLine(game); 
            }
        }
        

    }
}
