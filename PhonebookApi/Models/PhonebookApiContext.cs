using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhonebookApi.Models
{
    public class PhonebookApiContext:DbContext
    {
        public PhonebookApiContext(DbContextOptions<PhonebookApiContext> options)
            : base(options)
        {
        }

        public DbSet<PhoneBook> PhoneBooks { get; set; }
        public DbSet<Entry> Entries { get; set; }

    }
}
