using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazerApp.Database.Data;
using BlazorApp.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.BL.Repositories
{
    /*That is the flow that we get data from database here controller call the service and service call the repository and repository call the database
     
     */
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProducts();
    }
    public class productRepository(AppDbContext dbContext):IProductRepository
    {
        public Task<List<ProductModel>> GetProducts()
        {

            return dbContext.Products.ToListAsync();
        }
    }
}
