// <auto-generated />
using DaMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DaMovies.Migrations
{
    [DbContext(typeof(Database_Set))]
    [Migration("20220202215109_Initials")]
    partial class Initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("DaMovies.Models.FormClass", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("reponse");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 2,
                            Director = "Steve Jacobs",
                            Edited = false,
                            Lent_To = "Jacob Marley",
                            Notes = "na",
                            Rating = "PG-13",
                            Title = "The Blindside",
                            Year = 2012
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 3,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent_To = "Jacob Marley",
                            Notes = "na",
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2012
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 4,
                            Director = "Anne Fletcher",
                            Edited = false,
                            Lent_To = "na",
                            Notes = "na",
                            Rating = "PG-13",
                            Title = "The Proposal",
                            Year = 2009
                        });
                });

            modelBuilder.Entity("DaMovies.Models.MovieCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("MovieCategory");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Category = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            Category = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            Category = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            Category = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            Category = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            Category = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 7,
                            Category = "Television"
                        },
                        new
                        {
                            CategoryID = 8,
                            Category = "VHS"
                        });
                });

            modelBuilder.Entity("DaMovies.Models.FormClass", b =>
                {
                    b.HasOne("DaMovies.Models.MovieCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
