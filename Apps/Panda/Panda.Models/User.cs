using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Panda.Models
{
    public class User
    {
        public User()
        {
            this.Receipts = new HashSet<Receipt>();
            this.Packages = new HashSet<Package>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        //todo stringlenght validation
        [StringLength(20, MinimumLength = 5)]
        public string Username { get; set; }

        [StringLength(20, MinimumLength = 5)]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Package> Packages { get; set; }

        public ICollection<Receipt> Receipts { get; set; }
        /*•	Id - a GUID String, Primary Key
           •	Username - a string with min length 5 and max length 20 (required)
           •	Email - a string with min length 5 and max length 20 (required)
           •	Password - a string – hashed in the database (required)
           •	Packages – a Collection of type Packages
           •	Receipts – a Collection of type Receipts
           */
    }
}