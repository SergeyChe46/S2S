using S2S.Models;
using System.Collections.Generic;

namespace S2S.Repository
{
    public interface IRepository
    {
        Book Detail(int id);
        IEnumerable<Book> Books { get; }
    }
}