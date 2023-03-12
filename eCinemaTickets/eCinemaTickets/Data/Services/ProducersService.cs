using eCinemaTickets.Data.Base;
using eCinemaTickets.Models;

namespace eCinemaTickets.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
