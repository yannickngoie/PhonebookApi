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
        public virtual DbSet<PhoneBook> PhoneBooks { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }

    }
}
