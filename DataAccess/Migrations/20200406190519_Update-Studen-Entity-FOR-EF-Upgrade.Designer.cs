﻿// <auto-generated />
using DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20200406190519_Update-Studen-Entity-FOR-EF-Upgrade")]
    partial class UpdateStudenEntityFOREFUpgrade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.DBEntities.StudentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnName("int")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnName("varchar(60)")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("varchar(60)")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
