using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class AboutRepository : GenericRepository<About>
    {
        public AboutRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
