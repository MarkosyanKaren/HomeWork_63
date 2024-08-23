using HomeWork_63.DAL;
using HomeWork_63.DAL.Entities;
using HomeWork_63.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_63.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        private SchoolDBContext _dbContext;
        private IStudentRepo _studentRepo;

        public StudentController(SchoolDBContext schoolDBContext, IStudentRepo studentRepo)
        {
            _dbContext = schoolDBContext;
            _studentRepo = studentRepo;
        }

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return _studentRepo.GetAllStudents();
        }

        [HttpPost]
        public void AddStudent(string classNum, string surname, string name, string phoneNumber)
        {
            _studentRepo.AddStudent(classNum, surname, name, phoneNumber);
        }

        [HttpPut]
        public void UpdatePhoneNumber(string Id, string phoneNumber)
        {
            _studentRepo.UpdatePhoneNumber(Id, phoneNumber);
        }

        [HttpDelete]
        public void DeletePhoneNumber(string Id)
        {
            _studentRepo.DeletedStudent(Id);
        }
    }
}
