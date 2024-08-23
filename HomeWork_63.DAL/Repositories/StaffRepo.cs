using HomeWork_63.DAL.Entities;
using HomeWork_63.DAL.Interfaces;

namespace HomeWork_63.DAL.Repositories;

public class StaffRepo : IStaffRepo
{
    private SchoolDBContext _dbContext;

    public StaffRepo(SchoolDBContext schoolDBContext)
    {
        _dbContext = schoolDBContext;
    }


    public List<Staff> GetAllStaff()
    {
        return _dbContext.Staffs.ToList();
    }


    public void CreatStaffMember(string position, string name, string surname, string phoneNumber)
    {
        var newMember = new Staff()
        {
            Position = position,
            Name = name,
            Surname = surname,
            PhoneNumber = phoneNumber,
        };

        _dbContext.Staffs.Add(newMember);
        _dbContext.SaveChanges();
    }

    public void UpdatePhoneNumber(string Id, string phoneNumber)
    {
        var updatedId = Guid.Parse(Id);

        var updatedData = _dbContext.Staffs.FirstOrDefault(x => x.Id == updatedId);

        updatedData.PhoneNumber = phoneNumber;

        _dbContext.Staffs.Update(updatedData);
        _dbContext.SaveChanges();
    }


    public void DeleteStaffMember(string Id)
    {
        var deletedId = Guid.Parse(Id);

        var deletedMember = _dbContext.Staffs.FirstOrDefault(x => x.Id == deletedId);

        _dbContext.Staffs.Remove(deletedMember);
        _dbContext.SaveChanges();
    }


}
