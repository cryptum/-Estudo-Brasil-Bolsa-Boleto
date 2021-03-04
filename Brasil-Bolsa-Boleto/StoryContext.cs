using Microsoft.EntityFrameworkCore;

namespace Brasil_Bolsa_Boleto
{
    public class StoryContext: DbContext
    {
        public StoryContext(DbContextOptions<StoryContext> options): base(options){}

        //public DbSet<>  { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder
        }
    }
}