using Microsoft.EntityFrameworkCore;
using S2S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2S.Repository.EFCore
{
    //всего два метода для извлечения списка книг и конкретной книги
    public class EFRepository : IRepository
    {
        private EFContext _context;

        public EFRepository(EFContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books.Include(b => b.Author);
        
        public Book Detail(int id)
        {
            return _context.Books.FirstOrDefault(i => i.BookId == id);
        }

        public async Task Buy(int id)
        {
            Book book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
