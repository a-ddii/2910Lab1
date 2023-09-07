using System.Security.Cryptography;
using System;
using System.Xml.Linq;

namespace Lab__1___C__Review
{
    public class Videogame : IComparable<Videogame>
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string NA_Sales { get; set; }
        public string EU_Sales { get; set; }
        public string JP_Sales { get; set; }
        public string Other_Sales { get; set; }
        public string Global_Sales { get; set; }

        public Videogame(string name, string platform, string genre, string publisher, string nA_Sales, string eU_Sales, string jP_Sales, string other_Sales, string global_Sales)
        {
            Name = name;
            Platform = platform;
            Genre = genre;
            Publisher = publisher;
            NA_Sales = nA_Sales;
            EU_Sales = eU_Sales;
            JP_Sales = jP_Sales;
            Other_Sales = other_Sales;
            Global_Sales = global_Sales;
        }

        public Videogame() { }
        public int CompareTo(Videogame? other)
        {

            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            string videogameString = "";
            videogameString += $"Name: {Name}\n";
            videogameString += $"Platform: {Platform}\n";
            videogameString += $"Genre: {Genre}\n";
            videogameString += $"Publisher: {Publisher}\n";
            videogameString += $"North America: {NA_Sales}\n";
            videogameString += $"Europe Sales: {EU_Sales}\n";
            videogameString += $"Japan Sales: {JP_Sales}\n";
            videogameString += $"Other Sales: {Other_Sales}\n";
            videogameString += $"Global Sales: {Global_Sales}\n";

            videogameString += $"---------------------------------------------------------------";

            return videogameString;
        }
    }
}
