using Microsoft.EntityFrameworkCore;
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

        public static void PrintElementSoftware()
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Print software house data...");

            List<Software_house> software = db.Software_House.OrderBy(software => software.Id).ToList<Software_house>();
            
            foreach (Software_house softwareItem in software)
            {
                Console.WriteLine($"\t{softwareItem.Id} \t {softwareItem.Name}");
            }
            Console.WriteLine("Select Your SoftwareHouse: ");

        }
        public static void PrintElementVideogames()
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Print VideoGames data...");

            List<VideoGame> videogame = db.VideoGame.OrderBy(videogame => videogame.Id).ToList<VideoGame>();

            foreach (VideoGame videoGameItem in videogame) 
            {
                Console.WriteLine($"\t{videoGameItem.Id} \t {videoGameItem.Name}");
            }
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

        public static void DeleteGames(int idNum)
        {
            using VideogameContext db = new VideogameContext();
            //Console.WriteLine("Print VideoGames...");

            //List<VideoGame> videogame = db.VideoGame.ToList<VideoGame>();

            //foreach (VideoGame videoGame in videogame)
            //{
            //    Console.WriteLine($"\t {videoGame.Id} \t {videoGame.Name}");
            //}

            Console.WriteLine("Select id Games to Delete !!!PERMANENTLY!!!");

            var game = db.VideoGame.Find(idNum);

            if(game != null )
            {
                db.Remove(game);
                Console.WriteLine($"E' stato rimosso: \t id: {game.Id} \t Nome: {game.Name}");
            }
            else
            {
                Console.WriteLine("Game Not Found!");
            }
            db.SaveChanges();
        }

        public static void AddSoftwareHouse(string name, int taxId, string city)
        {
            using VideogameContext db = new VideogameContext();
            Console.WriteLine("Add data...");

            Software_house software = new Software_house { Name =  name, tax_id = taxId, City = city};
            db.Add(software);
            db.SaveChanges();
        }
    }
}
