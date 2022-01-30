using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2S.Models;
using S2S.Repository;
using System.Linq;

namespace S2S.Pages
{
    public class DetailModel : PageModel
    {
        private readonly IRepository _repository;

        public Book Book { get; set; }

        public DetailModel(IRepository repository)
        {
            _repository = repository;
        }
        
        public void OnGet(int bookId)
        {
            Book = _repository.Detail(bookId);
        }
    }
}
