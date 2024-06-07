namespace DomainModels
{
    public class Restaurant : BaseClass
    {
        public string RestaurantName { get; set; }
        public List<MenuItem> Menu { get; set; }
    }
}
