using BenchmarkDotNet.Running;
using System;

namespace EFCore2VSDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new EFRepository();
            var result = repo.GetAllProductsByCategory(18);
            Console.WriteLine(result[0].ProductCategory.Name);
            Console.ReadLine();

            var summary = BenchmarkRunnerCore.Run(typeof(EFCore2VsDapper));
        }
    }
}
