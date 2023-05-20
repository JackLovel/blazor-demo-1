using BlazorDemo444.Model;

namespace BlazorDemo444.Service;

public interface IPersonService
{
    bool AddUpdate(Person person);
    bool Delete(int id);
    Person FindById(int id);
    List<Person> FindAll();
}
