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

        public void OnGet()
        {
            Books = _repository.Books;
        }
    }
}
