using System.Linq;
using Panda.Data.Models;

namespace Panda.Service
{
    public interface IReceiptsService
    {
        void CreateFromPackage(decimal weight, string packageId, string recipientId);

        IQueryable<Receipt> GetAll();
    }
}