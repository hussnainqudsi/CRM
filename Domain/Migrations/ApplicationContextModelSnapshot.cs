﻿// <auto-generated />
using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Description", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.Property<int?>("LeadsLeadId")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedDate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NextFollowUp")
                        .HasColumnType("datetime2");

                    b.HasKey("DescriptionId");

                    b.HasIndex("LeadsLeadId");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("Domain.Entities.Leads", b =>
                {
                    b.Property<int>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FollowUpDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedDate")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocietyId")
                        .HasColumnType("int");

                    b.Property<int>("SourceId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeadId");

                    b.HasIndex("SocietyId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("Domain.Entities.Society", b =>
                {
                    b.Property<int>("SocietyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedDate")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("SocietyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocietyId");

                    b.ToTable("Society");
                });

            modelBuilder.Entity("Domain.Entities.Description", b =>
                {
                    b.HasOne("Domain.Entities.Leads", "Leads")
                        .WithMany("description")
                        .HasForeignKey("LeadsLeadId");
                });

            modelBuilder.Entity("Domain.Entities.Leads", b =>
                {
                    b.HasOne("Domain.Entities.Society", "societies")
                        .WithMany()
                        .HasForeignKey("SocietyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
