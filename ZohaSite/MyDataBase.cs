using Microsoft.EntityFrameworkCore;



namespace ZohaSite
{
    public class MyDataBase : DbContext
    {
        public DbSet<Productc> Productc { get; set; } = null!;
        public DbSet<User> User { get; set; } = null!;
        public DbSet<Cart> Cart {get;set;}=null!;

        public MyDataBase()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=aspdatabase.cxp0pm4y0ro5.us-east-1.rds.amazonaws.com;Initial Catalog=EtoBasa;User ID=admin;Password=qwerty123");

        }



    }
}
