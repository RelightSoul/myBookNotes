﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****My first c# App*****");
            Console.WriteLine("Hello World");
            Console.WriteLine();
                    
            // Получить аргументы с использованием System.Environment.
            string[] theArgs = Environment.GetCommandLineArgs();

            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);
            Console.WriteLine();
            
            ShowEnvironmentDetails();
            Console.ReadLine();
        }
        static void ShowEnvironmentDetails()
        {
            // Вывести информацию о дисковых устройствах
            // данной машины и другие интересные детали,
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive); 
                Console.WriteLine("OS: {0}", Environment.OSVersion); 
                Console.WriteLine("Number of processors: {0}",  Environment.ProcessorCount);
                Console.WriteLine("64-x System: {0}",   Environment.Is64BitOperatingSystem);
                Console.WriteLine(".NET Version: {0}", Environment.Version);
            
        }

    }
}
