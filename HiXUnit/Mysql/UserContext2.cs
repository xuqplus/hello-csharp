﻿using System.Data.Entity;
using System.Collections.Generic;

namespace HiXUnit.Mysql
{
    public class UserContext2 : DbContext
    {
        static string cs = @"server=localhost;userid=test;password=123456;database=csharp";

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseMySQL(cs);
        //}

        public DbSet<User> Users { get; set; }
    }
}