using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class SpendSmartDbConetxt:DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public SpendSmartDbConetxt(DbContextOptions<SpendSmartDbConetxt> options) :base(options) 
        {
            
        }

    }
}
