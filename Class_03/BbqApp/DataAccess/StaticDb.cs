using DomainModels;

namespace DataAccess
{
    static class StaticDb
    {
        public static Restaurant restaurant = new Restaurant() { 
        Id = 1,
        Menu = new List<MenuItem>
        {
            new MenuItem()
            {
                Id = 1,
                Name = "10ka",
                Description = "10 kebapi",
                Price = 200
            }, new MenuItem()
            {
                Id = 2,
                Name = "5ka",
                Description = "15 kebapi",
                Price = 100
            }, new MenuItem()
            {
                Id = 3,
                Name = "Coca Cola",
                Description = "Coca Cola 250ml",
                Price = 70
            },
        }
        };
    }
}
