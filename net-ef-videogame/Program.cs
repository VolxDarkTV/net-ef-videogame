namespace net_ef_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using VideogameContext db = new VideogameContext();
            //Console.WriteLine("Aggiungo i dati...");

            //Software_house software_Houses = new Software_house { Name = "Ubisoft", tax_id = 1, City = "Montreuil"};
            //db.Add(software_Houses);
            //db.SaveChanges();

            bool exitProgram = false;
            while (!exitProgram) 
            {
                Console.WriteLine("\t Seleziona un operazione digitando il numero corrispondente");

                Console.WriteLine("\t (1)    inserire un nuovo videogioco");
                Console.WriteLine("\t (2)    ricercare un videogioco per id");
                Console.WriteLine("\t (3)    ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input");
                Console.WriteLine("\t (4)    cancellare un videogioco");
                Console.WriteLine("\t (5)    chiudere il programma");

                int selector = Convert.ToInt32(Console.ReadLine());
                switch (selector)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Name: ");
                            string nameGame = Console.ReadLine();
                            Console.WriteLine("Description: ");
                            string descriptionGame = Console.ReadLine();
                            VideogameManager.PrintElementSoftware();
                            int idSoftwareHouse = Convert.ToInt32(Console.ReadLine());
                            VideogameManager.AddElement(nameGame, descriptionGame, idSoftwareHouse);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Search for GameID: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            VideogameManager.SearchIdGames(num);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Search for GameName: ");
                            string name = Console.ReadLine();
                            VideogameManager.SearchGames(name);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            VideogameManager.PrintElementVideogames();
                            Console.WriteLine("Delete: ");
                            int idNum = Convert.ToInt32(Console.ReadLine());
                            VideogameManager.DeleteGames(idNum);
                            VideogameManager.PrintElementVideogames();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 5:
                    
                        break;
                }
                
            }
        }
    }
}