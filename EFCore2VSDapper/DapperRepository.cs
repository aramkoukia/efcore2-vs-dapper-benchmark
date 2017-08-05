using Dapper;
using EFCore2VSDapper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    public class DapperRepository
    {
        public List<Product> GetAllProductsByCategory(int categoryId)
        {
            using (IDbConnection db = new SqlConnection(@"connection string"))
            {
                return db.Query<Product>
                ($"SELECT * From [SalesLT].[Product] INNER JOIN [SalesLT].[ProductCategory] ON [SalesLT].[ProductCategory].ProductCategoryId = [SalesLT].[Product].ProductCategoryId WHERE [SalesLT].[ProductCategory].ProductCategoryId ={categoryId}").ToList();

            }
        }
    }
}
