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

        public IEnumerable<Book> Books => _context.Books;

        public Book Detail(int id)
        {
            return Books.FirstOrDefault(book => book.BookId == id);
        }
    }
}
