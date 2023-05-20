using BlazorDemo444.Data;
using BlazorDemo444.Model;

namespace BlazorDemo444.Service;

public class PersonService : IPersonService
{
    private readonly AppsContext _ctx;
    public PersonService(AppsContext ctx)
    {
        _ctx = ctx;
    }
    public bool AddUpdate(Person person)
    {
        try
        {
            if (person.Id == 0) { _ctx.Persons.Add(person); } else { _ctx.Persons.Update(person); }
            _ctx.SaveChanges();
            return true; 
        }
        catch (Exception ex) {
            return false;
        }
    }

    public bool Delete(int id)
    {
        try {
            var person = FindById(id);
            if (person == null) { return false; }

            _ctx.Persons.Remove(person);
            _ctx.SaveChanges();
            return true;
        } catch (Exception ex)
        {
            return false;
        }
    }

    public List<Person> FindAll()
    {
        return _ctx.Persons.ToList();
    }

    public Person FindById(int id)
    {
        return _ctx.Persons.Find(id);
    }
}
