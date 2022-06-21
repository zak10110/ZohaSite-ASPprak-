namespace ZohaSite
{
    public class Productc
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Price { get; set; }
        public string Img { get; set; }

        public Productc(int id, string name, string price, string img)
        {
            Id = id;
            Name = name;
            Price = price;
            Img = img;
        }
    }
}
