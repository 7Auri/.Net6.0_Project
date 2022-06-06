﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(PDbContext))]
    partial class PDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birtday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("Entities.Concrete.DryFood", b =>
                {
                    b.Property<int>("DryFoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DryFoodId"), 1L, 1);

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DryFoodId");

                    b.ToTable("DryFoods");
                });

            modelBuilder.Entity("Entities.Concrete.DTOs.Fvrcp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Vaccine")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Fvrcp");
                });

            modelBuilder.Entity("Entities.Concrete.DTOs.Leukemia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Vaccine")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Leukemia");
                });

            modelBuilder.Entity("Entities.Concrete.DTOs.Rabies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Vaccine")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rabies");
                });

            modelBuilder.Entity("Entities.Concrete.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<int>("DryFoodId")
                        .HasColumnType("int");

                    b.Property<int>("WetFoodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DryFoodId");

                    b.HasIndex("WetFoodId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Entities.Concrete.Health", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sterilization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("Healths");
                });

            modelBuilder.Entity("Entities.Concrete.MaltVit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CatId")
                        .HasColumnType("int");

                    b.Property<bool?>("Malt")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("MaltTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VitTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Vitamin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("MaltVits");
                });

            modelBuilder.Entity("Entities.Concrete.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CatId")
                        .HasColumnType("int");

                    b.Property<int>("FvrcpId")
                        .HasColumnType("int");

                    b.Property<int>("LeukemiaId")
                        .HasColumnType("int");

                    b.Property<int>("RabiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.HasIndex("FvrcpId");

                    b.HasIndex("LeukemiaId");

                    b.HasIndex("RabiesId");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("Entities.Concrete.WetFood", b =>
                {
                    b.Property<int>("WetFoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WetFoodId"), 1L, 1);

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WetFoodId");

                    b.ToTable("WetFoods");
                });

            modelBuilder.Entity("Entities.Concrete.Food", b =>
                {
                    b.HasOne("Entities.Concrete.DryFood", "DryFood")
                        .WithMany()
                        .HasForeignKey("DryFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.WetFood", "WetFood")
                        .WithMany()
                        .HasForeignKey("WetFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DryFood");

                    b.Navigation("WetFood");
                });

            modelBuilder.Entity("Entities.Concrete.Health", b =>
                {
                    b.HasOne("Entities.Concrete.Cat", "Cat")
                        .WithMany()
                        .HasForeignKey("CatId");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("Entities.Concrete.MaltVit", b =>
                {
                    b.HasOne("Entities.Concrete.Cat", "Cat")
                        .WithMany()
                        .HasForeignKey("CatId");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("Entities.Concrete.Vaccine", b =>
                {
                    b.HasOne("Entities.Concrete.Cat", "Cat")
                        .WithMany()
                        .HasForeignKey("CatId");

                    b.HasOne("Entities.Concrete.DTOs.Fvrcp", "Fvrcp")
                        .WithMany()
                        .HasForeignKey("FvrcpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.DTOs.Leukemia", "Leukemia")
                        .WithMany()
                        .HasForeignKey("LeukemiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.DTOs.Rabies", "Rabies")
                        .WithMany()
                        .HasForeignKey("RabiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");

                    b.Navigation("Fvrcp");

                    b.Navigation("Leukemia");

                    b.Navigation("Rabies");
                });
#pragma warning restore 612, 618
        }
    }
}
