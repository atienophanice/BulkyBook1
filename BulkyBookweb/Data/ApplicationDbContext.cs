using Microsoft.EntityFrameworkCore;

namespace BulkyBookweb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
    }
}
