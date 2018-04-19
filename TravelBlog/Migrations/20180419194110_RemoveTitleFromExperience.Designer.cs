using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TravelBlog.Models;

namespace TravelBlog.Migrations
{
    [DbContext(typeof(TravelBlogDbContext))]
    [Migration("20180419194110_RemoveTitleFromExperience")]
    partial class RemoveTitleFromExperience
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("TravelBlog.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("TravelDate");

                    b.HasKey("ExperienceId");

                    b.HasIndex("LocationId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("TravelBlog.Models.ExperiencesPersons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExperienceId");

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("PersonId");

                    b.ToTable("ExperiencesPersons");
                });

            modelBuilder.Entity("TravelBlog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TravelBlog.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TravelBlog.Models.Experience", b =>
                {
                    b.HasOne("TravelBlog.Models.Location", "Location")
                        .WithMany("Experiences")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("TravelBlog.Models.ExperiencesPersons", b =>
                {
                    b.HasOne("TravelBlog.Models.Experience", "Experience")
                        .WithMany("ExperiencesPersons")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelBlog.Models.Person", "Person")
                        .WithMany("ExperiencesPersons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
