using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.LinqOverArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ to Objects");
            QueryOverStrings();
            Console.WriteLine();
            QueryOverStringWithExtensionMethods();
            QueryOverStringLongHard();
            Console.WriteLine();
            QueryOverInts();
            Console.ReadLine();
        }
        static void QueryOverStrings()
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3","Daxter","System Shock 2"};
            IEnumerable<string> subset = from game in currentVideoGames
                                         where game.Contains(" ")
                                         orderby game
                                         select game;
            ReflectOverQueryResults(subset);
            foreach (string s in subset)
            {
                Console.WriteLine(s);
            }
        }
        static void QueryOverStringWithExtensionMethods()
        {
            string[] currentVideoGames = {"Morrowind","Uncharted 2","Fallout 3",
                    "Daxter","System Shock 2"};
            IEnumerable<string> subset =
                currentVideoGames.Where(game=>game.Contains(" ")).OrderBy(g=>g).Select(g=>g);
            ReflectOverQueryResults(subset, "Extension Methods");
            foreach (string s in subset)
            {
                Console.WriteLine(s);
            }
        }
        static void QueryOverStringLongHard()
        {
            string[] currentVideoGames = {"Morrowind","Uncharted 2","Fallout 3",
                    "Daxter","System Shock 2"};
            string[] gamesWithSpaces = new string[currentVideoGames.Length];
            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                    gamesWithSpaces[i] = currentVideoGames[i];                
            }
            Array.Sort(gamesWithSpaces);
            foreach (string s in gamesWithSpaces)
            {
                Console.WriteLine(s);
            }
        }
        static void ReflectOverQueryResults 
            (object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"***** Info about your query using {queryType} *****");
            Console.WriteLine("resultSet is of type: {0}",resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", 
                resultSet.GetType().Assembly.GetName().Name);
        }
        static void QueryOverInts()
        {
            int[] nubmers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // Здесь используется неявная типизация
            var subset = from i in nubmers where i < 10 select i;
            foreach (var i in subset)
            {
                Console.WriteLine("{0} < 10",i);                
            }
            Console.WriteLine();
            nubmers[0] = 4;
            foreach (var j in subset)
            {
                Console.WriteLine("{0} < 10", j);
            }
            ReflectOverQueryResults(subset);
        }
        static void ImmediateExecution()
        {
            int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8 };
            //Получить данные НЕМЕДЛЕННО как int[]
            int[] subsetAsIntArray = 
                (from i in numbers where i < 10 select i).ToArray<int>(); 
            //Получить данные НЕМЕДЛЕННО как List<int>
            List<int> subsetAsListOfInts =
                (from i in numbers where i <10 select i).ToList<int>();
        }
    }
    class LINQBasedFieldsAreClunky
    {
        private static string[] currentVideoGames = {"Morrowind","Uncharted 2","Fallout 3",
                    "Daxter","System Shock 2"};
        // В классе, задавая поля, нельзя использовать неявную типизацию!
        // Тип subset должен быть известен и целью запроса LINQ не могут быть
        // данные уровня экземпляра, а потому он должен быть статическим
        private IEnumerable<string> subset = from g in currentVideoGames
                                             where g.Contains(" ")
                                             orderby g
                                             select g;
        public void PrintGames()
        {
            foreach (var g in subset)
            { 
                Console.WriteLine(g); 
            }
        }
    }
}
