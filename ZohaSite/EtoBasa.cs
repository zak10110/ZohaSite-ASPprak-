using Microsoft.EntityFrameworkCore;
namespace ZohaSite
{
    public static class EtoBasa
    {

        public static void CreateDataBase()
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.SaveChanges();
                InicializeLists();
            }

        }

        public static List<Productc> productcs { get; set; } = new List<Productc>();
        public static List<Cart> carts { get; set; } = new List<Cart>();
        public static List<User> users { get; set; } = new List<User>();

        public static void InicializeLists()
        {
            using (MyDataBase db = new MyDataBase())
            {
                productcs = db.Productc.ToList();
                carts = db.Cart.ToList();
                users = db.User.ToList();
            }
        }

        public static void AddUser(string login, string password,bool IsAdmin)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.User.Add(new User { Login = login, Pass = password, IsAdmin = IsAdmin });
                db.SaveChanges();
                InicializeLists();
            }
        }
        public static void AddCart(Cart basket)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.Cart.Add(basket);
                db.SaveChanges();
                InicializeLists();
            }
        }

        public static void AddProduct(string price, string image, string name,string category)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.Productc.Add(new Productc { Price = price, Img = image, Name = name,Category=category });
                db.SaveChanges();
                InicializeLists();
            }
        }

    }
}
