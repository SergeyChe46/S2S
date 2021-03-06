// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using S2S.Repository;

namespace S2S.Repository.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("S2S.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Name = "Чехов"
                        },
                        new
                        {
                            AuthorId = 2,
                            Name = "Толстой"
                        },
                        new
                        {
                            AuthorId = 3,
                            Name = "Достоевский"
                        });
                });

            modelBuilder.Entity("S2S.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            PublishedAt = new DateTime(1903, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Вишнёвый сад"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 1,
                            PublishedAt = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Три сестры"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 1,
                            PublishedAt = new DateTime(1896, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Дядя Ваня"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 2,
                            PublishedAt = new DateTime(1856, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Война и мир"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 2,
                            PublishedAt = new DateTime(1873, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Анна Каренина"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 2,
                            PublishedAt = new DateTime(1889, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Детство"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 3,
                            PublishedAt = new DateTime(1879, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Братья Карамазовы"
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 3,
                            PublishedAt = new DateTime(1866, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Преступление и наказание"
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 3,
                            PublishedAt = new DateTime(1867, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Идиот"
                        });
                });

            modelBuilder.Entity("S2S.Models.Book", b =>
                {
                    b.HasOne("S2S.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("S2S.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
