using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhonebookApi.Models;
namespace PhonebookApi.Services
{
   public interface IPhoneBookService
    {
        Task<List<PhoneBook>> GetAllPhoneBooks();
        Task <PhoneBook> AddPhoneBook(PhoneBook phoneBook);
        Task<PhoneBook> GetPhoneBook(long id);
    }
}
