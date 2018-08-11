﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstEfCoreApp
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;
            Database=MyFirstEfCoreDb;
            Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }

    }
}
