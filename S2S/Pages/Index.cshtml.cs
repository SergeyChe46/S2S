using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using S2S.Models;
using S2S.Repository;
using S2S.Repository.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2S.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public IEnumerable<Book> Books { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }
        // сортировка на стороне сервера. По хорошему - надо на стороне клиента
        public void OnGet(string? column)
        {
            switch (column)
            {
                case "Name":
                    Books = _repository.Books.OrderBy(i => i.Author.Name);
                    break;
                case "Title":
                    Books = _repository.Books.OrderBy(i => i.Title);
                    break;
                case "Year":
                    Books = _repository.Books.OrderBy(i => i.PublishedAt.Year);
                    break;
                default:
                    Books = _repository.Books;
                    break;
            }
        }
        // удаление 
        public async Task<IActionResult> OnPostBuyAsync(int bookId)
        {
            await _repository.Buy(bookId);
            return RedirectToPage("./Index");
        }
    }
}
