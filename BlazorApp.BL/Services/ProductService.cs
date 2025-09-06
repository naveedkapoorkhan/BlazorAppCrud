﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.BL.Repositories;
using BlazorApp.Model.Entities;

namespace BlazorApp.BL.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();
    }
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public Task<List<ProductModel>> GetProducts()
        {
           
               return productRepository.GetProducts();

        
        }


    }  }

