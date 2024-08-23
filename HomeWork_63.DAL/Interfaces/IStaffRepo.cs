using HomeWork_63.DAL.Entities;

namespace HomeWork_63.DAL.Interfaces;

public interface IStaffRepo
{
    public List<Staff> GetAllStaff();
    public void CreatStaffMember(string position, string name, string surname, string phoneNumber);
    public void UpdatePhoneNumber(string Id, string phoneNumber);
    public void DeleteStaffMember(string Id);

}
