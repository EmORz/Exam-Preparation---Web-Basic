using System;
using System.ComponentModel.DataAnnotations;
using Panda.Data_1.Models.Enums;

namespace Panda.Data_1.Models
{
    public class Package : BaseEntity<string>
    {
        public Package()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public PackageStatus Status { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        [Required]
        public string RecipientId { get; set; }

        public virtual User Recipient { get; set; }
        /*•	Id - a GUID String, Primary Key
           •	Description - a string a string with min length 5 and max length 20 (required)
           •	Weight - a floating-point number
           •	Shipping Address - a string
           •	Status - can be one of the following values ("Pending", "Delivered")
           •	Estimated Delivery Date - a DateTime object
           •	RecipientId - GUID foreign key (required)
           •	Recipient - a User object
           */
    }
}