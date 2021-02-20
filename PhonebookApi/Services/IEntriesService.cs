using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhonebookApi.Services
{
    public interface IEntriesService
    {
        Task<List<IEnumerable>> GetAllEntries();
        

    }
}
