using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhonebookApi.Models;


namespace PhonebookApi.Services
{
    public class EntriesService : IEntriesService
    {
        private readonly PhonebookApiContext _context;
        public EntriesService(PhonebookApiContext context)
        {

            _context = context;
        }
        public async Task<IEnumerable<Entry>> GetAllPhonebookEntries()
        {
            return await _context.Entries.ToListAsync();
        }

       public async Task<Entry> AddPhonebookEntries(Entry phoneBookEntry)
        {
            _context.Entries.Add(phoneBookEntry);
            await _context.SaveChangesAsync();
            var result = phoneBookEntry;

            return result;
        }
    }
}
