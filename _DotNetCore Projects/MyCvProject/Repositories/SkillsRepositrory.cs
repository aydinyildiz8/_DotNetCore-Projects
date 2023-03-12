using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class SkillsRepositrory : GenericRepository<Skill>
    {
        public SkillsRepositrory(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
