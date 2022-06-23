using Microsoft.EntityFrameworkCore;
using ZohaSite;

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
        public static List<Client> clients { get; set; } = new List<Client>();

        public static void InicializeLists()
        {
            using (MyDataBase db = new MyDataBase())
            {
                productcs = db.Productc.ToList();
                carts = db.Cart.ToList();
                clients = db.Client.ToList();
                db.SaveChanges();
            }
        }

        public static void AddUser(string login, string password, bool IsAdmin)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.Client.Add(new Client { Login = login, Pass = password, IsAdmin = IsAdmin });
                db.SaveChanges();
                InicializeLists();
            }
        }
        public static void ProductRemove(Productc furniture)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.Productc.Remove(furniture);
                db.SaveChanges();
                InicializeLists();
            }
        }
        public static void ClientRemove(Client client)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.Client.Remove(client);
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

        public static void AddProduct(string price, string image, string name, string category)
        {
            using (MyDataBase db = new MyDataBase())
            {
                db.Productc.Add(new Productc { Price = price, Img = image, Name = name, Category = category });
                db.SaveChanges();
                InicializeLists();
            }
        }

    }
}
