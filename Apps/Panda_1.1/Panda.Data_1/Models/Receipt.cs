using System;
using System.ComponentModel.DataAnnotations;

namespace Panda.Data_1.Models
{
    public class Receipt : BaseEntity<string>
    {
        public Receipt()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        [Required]
        public string RecipientId { get; set; }

        public virtual User Recipient { get; set; }

        [Required]
        public string PackageId { get; set; }

        public virtual Package Package { get; set; }




        /*•	Fee - a decimal number
           •	Issued On - a DateTime object
           •	RecipientId - GUID foreign key (required)
           •	Recipient - a User object
           •	PackageId - GUID foreign key (required)
           •	Package – a Package object
           */
    }
}