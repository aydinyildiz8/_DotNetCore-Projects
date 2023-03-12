using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class ExperienceRepository : GenericRepository<Experience>
    {
        public ExperienceRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
