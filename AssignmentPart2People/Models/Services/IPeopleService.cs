using AssignmentPart2People.Models.ViewModels;

namespace AssignmentPart2People.Models.Services
{
    public interface IPeopleService
    {
    Person Add(CreatePersonViewModel person);
    List<Person> All();
    List<Person> Search(string search);
    Person FindById(int id);
    bool Edit(int id, CreatePersonViewModel person);
    bool Remove(int id);
    }
}
