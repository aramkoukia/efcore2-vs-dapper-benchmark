using BenchmarkDotNet.Attributes;
using EFCore2VSDapper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore2VSDapper
{
    public class EFCore2VsDapper
    {
        EFRepository _EFRepo;
        DapperRepository _DapperRepo;
        public EFCore2VsDapper()
        {
            _EFRepo = new EFRepository();
            _DapperRepo = new DapperRepository();
        }

        [Benchmark]
        public List<Product> GetProductsWithEntityFramework() => _EFRepo.GetAllProductsByCategory(10);

        [Benchmark]
        public List<Product> GetProductsWithDapper() => _DapperRepo.GetAllProductsByCategory(10);
    }
}
