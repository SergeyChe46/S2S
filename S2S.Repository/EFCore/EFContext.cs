using Microsoft.EntityFrameworkCore;
using S2S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2S.Repository
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(_books);
            modelBuilder.Entity<Author>().HasData(_authors);
        }

        //тестовые данные для наполнения БД
        private List<Book> _books = new List<Book>()
        {
            new Book(){ BookId = 1, AuthorId = 1, Title = "Вишнёвый сад", PublishedAt = new DateTime(1903, 01, 01) },
            new Book(){ BookId = 2, AuthorId = 1, Title = "Три сестры", PublishedAt = new DateTime(1900, 01, 01) },
            new Book(){ BookId = 3, AuthorId = 1, Title = "Дядя Ваня", PublishedAt = new DateTime(1896, 01, 01) },

            new Book(){ BookId = 4, AuthorId = 2, Title = "Война и мир", PublishedAt = new DateTime(1856, 01, 01) },
            new Book(){ BookId = 5, AuthorId = 2, Title = "Анна Каренина", PublishedAt = new DateTime(1873, 01, 01) },
            new Book(){ BookId = 6, AuthorId = 2, Title = "Детство", PublishedAt = new DateTime(1889, 01, 01) },

            new Book(){ BookId = 7, AuthorId = 3, Title = "Братья Карамазовы", PublishedAt = new DateTime(1879, 01, 01) },
            new Book(){ BookId = 8, AuthorId = 3, Title = "Преступление и наказание", PublishedAt = new DateTime(1866, 01, 01) },
            new Book(){ BookId = 9, AuthorId = 3, Title = "Идиот", PublishedAt = new DateTime(1867, 01, 01) },
        };

        private List<Author> _authors = new List<Author>()
        {
            new Author(){ AuthorId = 1, Name = "Чехов" },
            new Author(){ AuthorId = 2, Name = "Толстой" },
            new Author(){ AuthorId = 3, Name = "Достоевский" }
        };
    }
}
