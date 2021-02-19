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
        public as Task List<PhoneBook>GetAllPhoneBooks();
        public PhoneBook AddPhoneBook(PhoneBook phoneBook);
    }
}
