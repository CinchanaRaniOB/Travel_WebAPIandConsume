using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel_WebAPI_CRUD.IService;
using Travel_WebAPI_CRUD.Models;

namespace Travel_WebAPI_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        private readonly ITravelService travelService;
        public TravelController(ITravelService travel)
        {
            travelService = travel;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Travel/GetTravel")]
        public IEnumerable<Travel> GetTravel()
        {
            return travelService.GetTravel();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Travel/AddTravel")]
        public Travel AddTravel(Travel tra)
        {
            return travelService.AddTravel(tra);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Travel/UpdateTravel")]
        public Travel UpdateTravel(Travel travel)
        {
            return travelService.UpdateTravel(travel);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Travel/DeleteTravel")]
        public Travel DeleteTravel(int id)
        {
            return travelService.DeleteTravel(id);
        }
    }
}
