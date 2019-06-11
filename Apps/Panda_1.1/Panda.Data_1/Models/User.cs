using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Panda.Data_1.Models
{
    public class User : BaseEntity<string>
    {
        public User()
        {
            this.Packages = new HashSet<Package>();
            this.Receipts = new HashSet<Receipt>();
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<Package> Packages { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }
        /*•	Id - a GUID String, Primary Key
           •	Username - a string with min length 5 and max length 20 (required)
           •	Email - a string with min length 5 and max length 20 (required)
           •	Password - a string – hashed in the database (required)
           •	Packages – a Collection of type Packages
           •	Receipts – a Collection of type Receipts
           */
    }
}