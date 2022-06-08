using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63.FunWithLinqExpressions
{
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        public override string ToString()
        {
            return $"Name = {Name}, Decription = {Description}," +
                $" Number in Stock = {NumberInStock}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");
            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo{ Name= "Mac's Coffee",
                    Description="Coffee with TEETH",NumberInStock=24},
                new ProductInfo{ Name= "Milk Maid Milk",
                    Description="Milk cow's love",NumberInStock=100},
                new ProductInfo{ Name="Pure Silk Tofu",
                    Description="Bland as Possible",NumberInStock=120},
                new ProductInfo{ Name="Crunchy Pops",
                    Description="Creezy, peppery goodness",NumberInStock=2},
                new ProductInfo{ Name="RipOff Water",
                    Description="From the tap to your wallet",NumberInStock=100},
                new ProductInfo{ Name="Classic Valpo Pizza",
                    Description="Everyone loves pizza!",NumberInStock=73}
            };
            SelectEverything(itemsInStock);
            Console.WriteLine();
            GetOverstock(itemsInStock);
            Console.WriteLine();
            GetNamesAndDrescriptions(itemsInStock);
            Console.WriteLine();
            GetProjectedSubset(itemsInStock);
            Console.WriteLine("ProjectedSubset");
            foreach (object i in itemsInStock)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            GetCoundFromQuery();
            Console.WriteLine();
            ReverseEverything(itemsInStock);
            Console.WriteLine();
            AlphabetizeProductNames(itemsInStock);
            Console.WriteLine();
            DisplayDiff();
            Console.WriteLine();
            DisplayIntersection();
            Console.WriteLine();
            DisplayUnion();
            Console.WriteLine();
            DisplayConcat();
            Console.WriteLine();
            AggregateOps();
            Console.ReadLine();
        }
        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;
            foreach (var p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
        }
        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");
            var overstock = from c in products where c.NumberInStock > 25 select c;
            foreach (var prod in overstock)
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void GetNamesAndDrescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions: ");
            var nameDesc = from n in products select new { n.Name, n.Description };
            foreach (var i in nameDesc)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from n in products select new { n.Name, n.Description };
            return nameDesc.ToArray();
        }
        static void GetCoundFromQuery()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2" };
            int numb = (from i in currentVideoGames where i.Length > 6 select i).Count();
            Console.WriteLine(numb);
        }
        static void ReverseEverything(ProductInfo[]products)
        {
            Console.WriteLine("Products in reverse");
            var allproducrs = from i in products select i;
            foreach (var item in allproducrs.Reverse())
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void AlphabetizeProductNames(ProductInfo[]products)
        {
            var subset = from p in products orderby p.Name select p;
            // ascending пояснение по возрастанию
            //var subset = from p in products orderby p.Name ascending select p;
            // descending по убыванию
            //var subset = from p in products orderby p.Name descending select p; 
            Console.WriteLine("Ordered by name");
            foreach (var item in subset)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void DisplayDiff()
        {
            List<string> myCars = new List<string> {"Yugo","Aztec","BMW"};
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec"};
            // Except Разность значения по сравнению 
            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have, but i do:");
            foreach (var car in carDiff)
            {
                Console.WriteLine(car);
            }
        }
        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            // Intersect находит общие значения
            var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common:");
            foreach (var car in carIntersect)
            {
                Console.WriteLine(car);
            }
        }
        static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            // Соединяет значения исключая одинаковые
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (var car in carUnion)
            {
                Console.WriteLine(car);
            }
        }
        static void DisplayConcat()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            // Объединяет последовательности со всеми значениями, даже если они совпадают
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            //"Yugo", "Aztec", "BMW", "BMW", "Saab", "Aztec"
            foreach (var car in carConcat)
            {
                Console.WriteLine(car);
            }
        }
        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            // Объединяет последовательности со всеми значениями, даже если они совпадают
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            // Distinct не выводит повторяющиеся значения
            foreach (var car in carConcat.Distinct())
            {
                Console.WriteLine(car);
            }
        }
        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
            Console.WriteLine("Max temp: {0}",(from i in winterTemps select i).Max());
            Console.WriteLine("Min temp: {0}",(from i in winterTemps select i).Min());
            Console.WriteLine("Average temp: {0}",(from i in winterTemps select i).Average());
            Console.WriteLine("Sum of all temps: {0}",(from i in winterTemps select i).Sum());
        }
    }
}
