using Microsoft.EntityFrameworkCore;
using WLogestic.Api.Models;

namespace WLogestic.Api.EF
{
    public class WLogesticDBContex: DbContext
    {
        public WLogesticDBContex(DbContextOptions<WLogesticDBContex>options):base(options)
        {
            
        }
        
        public DbSet<Company> Companies { get; set; }
    }
}
