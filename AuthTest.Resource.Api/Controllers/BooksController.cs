using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthTest.Resource.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthTest.Resource.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStore _store;

        public BooksController(BookStore store)
        {
            _store = store;
        }

        public IActionResult GetAvailableBook()
        {
            return Ok(_store.Books);
        }
    }
}