using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implemetation
{
    public class RestaurantRepository<T> : IRepository<Restaurant>
    {
        public void Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAll()
        {
            return new List<Restaurant> { StaticDb.restaurant };
        }

        public Restaurant GetById(int id)
        {
            return StaticDb.restaurant;
        }

        public void Save(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant entity)
        {
            throw new NotImplementedException();
        }
    }
}
