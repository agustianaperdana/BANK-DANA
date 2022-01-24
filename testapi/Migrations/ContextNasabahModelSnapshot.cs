﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testapi.Models;

#nullable disable

namespace testapi.Migrations
{
    [DbContext(typeof(ContextNasabah))]
    partial class ContextNasabahModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("testapi.Models.MNasabah", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoHP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoKTP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TTL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tgl_Lahir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nasabahs");
                });
#pragma warning restore 612, 618
        }
    }
}
