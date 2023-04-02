using Microsoft.EntityFrameworkCore;


namespace Vidly.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext() { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Renting> Rentings { get; set; }
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Customer>().HasOne(p => p.MembershipType).HasForeignKey(p => p.MembershipType)
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MyDatabase"));
                optionsBuilder.UseSqlServer("Server=(local);Initial Catalog=Vidly;Persist Security Info=False;User ID=laowang;Password=Worinima.1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

            }
        }

    }



}
