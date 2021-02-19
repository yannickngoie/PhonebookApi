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

        private List<IEnumerable> _phoneBooks;
        private readonly PhonebookApiContext _context;
        public PhoneBookService(PhonebookApiContext context)
        {
            _phoneBooks = new List<IEnumerable>();
            _context = context;
        }
       public PhoneBook AddPhoneBook (PhoneBook phoneBook)
       {
            _context.PhoneBooks.Add(phoneBook);
            return phoneBook;
       }

        IEnumerable <PhoneBook> IPhoneBookService.GetAllPhoneBooks()
        {
            return _context.PhoneBooks.ToList();
        }
    }
}
