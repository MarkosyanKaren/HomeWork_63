using HomeWork_63.DAL;
using HomeWork_63.DAL.Entities;
using HomeWork_63.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_63.Controllers
{
    [ApiController]
    [Route("api/Staff")]
    public class StaffController : Controller
    {
        private SchoolDBContext _dbContext;
        private IStaffRepo _staffRepo;

        public StaffController(SchoolDBContext schoolDBContext, IStaffRepo staffRepo)
        {
            _dbContext = schoolDBContext;
            _staffRepo = staffRepo;
        }

        [HttpGet]
        public List<Staff> GetAllStaff()
        {
            return _staffRepo.GetAllStaff();
        }

        [HttpPost]
        public void CreatStaffMember(string position, string name, string surname, string phoneNumber)
        {
            _staffRepo.CreatStaffMember(position, name, surname, phoneNumber);
        }


        [HttpPut]
        public void UpdatePhoneNumber(string Id, string phoneNumber)
        {
            _staffRepo.UpdatePhoneNumber(Id, phoneNumber);
        }


        [HttpDelete]
        public void DeleteStaffMember(string Id)
        {
            _staffRepo.DeleteStaffMember(Id);
        }
    }
}
