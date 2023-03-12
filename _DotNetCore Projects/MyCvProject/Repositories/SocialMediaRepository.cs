using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class SocialMediaRepository : GenericRepository<SocialMedia>
    {
        public SocialMediaRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
