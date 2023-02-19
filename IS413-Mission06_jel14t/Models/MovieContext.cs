using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Mission06_jel14t.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<MovieEntryModel> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { categoryID = 1, categoryName = "Action/Adventure"},
                new Category { categoryID = 2, categoryName = "Comedy" },
                new Category { categoryID = 3, categoryName = "Drama" },
                new Category { categoryID = 4, categoryName = "Family" },
                new Category { categoryID = 5, categoryName = "Horror/Suspense" },
                new Category { categoryID = 6, categoryName = "Miscellaneous" },
                new Category { categoryID = 7, categoryName = "Television" },
                new Category { categoryID = 8, categoryName = "VHS" }
                );

            mb.Entity<MovieEntryModel>().HasData(
                new MovieEntryModel
                {
                    EntryID = 1,
                    categoryID = 1,
                    title = "Die Hard",
                    year = 1988,
                    director = "John McTiernan",
                    rating = "R",
                    edited = true,
                },
                new MovieEntryModel
                {
                    EntryID = 2,
                    categoryID = 1,
                    title = "Independence Day",
                    year = 1996,
                    director = "Roland Emmerich",
                    rating = "PG-13",
                    edited = false,

                },
                new MovieEntryModel
                {
                    EntryID = 3,
                    categoryID = 2,
                    title = "Planes, Trains and Automobiles",
                    year = 1987,
                    director = "John Hughes",
                    rating = "R",
                    edited = true,
                    lentTo = "Dave",
                    notes = "What an interesting movie"
                }
            );
        }
    }
}
