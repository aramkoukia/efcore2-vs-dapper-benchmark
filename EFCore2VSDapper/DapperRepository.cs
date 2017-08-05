using EFCore2VSDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    class DapperRepository
    {
        public List<Product> GetAllProductsByCategory(int categoryId)
        {
            using (var db = new EFCore2TestContext())
            {
                var products = db.Product
                    .Where(b => b.ProductCategoryId == categoryId)
                    .OrderBy(b => b.ProductNumber)
                    .Include(p => p.ProductCategory)
                    .ToList();

                return products;
            }
        }
    }
}
