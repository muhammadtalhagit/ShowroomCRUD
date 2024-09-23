using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShowroomApi.Models;
using ShowroomApi.Data;
using ShowroomApi.Models.DTOs;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShowroomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ShowroomContext db;

        public CompanyController(ShowroomContext _db)
        {
            db = _db;
        }

        [HttpGet]

        public IActionResult GetManufactures()
        {
            return Ok(db.Manufacturers.ToList());
        }

        [HttpPost]
        public IActionResult AddManufacturer(ManufacturerDTO data)
        {
            Manufacturer manufacturer = new Manufacturer()
            {
                Name = data.Name,
                City = data.City,
            };

            var addManufacturer = db.Manufacturers.Add(manufacturer);
            db.SaveChanges();
            return Ok(addManufacturer);
        }

        [HttpPut]
        public IActionResult EditManufacturer(int id, ManufacturerDTO data)
        {
            
            var ManufacturertoUpdate = db.Manufacturers.Find(id);

            ManufacturertoUpdate.Name = data.Name;
            ManufacturertoUpdate.City = data.City;

            var updatetoManufacturer = db.Manufacturers.Update(ManufacturertoUpdate);
            db.SaveChanges();
            return Ok(updatetoManufacturer.Entity);
        }

        [HttpDelete]
        public IActionResult DeleteManufacturer(int id)
        {

            var ManufacturertoDelete = db.Manufacturers.Find(id);
             
            var DeletetoManufacturer = db.Manufacturers.Remove(ManufacturertoDelete);
            db.SaveChanges();
            return Ok(DeletetoManufacturer.Entity);
        }
    }
}