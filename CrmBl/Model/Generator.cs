﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    public class Generator
    {
        Random rnd=new Random();

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();
      
        public List<Customer> GetNewCustomers(int count)
        {
            var result=new List<Customer>();
            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    Name = GetRandomText(),
                    CustomerId = Customers.Count,
                };

                Customers.Add(customer);
                result.Add(customer);
            }

            return result;
        }
        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();
            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    Name = GetRandomText(),
                    SellerId = Sellers.Count,
                };

                Sellers.Add(seller);
                result.Add(seller);
            }

            return result;
        }
        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    Name = GetRandomText(),
                    ProductId = Products.Count,
                    Count = rnd.Next(10, 1000),
                    Price=Convert.ToDecimal(rnd.Next(5, 100000)+rnd.NextDouble()),
                };

                Products.Add(product);
                result.Add(product);
            }

            return result;
        }
        public List<Product>GetRandomProduct(int min,int max)
        {
            var  result=new List<Product>();    
            var count=rnd.Next(min,max);
            for(int i = 0;i < count; i++)
            {
                result.Add(Products[rnd.Next(Products.Count-1)]);
            }

            return result;
        }
       
        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0,5);
        }
    }
}
