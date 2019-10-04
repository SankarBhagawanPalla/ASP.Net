﻿// <auto-generated />
using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibrarySystem.Migrations
{
    [DbContext(typeof(LibrarySystemContext))]
    partial class LibrarySystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibrarySystem.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<DateTime>("DateOfArrival");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("LibrarySystem.Models.BorrowedBook", b =>
                {
                    b.Property<int>("BorrowedBookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActualReturnDate");

                    b.Property<int>("BookId");

                    b.Property<DateTime?>("BorrowedDate");

                    b.Property<int>("MemberId");

                    b.Property<DateTime?>("ReturnDate");

                    b.HasKey("BorrowedBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("BorrowedBook");
                });

            modelBuilder.Entity("LibrarySystem.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("LibrarySystem.Models.BorrowedBook", b =>
                {
                    b.HasOne("LibrarySystem.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibrarySystem.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
