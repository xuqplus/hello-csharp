﻿using Microsoft.EntityFrameworkCore;

namespace HiXUnit.Mysql
{
    public class UserContext : DbContext
    {
        static string cs = @"server=localhost;userid=csharp-test;password=123456;database=csharp";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(cs);
        }

        public DbSet<User> Users { get; set; }
    }
}