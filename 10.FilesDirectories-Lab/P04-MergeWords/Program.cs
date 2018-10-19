using System;
using System.IO;
using System.Linq;

namespace P04_MergeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allData = File.ReadAllLines("Input1.txt");
            allData = allData.Concat(File.ReadAllLines("Input2.txt")).ToArray();
            File.WriteAllLines(@"Output.txt", allData.OrderBy(x => x));
        }
    }
}
