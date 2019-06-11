using System;

namespace Panda.Web.ViewsModels.Reciept
{
    public class RecieptViewModel
    {
        public string Id { get; set; }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        public string RecipientName { get; set; }
        

    }
}