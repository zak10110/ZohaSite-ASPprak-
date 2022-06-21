using Microsoft.EntityFrameworkCore;

namespace ZohaSite
{
    public class DataBase
    {
        public DbSet<Productc> Furniture { get; set; } = null!;
        public DbSet<User> Client { get; set; } = null!;

    }
}
