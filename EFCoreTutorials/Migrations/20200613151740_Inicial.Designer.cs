﻿using EFCoreTutorials.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorials.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200613151740_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ejemplos.Models.Grade", b =>
            {
                b.Property<int>("GradeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("GradeName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("GradeId");

                b.ToTable("Grade");
            });

            modelBuilder.Entity("Ejemplos.Models.Student", b =>
            {
                b.Property<int>("StudentId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("GradeId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("StudentId");

                b.HasIndex("GradeId");

                b.ToTable("Student");
            });

            modelBuilder.Entity("Ejemplos.Models.Student", b =>
            {
                b.HasOne("Ejemplos.Models.Grade", "Grade")
                    .WithMany("Students")
                    .HasForeignKey("GradeId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}
