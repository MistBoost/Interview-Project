using Microsoft.EntityFrameworkCore;

namespace InterviewProject.Model
{
    public class InterviewDbContext : DbContext
    {
        //property that stores data pulled from database as a data model class
        public DbSet<Interview> Interviews { get; set; }
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //name of the table to copy data from
            modelBuilder.Entity<Interview>().ToTable("Interview");
        }
    }
}
