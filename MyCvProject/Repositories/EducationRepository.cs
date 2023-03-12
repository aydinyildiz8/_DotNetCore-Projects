using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class EducationRepository : GenericRepository<Education>
    {
        public EducationRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
