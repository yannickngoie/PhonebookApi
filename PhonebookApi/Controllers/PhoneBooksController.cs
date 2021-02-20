using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhonebookApi.Models;
using PhonebookApi.Services;

namespace PhonebookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBooksController : ControllerBase
    {
        private readonly PhonebookApiContext _context;
        private readonly IPhoneBookService _service;
        public PhoneBooksController(IPhoneBookService service)
        {
         
            _service = service;
        }

        // GET: api/PhoneBooks1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhoneBook>>> GetAllPhoneBooks()
        {

            return Ok(await _service.GetAllPhoneBooks());
        }

        // GET: api/PhoneBooks1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhoneBook>> GetPhoneBook(long id)
        {
            var phoneBook = await _service.GetPhoneBook(id);

            if (phoneBook == null)
            {
                return NotFound();
            }

            return phoneBook;
        }


        // POST: api/PhoneBooks1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhoneBook>> PostPhoneBook(PhoneBook phoneBook)
        {
            var result = await _service.AddPhoneBook(phoneBook);
            return CreatedAtAction(nameof(GetPhoneBook), new { id = phoneBook.Id }, result);
        }

    }
}
