using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhonebookApi.Models
{
    public class PhoneBook
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Entries { get; set; }
    }
}
