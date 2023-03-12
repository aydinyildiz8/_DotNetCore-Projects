using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class AdminRepository : GenericRepository<Admin>
    {
        public AdminRepository(AppDbContext _dbContext) : base(_dbContext)
        {

        }
    }
}
