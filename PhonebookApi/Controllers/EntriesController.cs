using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PhonebookApi.Models;
using PhonebookApi.Services;

namespace PhonebookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntriesController : ControllerBase
    {
        private readonly PhonebookApiContext _context;
        private readonly IEntriesService _service;
        private readonly ILogger<EntriesController> _logger;
        public EntriesController(IEntriesService service, ILogger<EntriesController> logger)
        {

            _service = service;
            _logger = logger;
        }


        // GET: api/Entries1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entry>>> GetAllPhonebookEntries()
        {
           return Ok(await _service.GetAllPhonebookEntries());
        }

        // GET: api/Entries1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entry>> GetEntry(long id)
        {
            var entry = await _context.Entries.FindAsync(id);

            if (entry == null)
            {
                return NotFound();
            }

            return entry;
        }

       
        [HttpPost]
        public async Task<ActionResult<Entry>> PostEntry(Entry entry)
        {
            var result = await _service.AddPhonebookEntries(entry);
            return CreatedAtAction(nameof(GetEntry), new { id = entry.Id }, result);
        }

        private bool EntryExists(long id)
        {
            return _context.Entries.Any(e => e.Id == id);
        }
    }
}
