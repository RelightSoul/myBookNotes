using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.LinqUsingEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void QueryStringWithOperators()
        {
            Console.WriteLine("***** Useing Query Operators *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2" };
            var subset = from game in currentVideoGames
                         where game.Contains(" ")
                         orderby game
                         select game;
            foreach (string g in subset)
            {
                Console.WriteLine("Item: {0}", g);
            }
        }
        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2" };
            var subset = currentVideoGames.Where(game=>game.Contains(" "))
                .OrderBy(game=>game).Select(game=>game);
            foreach (var game in subset)
            {
                Console.WriteLine("Item {0}",game);
            }
        }
        static void QueryStringsWithEnumerableAndLambdas2()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2" };
            var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);
            foreach (var game in subset)
            {
                Console.WriteLine("Item {0}", game);
            }
        }
        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2" };
            // Построить необходимые делегаты Funco с использованием анонимных методов.
            Func<string, bool> searchFilter =
                delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess =
                delegate (string s) { return s; };
            // Передать делегаты в методы класса Enumerable.
            var subset = currentVideoGames.Where(searchFilter)
                .OrderBy(itemToProcess).Select(itemToProcess);
            foreach (var game in subset)
            {
                Console.WriteLine(game);
            }
        }
    }
}
