using HomeWork_63.DAL.Entities;

namespace HomeWork_63.DAL.Interfaces;

public interface IPropertyRepo
{
    public List<Property> GetProperties();
    public void AddProperty(string name, int value, int count);
    public void UpdateCount(string Id, int count);
    public void DeleteProperty(string Id);
}
