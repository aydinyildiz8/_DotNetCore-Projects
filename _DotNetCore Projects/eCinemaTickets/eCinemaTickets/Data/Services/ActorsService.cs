using eCinemaTickets.Data.Base;
using eCinemaTickets.Models;

namespace eCinemaTickets.Data.Services
{
    public class ActorsService: EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
