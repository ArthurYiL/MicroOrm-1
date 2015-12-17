using System.Data.Entity;

namespace MicroOrm.Entities.DBContext
{
    public class MicroOrmContext : DbContext
    {
        //public DbSet<CardTypes> CardTypeses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MicroOrmContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
