using System;
using System.Linq;
using Panda.Data;
using Panda.Data.Models;

namespace Panda.Service
{
    public class ReceiptsService : IReceiptsService
    {
        private readonly PandaDbContext db;

        public ReceiptsService(PandaDbContext db)
        {
            this.db = db;
        }
        public void CreateFromPackage(decimal weight, string packageId, string recipientId)
        {
            var reciept = new Receipt()
            {
                PackageId = packageId,
                RecipientId = recipientId,
                Fee = weight*2.67M,
                IssuedOn = DateTime.UtcNow
            };
            this.db.Receipts.Add(reciept);
            this.db.SaveChanges();

        }

        public IQueryable<Receipt> GetAll()
        {
            return this.db.Receipts;
        }
    }
}