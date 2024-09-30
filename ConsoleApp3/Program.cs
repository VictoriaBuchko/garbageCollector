using System.ComponentModel;
using System.Reflection.Metadata;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task1");
            Film myFilm = new Film("Володар перснів", "New Line Cinema", "Фентезі", 228, 2003);
            myFilm.DisplayInfo();

            myFilm.Title = "Термінатор"; 
            myFilm.Studio = "Orion Pictures";
            myFilm.Genre = "Наукова фантастика"; 
            myFilm.Duration = 107; 
            myFilm.Year = 1984; 

            Console.WriteLine("Після змін:");
            myFilm.DisplayInfo();


            Console.WriteLine("\nTask2");
            Play play = new Play("Ромео і Джульєтта", "Театр юного глядача", "Трагедія", 150, new List<string> { "Актор 1", "Актор 2" });
            play.DisplayInfo();

            play.Title = "Гамлет";
            play.Theater = "Національний театр";
            play.Genre = "Трагедія";
            play.Duration = 120;
            play.Actors = new List<string> { "Актор 3", "Актор 4" };

            play.DisplayInfo();
            play.Dispose();
            

        }
    }
}
