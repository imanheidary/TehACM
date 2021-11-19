using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using Repository.Repository;
using Repository.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TehBasijACMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DatabaseCTX db;
        PerosnRepository repo;
        public WeatherForecastController(DatabaseCTX _db)
        {
            db = _db;
            repo = new PerosnRepository(db);
        }
        public async Task<ResultMessageVM> Insert()
        {
            return await repo.Add(new Model.Person {
            Id=0,
            Family="HS",
            Name="Iman",
            Username="i2346"
            });
        }

        public async Task<List<Person>> GetAllPerson() {
            return await repo.GetAll();
        }
    }
}
