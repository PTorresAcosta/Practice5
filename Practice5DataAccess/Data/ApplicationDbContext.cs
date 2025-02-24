﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice5Model.Models;

namespace Practice5DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=USQROPTORRESAC1;" +
                "Database=Practice5StoreDbEF;" +
                "TrustServerCertificate=True;" +
                "Trusted_Connection=True;");
        }


    }
}
