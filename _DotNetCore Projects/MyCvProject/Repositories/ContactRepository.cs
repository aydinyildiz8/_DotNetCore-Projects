using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class ContactRepository : GenericRepository<Contact>
    {
        public ContactRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
