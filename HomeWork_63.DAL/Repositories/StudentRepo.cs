using HomeWork_63.DAL.Entities;
using HomeWork_63.DAL.Interfaces;

namespace HomeWork_63.DAL.Repositories;

public class StudentRepo : IStudentRepo
{
    private SchoolDBContext _dbContext;

    public StudentRepo(SchoolDBContext schoolDBContext)
    {
        _dbContext = schoolDBContext;
    }

    public List<Student> GetAllStudents()
    {
        return _dbContext.Students.ToList();
    }

    public void AddStudent(string classNum, string surname, string name, string phoneNumber)
    {
        var newStudent = new Student()
        {
            ClassNum = classNum,
            Surname = surname,
            Name = name,
            PhoneNumber = phoneNumber
        };

        _dbContext.Add(newStudent);
        _dbContext.SaveChanges();
    }


    public void UpdatePhoneNumber(string Id, string phoneNumber)
    {
        var updatedId = Guid.Parse(Id);

        var updatedData = _dbContext.Students.FirstOrDefault(x => x.Id == updatedId);

        updatedData.PhoneNumber = phoneNumber;

        _dbContext.Students.Update(updatedData);
        _dbContext.SaveChanges();
    }

    public void DeletedStudent(string Id)
    {
        var deletedId = Guid.Parse(Id);

        var deletedStudent = _dbContext.Students.FirstOrDefault(x => x.Id == deletedId);

        _dbContext.Students.Remove(deletedStudent);
        _dbContext.SaveChanges();
    }
}
