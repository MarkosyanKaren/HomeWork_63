using HomeWork_63.DAL;
using HomeWork_63.DAL.Entities;
using HomeWork_63.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_63.Controllers
{
    [ApiController]
    [Route("api/Property")]
    public class PropertyController : Controller
    {
        private SchoolDBContext _schoolDBContext;
        private IPropertyRepo _propertyRepo;

        public PropertyController(SchoolDBContext schoolDBContext, IPropertyRepo propertyRepo)
        {
            _schoolDBContext = schoolDBContext;
            _propertyRepo = propertyRepo;
        }

        [HttpGet]
        public List<Property> GetProperties()
        {
            return _propertyRepo.GetProperties();
        }

        [HttpPost]
        public void AddProperty(string name, int value, int count)
        {
            _propertyRepo.AddProperty(name, value, count);
        }

        [HttpPut]
        public void UpdateCount(string Id, int count)
        {
            _propertyRepo.UpdateCount(Id, count);
        }

        [HttpDelete]
        public void DeleteProperty(string Id)
        {
            _propertyRepo.DeleteProperty(Id);
        }
    }
}
