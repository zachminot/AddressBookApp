﻿// <auto-generated />
using AddressBookApp.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddressBookApp.Migrations
{
    [DbContext(typeof(AddressDbContext))]
    partial class AddressDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressBookApp.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.HasIndex("ContactID");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressID = 1,
                            City = "Springfield",
                            ContactID = 1,
                            PostalCode = "11111",
                            State = "New Jersey",
                            StreetAddress = "1 Any Street"
                        },
                        new
                        {
                            AddressID = 2,
                            City = "Paramus",
                            ContactID = 1,
                            PostalCode = "99999",
                            State = "New Jersey",
                            StreetAddress = "2 Some Street"
                        });
                });

            modelBuilder.Entity("AddressBookApp.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactID = 1,
                            FirstName = "TestFirst",
                            LastName = "TestLast"
                        },
                        new
                        {
                            ContactID = 2,
                            FirstName = "2ndTestFirst",
                            LastName = "2ndTestLast"
                        });
                });

            modelBuilder.Entity("AddressBookApp.Models.Address", b =>
                {
                    b.HasOne("AddressBookApp.Models.Contact", null)
                        .WithMany("Addresses")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AddressBookApp.Models.Contact", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}