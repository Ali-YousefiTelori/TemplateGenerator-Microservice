﻿// <auto-generated />
using System;
using EasyMicroservices.TemplateGeneratorMicroservice.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyMicroservices.TemplateGeneratorMicroservice.Migrations
{
    [DbContext(typeof(TemplateGeneratorContext))]
    partial class TemplateGeneratorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("FormId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("FormId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.ToTable("FormDetails");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("FormId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("FormId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("FormFills");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FormId")
                        .HasColumnType("bigint");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("ItemTypeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ParentFormItemId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PrimaryFormItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("FormId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("ParentFormItemId");

                    b.HasIndex("PrimaryFormItemId");

                    b.ToTable("FormItems");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("FormFilledId")
                        .HasColumnType("bigint");

                    b.Property<long>("FormItemId")
                        .HasColumnType("bigint");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("FormFilledId");

                    b.HasIndex("FormItemId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("FormItemValues");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.ItemTypeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("Type")
                        .IsUnique();

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "DateTime",
                            Type = (byte)10
                        },
                        new
                        {
                            Id = 2L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "DateOnly",
                            Type = (byte)11
                        },
                        new
                        {
                            Id = 3L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "TimeOnly",
                            Type = (byte)12
                        },
                        new
                        {
                            Id = 4L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "Label",
                            Type = (byte)13
                        },
                        new
                        {
                            Id = 5L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "CheckBox",
                            Type = (byte)8
                        },
                        new
                        {
                            Id = 6L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "CheckList",
                            Type = (byte)7
                        },
                        new
                        {
                            Id = 7L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "OptionList",
                            Type = (byte)9
                        },
                        new
                        {
                            Id = 8L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "TextBox",
                            Type = (byte)6
                        },
                        new
                        {
                            Id = 9L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "Table",
                            Type = (byte)14
                        },
                        new
                        {
                            Id = 10L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "Row",
                            Type = (byte)15
                        },
                        new
                        {
                            Id = 11L,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Title = "AutoIncrementNumber",
                            Type = (byte)16
                        });
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity", b =>
                {
                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity", "Form")
                        .WithMany("FormDetails")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity", b =>
                {
                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity", "Form")
                        .WithMany("FormFills")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity", b =>
                {
                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity", "Form")
                        .WithMany("FormItems")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.ItemTypeEntity", "ItemType")
                        .WithMany("FormItems")
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity", "ParentFormItem")
                        .WithMany("Children")
                        .HasForeignKey("ParentFormItemId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity", "PrimaryFormItem")
                        .WithMany("PrimaryFormItems")
                        .HasForeignKey("PrimaryFormItemId");

                    b.Navigation("Form");

                    b.Navigation("ItemType");

                    b.Navigation("ParentFormItem");

                    b.Navigation("PrimaryFormItem");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity", b =>
                {
                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity", "FormFilled")
                        .WithMany("FormItemValues")
                        .HasForeignKey("FormFilledId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity", "FormItem")
                        .WithMany("FormItemValues")
                        .HasForeignKey("FormItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FormFilled");

                    b.Navigation("FormItem");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity", b =>
                {
                    b.Navigation("FormDetails");

                    b.Navigation("FormFills");

                    b.Navigation("FormItems");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity", b =>
                {
                    b.Navigation("FormItemValues");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("FormItemValues");

                    b.Navigation("PrimaryFormItems");
                });

            modelBuilder.Entity("EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.ItemTypeEntity", b =>
                {
                    b.Navigation("FormItems");
                });
#pragma warning restore 612, 618
        }
    }
}
