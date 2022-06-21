namespace ZohaSite
{
    public static class ProductList
    {
        public static List<Productc> productcs { get; set; }=new List<Productc>();

        public static void AddList(List<Productc> productc)
        {

            productcs = productc;
        
        
        }

    }
}
