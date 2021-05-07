using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup AlgorithmFactory
            var algorithmFactory = new AlgorithmFactory();
            RegisterAlgorithms(algorithmFactory);

            do
            {
                // Read in list of integers
                Console.WriteLine("Enter a list of integers (Space seperated)");
                var numbers = ReadNumbers();

                // Pick an "algorithm" (min, max, mean, first, last). Assume that these "algorithms" are actually really complex algorithms that need to be abstracted away
                Console.WriteLine("Enter chosen algorithm names seperated by a space (min max mean first last)");
                var algorithmNames = ReadAlgorithmNames();

                // TODO: get the algorithms based on the entered names
                // TODO: run the algorithms

                // Show the result
                PrintResults(results);

                Console.WriteLine("Quit? (Y/N)");
                if (Console.ReadLine().Trim().ToLower().Equals("y"))
                    break;
            }
            while (true);
        }

        static void RegisterAlgorithms(AlgorithmFactory algorithmFactory)
        {
            throw new NotImplementedException();
        }

        static void PrintResults(List<AlgorithmResult> results)
        {
            throw new NotImplementedException();
        }

        static IEnumerable<int> ReadNumbers()
        {
            throw new NotImplementedException();
        }

        static IEnumerable<string> ReadAlgorithmNames()
        {
            throw new NotImplementedException();
        }
    }
}
