using eCinemaTickets.Data.Base;
using eCinemaTickets.Models;

namespace eCinemaTickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context): base(context)
        {

        }
    }
}
