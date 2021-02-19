using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhonebookApi.Models
{
    public class PhonebookContext:DbContext
    {
        public PhonebookContext(DbContextOptions<PhonebookContext> options)
           : base(options)
        {
        }
        public DbSet<PhoneBook> PhoneBook { get; set; }
    }
}
