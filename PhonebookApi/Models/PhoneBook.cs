using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhonebookApi.Models
{
    [Table(name: "PhoneBook", Schema = "dbo")]
    public class PhoneBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(length: 100)]
        public string Name { get; set; }
        [MaxLength(length: 100)]
        public string Entries { get; set; }
    }
}
