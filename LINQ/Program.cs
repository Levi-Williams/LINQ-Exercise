using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameList = new List<string>();

            videoGameList.Add("Dark Souls");
            videoGameList.Add("Elden Ring");
            videoGameList.Add("Stardew");
            videoGameList.Add("Minecraft");
            videoGameList.Add("League of Legends");

            var organizedList = videoGameList.OrderByDescending(name => name.Length);

           foreach(var game in organizedList) { Console.WriteLine(game); }

        }
    }
}
