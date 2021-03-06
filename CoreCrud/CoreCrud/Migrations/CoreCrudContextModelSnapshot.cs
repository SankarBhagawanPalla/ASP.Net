﻿// <auto-generated />
using System;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCrud.Migrations
{
    [DbContext(typeof(CoreCrudContext))]
    partial class CoreCrudContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCrud.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continent");

                    b.Property<string>("Name");

                    b.Property<float>("USDConversionrate");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("CoreCrud.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFlightServiceAvailable");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.Property<decimal>("TotalFair");

                    b.Property<DateTime?>("TravelDate");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("CoreCrud.Models.Destination", b =>
                {
                    b.HasOne("CoreCrud.Models.Country", "Location")
                        .WithMany("Destinations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
