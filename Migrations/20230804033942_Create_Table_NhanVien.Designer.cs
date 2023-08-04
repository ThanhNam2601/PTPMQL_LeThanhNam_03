﻿// <auto-generated />
using LeThanhNam_03.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeThanhNam_03.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230804033942_Create_Table_NhanVien")]
    partial class Create_Table_NhanVien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("LeThanhNam_03.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaPhongBan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNhanvien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("LeThanhNam_03.Models.PhongBan", b =>
                {
                    b.Property<string>("MaPhongBan")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenPhongBan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaPhongBan");

                    b.ToTable("PhongBan");
                });
#pragma warning restore 612, 618
        }
    }
}
