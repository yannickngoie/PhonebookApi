using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhonebookApi.Services;
using PhonebookApi.Models;
namespace PhonebookApi.Services
{
    public interface IEntriesService
    {
        Task<IEnumerable<Entry>> GetAllPhonebookEntries();
        Task<Entry> AddPhonebookEntries(Entry phoneBookEntry);



    }
}
