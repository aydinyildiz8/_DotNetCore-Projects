using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class InterestRepository : GenericRepository<Interest>
    {
        public InterestRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
