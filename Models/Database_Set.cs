using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaMovies.Models
{
    public class Database_Set : DbContext
    {
        internal object response;

        public Database_Set (DbContextOptions<Database_Set> anyname) : base (anyname)
        {
            //leave blank for now
        }

        public DbSet<FormClass> reponse { get; set; }
        public DbSet<MovieCategories> MovieCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder some_name)
        {

            some_name.Entity<MovieCategories>().HasData(
                    new MovieCategories { CategoryID = 1, Category = "Action/Adventure" },
                    new MovieCategories { CategoryID = 2, Category = "Comedy" },
                    new MovieCategories { CategoryID = 3, Category = "Drama" },
                    new MovieCategories { CategoryID = 4, Category = "Family" },
                    new MovieCategories { CategoryID = 5, Category = "Horror/Suspense" },
                    new MovieCategories { CategoryID = 6, Category = "Miscellaneous" },
                    new MovieCategories { CategoryID = 7, Category = "Television" },
                    new MovieCategories { CategoryID = 8, Category = "VHS" }
                    );



            some_name.Entity<FormClass>().HasData(



                new FormClass
                {
                    MovieID = 1,
                    CategoryID = 2,
                    Title = "The Blindside",
                    Year = 2012,
                    Director = "Steve Jacobs",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Jacob Marley",
                    Notes = "na"
                },

                new FormClass
                {
                    MovieID = 2,
                    CategoryID = 3,
                    Title = "The Dark Knight",
                    Year = 2012,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Jacob Marley",
                    Notes = "na"
                },

                new FormClass
                {
                    MovieID = 3,
                    CategoryID = 4,
                    Title = "The Proposal",
                    Year = 2009,
                    Director = "Anne Fletcher",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "na",
                    Notes = "na"
                }

                
                );

        }
    }
}
