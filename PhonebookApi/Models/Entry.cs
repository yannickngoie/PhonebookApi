﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhonebookApi.Models
{
    public class Entry
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
