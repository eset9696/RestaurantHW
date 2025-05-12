namespace RestaurantHW.Models
{
    public class MenuItem
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public int? Weight { get; set; }

        public MenuItem(int id, string name, string descr, double price, int weight)
        {
            Id = id;
            Name = name;
            Description = descr;
            Price = price;
            Weight = weight;
        }
    }
}
