﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AskDbContext))]
    [Migration("20210306085121_AddPropertyPhoto")]
    partial class AddPropertyPhoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", "Identity");
                });

            modelBuilder.Entity("Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(350)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(25)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("Id");

                    b.ToTable("User", "Identity");
                });

            modelBuilder.Entity("Entities.AreaUnit", b =>
                {
                    b.Property<int>("AreaUnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("AreaUnitId")
                        .HasName("PK_AreaUnit");

                    b.ToTable("AreaUnit", "Lookup");
                });

            modelBuilder.Entity("Entities.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("BlogId")
                        .HasName("PK_Blog");

                    b.HasIndex("CategoryId");

                    b.ToTable("Blog", "Property");
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("CategoryId")
                        .HasName("PK_Category");

                    b.ToTable("Category", "Lookup");
                });

            modelBuilder.Entity("Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("CityId")
                        .HasName("PK_City");

                    b.ToTable("City", "Lookup");
                });

            modelBuilder.Entity("Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(350)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("CommentId")
                        .HasName("PK_Comment");

                    b.HasIndex("BlogId");

                    b.ToTable("Comment", "Property");
                });

            modelBuilder.Entity("Entities.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<int>("AreaUnitId")
                        .HasColumnType("INT");

                    b.Property<int>("CityId")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(350)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<decimal>("LandArea")
                        .HasColumnType("NUMERIC(18,2)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<decimal>("Price")
                        .HasColumnType("NUMERIC(18,2)");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("INT");

                    b.Property<int>("PurposeId")
                        .HasColumnType("INT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("PropertyId")
                        .HasName("PK_Property");

                    b.HasIndex("AreaUnitId");

                    b.HasIndex("CityId");

                    b.HasIndex("PropertyTypeId");

                    b.HasIndex("PurposeId");

                    b.ToTable("Property", "Property");
                });

            modelBuilder.Entity("Entities.PropertyPhoto", b =>
                {
                    b.Property<int>("PropertyPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("INT");

                    b.HasKey("PropertyPhotoId")
                        .HasName("PK_PropertyPhoto");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyPhoto", "Property");
                });

            modelBuilder.Entity("Entities.PropertyType", b =>
                {
                    b.Property<int>("PropertyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("PropertyTypeId")
                        .HasName("PK_PropertyType");

                    b.ToTable("PropertyType", "Lookup");
                });

            modelBuilder.Entity("Entities.Purpose", b =>
                {
                    b.Property<int>("PurposeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("PurposeId")
                        .HasName("PK_Purpose");

                    b.ToTable("Purpose", "Lookup");
                });

            modelBuilder.Entity("Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim", "Identity");
                });

            modelBuilder.Entity("Entities.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service", "Property");
                });

            modelBuilder.Entity("Entities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim", "Identity");
                });

            modelBuilder.Entity("Entities.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin", "Identity");
                });

            modelBuilder.Entity("Entities.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", "Identity");
                });

            modelBuilder.Entity("Entities.UserToken", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginProvider", "UserId", "Name");

                    b.HasIndex("UserId");

                    b.ToTable("UserToken", "Identity");
                });

            modelBuilder.Entity("Entities.Blog", b =>
                {
                    b.HasOne("Entities.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Blog_Category")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Comment", b =>
                {
                    b.HasOne("Entities.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .HasConstraintName("FK_Comment_Blog")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Entities.Property", b =>
                {
                    b.HasOne("Entities.AreaUnit", "AreaUnit")
                        .WithMany("Properties")
                        .HasForeignKey("AreaUnitId")
                        .HasConstraintName("FK_Property_AreaUnit")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.City", "City")
                        .WithMany("Properties")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Property_City")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.PropertyType", "PropertyType")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyTypeId")
                        .HasConstraintName("FK_Property_PropertyType")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Purpose", "Purpose")
                        .WithMany("Properties")
                        .HasForeignKey("PurposeId")
                        .HasConstraintName("FK_Property_Purpose")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AreaUnit");

                    b.Navigation("City");

                    b.Navigation("PropertyType");

                    b.Navigation("Purpose");
                });

            modelBuilder.Entity("Entities.PropertyPhoto", b =>
                {
                    b.HasOne("Entities.Property", "Property")
                        .WithMany("PropertyPhotos")
                        .HasForeignKey("PropertyId")
                        .HasConstraintName("FK_PropertyPhoto_Property")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Entities.RoleClaim", b =>
                {
                    b.HasOne("Entities.AppRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.UserClaim", b =>
                {
                    b.HasOne("Entities.AppUser", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.UserLogin", b =>
                {
                    b.HasOne("Entities.AppUser", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.UserRole", b =>
                {
                    b.HasOne("Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.UserToken", b =>
                {
                    b.HasOne("Entities.AppUser", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.AppRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Entities.AppUser", b =>
                {
                    b.Navigation("UserClaims");

                    b.Navigation("UserLogins");

                    b.Navigation("UserRoles");

                    b.Navigation("UserTokens");
                });

            modelBuilder.Entity("Entities.AreaUnit", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Entities.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("Entities.City", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Entities.Property", b =>
                {
                    b.Navigation("PropertyPhotos");
                });

            modelBuilder.Entity("Entities.PropertyType", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Entities.Purpose", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
