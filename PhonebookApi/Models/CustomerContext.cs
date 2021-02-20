using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhonebookApi.Models
{
    public  class CustomerContext:DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
        : base(options)
        {
        }

        DbSet<Customer> customers { get; set; }
    }
}
