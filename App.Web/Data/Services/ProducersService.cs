using App.Web.Data.Base;
using App.Web.Models;

namespace App.Web.Data.Services
{
    public class ProducersService :EntityBaseRepository<Producer>, IProducerService
    {
        public ProducersService(AppDbContext dbContext) : base(dbContext) { }
    }
}
