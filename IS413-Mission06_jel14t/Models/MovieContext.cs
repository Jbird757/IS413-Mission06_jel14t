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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntryModel>().HasData(
                new MovieEntryModel
                {
                    EntryID = 1,
                    category = "Action/Adventure",
                    title = "Die Hard",
                    year = 1988,
                    director = "John McTiernan",
                    rating = "R",
                    edited = true,
                },
                new MovieEntryModel
                {
                    EntryID = 2,
                    category = "Action/Adventure",
                    title = "Independence Day",
                    year = 1996,
                    director = "Roland Emmerich",
                    rating = "PG-13",
                    edited = false,

                },
                new MovieEntryModel
                {
                    EntryID = 3,
                    category = "Comedy",
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
