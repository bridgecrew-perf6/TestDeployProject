﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SS.DataAccess;

#nullable disable

namespace SS.DataAccess.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220508163355_SchemaUpdate_Add_RecModified-IsRemoved")]
    partial class SchemaUpdate_Add_RecModifiedIsRemoved
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LabelStickerPack", b =>
                {
                    b.Property<long>("LabelsId")
                        .HasColumnType("bigint");

                    b.Property<long>("StickerPacksId")
                        .HasColumnType("bigint");

                    b.HasKey("LabelsId", "StickerPacksId");

                    b.HasIndex("StickerPacksId");

                    b.ToTable("LabelStickerPack");
                });

            modelBuilder.Entity("SS.DataAccess.Entities.Label", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool?>("IsRemoved")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RecCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("RecModified")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("SS.DataAccess.Entities.StickerPack", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("Count")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsRemoved")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RecCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("RecModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SourceLink")
                        .HasColumnType("text");

                    b.Property<string>("TelegramLink")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TelegramLink")
                        .IsUnique();

                    b.ToTable("StickerPacks");
                });

            modelBuilder.Entity("LabelStickerPack", b =>
                {
                    b.HasOne("SS.DataAccess.Entities.Label", null)
                        .WithMany()
                        .HasForeignKey("LabelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SS.DataAccess.Entities.StickerPack", null)
                        .WithMany()
                        .HasForeignKey("StickerPacksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}