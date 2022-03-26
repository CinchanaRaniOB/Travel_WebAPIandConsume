using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel_WebAPI_CRUD.IService;
using Travel_WebAPI_CRUD.Models;

namespace Travel_WebAPI_CRUD.Service
{
    public class TravelService : ITravelService
    {
        private readonly DbforWebAPIContext dbContext;

        public TravelService(DbforWebAPIContext db)
        {
            dbContext = db;
        }
        public IEnumerable<Travel> GetTravel()
        {
            var travel = dbContext.Travel.ToList();
            return travel;
        }

        public Travel AddTravel(Travel tra)
        {
            dbContext.Travel.Add(tra);
            dbContext.SaveChanges();
            return tra;
        }

        public Travel UpdateTravel(Travel travel)
        {
            dbContext.Entry(travel).State = EntityState.Modified;
            dbContext.SaveChanges();
            return travel;
        }

        public Travel DeleteTravel(int id)
        {
            var tra = dbContext.Travel.Find(id);
            dbContext.Travel.Remove(tra);
            dbContext.SaveChanges();
            return tra;
        }
    }
}
