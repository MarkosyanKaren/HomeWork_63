using HomeWork_63.DAL.Entities;
using HomeWork_63.DAL.Interfaces;

namespace HomeWork_63.DAL.Repositories;

public class PropertyRepo:IPropertyRepo
{
    private SchoolDBContext _dbContext;

    public PropertyRepo(SchoolDBContext schoolDBContext)
    {
        _dbContext = schoolDBContext;
    }

    public List<Property> GetProperties()
    {
        return _dbContext.Properties.ToList();
    }


    public void AddProperty(string name, int value, int count)
    {
        var newProperty = new Property
        {
            Name = name,
            Value = value,
            Count = count
        };

        _dbContext.Properties.Add(newProperty);
        _dbContext.SaveChanges();

    }



    public void UpdateCount(string Id, int count)
    {
        var updatedId = Guid.Parse(Id);
        var updatetData = _dbContext.Properties.FirstOrDefault(x => x.Id == updatedId);

        updatetData.Count = count;

        _dbContext.Properties.Update(updatetData);
        _dbContext.SaveChanges();
    }


    public void DeleteProperty(string Id)
    {
        var deletedId = Guid.Parse(Id);
        var deletedData = _dbContext.Properties.FirstOrDefault(x =>x.Id == deletedId);

        _dbContext.Properties.Remove(deletedData);
        _dbContext.SaveChanges();
    }
}
