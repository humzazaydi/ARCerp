using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ARCerp.Data
{
    public class ARCerpContext : IdentityDbContext
    {
        public ARCerpContext(DbContextOptions options) : base(options)
        {
        }
    }
}
