using System.Xml.Linq;
using System.Linq;


namespace Lab__1___C__Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string filePath = projectFolder + Path.DirectorySeparatorChar + "videogames.csv";
            List<Videogame> gamelist = new List<Videogame>();

            using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {

                    string? line = sr.ReadLine();

                    string[] lineElements = line.Split(',');


                    Videogame g = new Videogame()
                    {
                        Name = lineElements[0].Trim(),
                        Platform = lineElements[1].Trim(),
                        Year = lineElements[2].Trim(),
                        Genre = lineElements[3].Trim(),
                        Publisher = lineElements[4].Trim(),
                        NA_Sales = lineElements[5].Trim(),
                        EU_Sales = lineElements[6].Trim(),
                        JP_Sales = lineElements[7].Trim(),
                        Other_Sales = lineElements[8].Trim(),
                        Global_Sales = lineElements[9].Trim()
                    };

                    gamelist.Add(g);
                }
            }
            gamelist.Sort();
            foreach (var g in gamelist) Console.WriteLine(g);
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
            Console.Clear();


            /*var specPub = gamelist.Where(pub => pub.Publisher == "Ubisoft");
            foreach (var item in specPub)
            {
                Console.WriteLine(item);
            }


            var specGen = gamelist.Where(gen => gen.Genre == "Action");
            foreach (var item in specGen)
            {
                Console.WriteLine(item);
            }*/

            var gamePub = gamelist.Where(g => g.Publisher == "Ubisoft");
            foreach (var pub in gamePub)
            {
                Console.WriteLine(pub.ToString());
            }

            double NumPub = gamePub.Count();

            var pct = Math.Round((NumPub / (double)gamelist.Count) * 100, 2);
            Console.WriteLine(pct);

            Console.WriteLine($"There are {NumPub} Ubisoft out of {gamelist.Count()} which is {pct:0.##}%");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
            Console.Clear();

            var gameGen = gamelist.Where(g => g.Genre == "Simulation");
            foreach (var gen in gameGen)
            {
                Console.WriteLine(gen.ToString());
            }

            double numGen = gameGen.Count();

            var genPerc = Math.Round((numGen / (double)gamelist.Count()) * 100, 2);
            Console.WriteLine(genPerc);

            Console.WriteLine($"There are {numGen} Simulation games out of {gamelist.Count()} which is {genPerc:0.##}%");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter the publisher you'd like to search for: ");
            string type = Console.ReadLine().Trim();

            var gamePubl = gamelist.Where(g => g.Publisher == type);
            foreach (var publ in gamePubl)
            {
                Console.WriteLine(publ.ToString());
            }

            double numPub = gamePubl.Count();

            var pubPerc = Math.Round((NumPub /(double) gamelist.Count) * 100, 2);
            Console.WriteLine(pubPerc);

            Console.WriteLine($"There are {NumPub} {type} out of {gamelist.Count()} which is {pubPerc:0.##}%");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter the Genre you'd like to search for: ");
            string type1 = Console.ReadLine().Trim();

            var gameGens = gamelist.Where(g => g.Genre == type1);
            foreach (var genr in gameGens)
            {
                Console.WriteLine(genr.ToString());
            }

            double numType1 = gameGens.Count();

            var pct1 = Math.Round(( numType1 / (double) gamelist.Count()) * 100, 2);
            Console.WriteLine(pct1);

            Console.WriteLine($"There are {numType1} {type1} out of {gamelist.Count()} which is {pct1:0.##}%");
        }
    }
}