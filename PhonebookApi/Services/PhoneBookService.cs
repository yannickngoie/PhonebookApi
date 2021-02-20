using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhonebookApi.Models;

namespace PhonebookApi.Services
{
    public class PhoneBookService:IPhoneBookService
    {

 
        private readonly PhonebookApiContext _context;
        public PhoneBookService(PhonebookApiContext context)
        {

            _context = context;
        }

        public async Task<PhoneBook> AddPhoneBook(PhoneBook phoneBook)
        {
            _context.PhoneBooks.Add(phoneBook);
            await _context.SaveChangesAsync();
            var result = phoneBook;
            
            return result;
        }

        public async Task<List<PhoneBook>> GetAllPhoneBooks()
        {
            return await _context.PhoneBooks.ToListAsync();
        }

        public async Task<PhoneBook> GetPhoneBook(long id)
        {
            return await _context.PhoneBooks.FindAsync(id);
          
        }
    }
}
