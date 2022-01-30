using S2S.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2S.Repository
{
    public interface IRepository
    {
        Book Detail(int id);
        IQueryable<Book> Books { get; }
        Task Buy(int id);
    }
}