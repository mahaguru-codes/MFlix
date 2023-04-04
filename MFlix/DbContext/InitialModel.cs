using MFlix.Models.Beans;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

namespace MFlix
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public string DbPath { get; }

        public MovieContext()
        {
            var path = Environment.CurrentDirectory + @"\Database";
            Directory.CreateDirectory(path);
            DbPath = System.IO.Path.Join(path, "blogging.mdf");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}