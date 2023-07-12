using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameTitles = new List<string>
                {
                    "Super Mario",
                    "Animal Crossing: New Horizons",
                    "Final Fantasy VII Remake",
                    "Minecraft",
                    "Grand Theft Auto V"
                };

            string linqResult = VideoGameTitles(gameTitles);
            Console.WriteLine(linqResult);



        }

        public static string VideoGameTitles(List<string> gameTitles) 
        {
            gameTitles = gameTitles.OrderByDescending(x => x).ToList();
            return string.Join(", " , gameTitles) ;

            //int numberOfGames = gameTitles.Count();
            //return numberOfGames.ToString();

            //gameTitles = gameTitles.Where(title => title.Contains("l")).ToList();
            //return string.Join(", ", gameTitles);

            
        }
    }
}
