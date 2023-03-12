using MyCvProject.Context;
using MyCvProject.Models.Entities;

namespace MyCvProject.Repositories
{
    public class CertificateRepository : GenericRepository<Certificate>
    {
        public CertificateRepository(AppDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
