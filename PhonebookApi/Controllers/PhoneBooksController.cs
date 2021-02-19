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
       // private readonly PhoneBookService _service = new PhoneBookService();
        public PhoneBooksController(PhonebookApiContext context)
        {
            _context = context;

        }

        // GET: api/PhoneBooks1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhoneBook>>> GetPhoneBook()
        {
            return await _context.PhoneBooks.ToListAsync();
        }

        // GET: api/PhoneBooks1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhoneBook>> GetPhoneBook(long id)
        {
            var phoneBook = await _context.PhoneBooks.FindAsync(id);

            if (phoneBook == null)
            {
                return NotFound();
            }

            return phoneBook;
        }

        // PUT: api/PhoneBooks1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoneBook(long id, PhoneBook phoneBook)
        {
            if (id != phoneBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(phoneBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneBookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PhoneBooks1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhoneBook>> PostPhoneBook(PhoneBook phoneBook)
        {
            _context.PhoneBooks.Add(phoneBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPhoneBook), new { id = phoneBook.Id }, phoneBook);
        }

        // DELETE: api/PhoneBooks1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoneBook(long id)
        {
            var phoneBook = await _context.PhoneBooks.FindAsync(id);
            if (phoneBook == null)
            {
                return NotFound();
            }

            _context.PhoneBooks.Remove(phoneBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhoneBookExists(long id)
        {
            return _context.PhoneBooks.Any(e => e.Id == id);
        }
    }
}
