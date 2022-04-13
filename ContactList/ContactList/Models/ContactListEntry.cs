using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactList.Models
{
    //[Table("ContactLists")]
    public class ContactListEntry
    {
        [Key]
        public int Id { get; set; }
        public ContactType ContactType { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }
    }
}
