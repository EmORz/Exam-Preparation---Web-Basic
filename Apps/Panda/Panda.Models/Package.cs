using System;
using System.ComponentModel.DataAnnotations;
using Panda.Models.Enums;

namespace Panda.Models
{
    public class Package
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string Weight { get; set; }

        public string ShippingAddress { get; set; }

        public Status Status { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        //todo user => recipient
        public string RecipientId { get; set; }
        public User Recipient { get; set; }
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