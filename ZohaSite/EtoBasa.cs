using Microsoft.EntityFrameworkCore;
namespace ZohaSite
{
    public static class EtoBasa
    {

        public static void CreateDataBase()
        {

            using (DBContext db = new DBContext())
            {
                db.SaveChanges();
            }

        }



    }
}
