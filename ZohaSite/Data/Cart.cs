namespace ZohaSite
{ 
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Price { get; set; } = String.Empty;
        public string Img { get; set; } = String.Empty;
        public int UserID { get; set; }
        public int ProductID { get; set; }

    }
}
