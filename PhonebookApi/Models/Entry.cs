using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhonebookApi.Models
{
    [Table(name: "Entry", Schema = "dbo")]
    public class Entry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(length: 100)]
        public string Name { get; set; }
        [MaxLength(length: 250)]
        public string PhoneNumber { get; set; }
    }
}
