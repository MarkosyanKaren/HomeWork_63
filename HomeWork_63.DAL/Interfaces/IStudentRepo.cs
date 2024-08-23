using HomeWork_63.DAL.Entities;

namespace HomeWork_63.DAL.Interfaces;

public interface IStudentRepo
{
    public List<Student> GetAllStudents();
    public void AddStudent(string classNum, string surname, string name, string phoneNumber);
    public void UpdatePhoneNumber(string Id, string phoneNumber);
    public void DeletedStudent(string Id);
}
