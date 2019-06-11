using System.Linq;
using Panda.Service;
using Panda.Web.ViewsModels.Reciept;
using SIS.MvcFramework;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;

namespace Panda.Web.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly IReceiptsService receiptsService;

        public ReceiptsController(IReceiptsService receiptsService)
        {
            this.receiptsService = receiptsService;
        }

        [Authorize()]
        public IActionResult Index()
        {
            var model = this.receiptsService.GetAll().Select(
                x => new RecieptViewModel
                {
                    Fee = x.Fee,
                    Id = x.Id,
                    IssuedOn = x.IssuedOn,
                    RecipientName = x.Recipient.Username
                }
            ).ToList();
            return this.View(model);
        }
        
    }
}