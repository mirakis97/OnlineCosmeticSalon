using OnlineCosmeticSalon.Infrastructure.Data.Common;
using OnlineCosmeticSalon.Infrastucture.Data;

namespace OnlineCosmeticSalon.Infrastructure.Data.Repositories
{
    public class ApplicatioDbRepository : Repository, IApplicatioDbRepository
    {
        public ApplicatioDbRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
