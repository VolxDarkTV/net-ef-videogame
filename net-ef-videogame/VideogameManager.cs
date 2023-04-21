using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    internal static class VideogameManager
    {
        public static void AddElement(string nameGame, string descriptionGame, int idSoftwareHouse)
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Add data...");

            VideoGame videoGame = new VideoGame { Name = nameGame, Overview = descriptionGame, Software_houseId = idSoftwareHouse };
            db.Add(videoGame);
            db.SaveChanges();
        }

        public static void PrintElement()
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Print data...");

            List<Software_house> software = db.Software_House.OrderBy(software => software.Id).ToList<Software_house>();
            
            foreach (Software_house softwareItem in software)
            {
                Console.WriteLine($"\t{softwareItem.Id} \t {softwareItem.Name}");
            }
            Console.WriteLine("Select Your SoftwareHouse: ");

        }

        public static void SearchIdGames(int idGame)
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Print data...");

            List<VideoGame> videogame = db.VideoGame.Where(videogame => videogame.Id == idGame).ToList<VideoGame>();

            foreach (VideoGame videoGame in videogame)
            {
                Console.WriteLine($"\t {videoGame.Id} \t {videoGame.Name}");
            }
        }

        public static void SearchGames(string nameGame)
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Print data...");

            List<VideoGame> videogame = db.VideoGame.Where(videogame => videogame.Name.ToLower() == nameGame.ToLower()).ToList<VideoGame>();

            foreach (VideoGame videoGame in videogame)
            {
                Console.WriteLine($"\t {videoGame.Id} \t {videoGame.Name}");
            }
        }
    }
}
