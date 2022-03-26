using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel_WebAPI_CRUD.Models;

namespace Travel_WebAPI_CRUD.IService
{
    public interface ITravelService
    {
        IEnumerable<Travel> GetTravel();
        Travel AddTravel(Travel tra);
        Travel UpdateTravel(Travel travel);
        Travel DeleteTravel(int id);
    }
}
