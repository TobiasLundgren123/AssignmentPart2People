using AssignmentPart2People.Models.Repos;
using AssignmentPart2People.Models.ViewModels;

namespace AssignmentPart2People.Models.Services
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepo _peopleRepo;
        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }

        public Person Add(CreatePersonViewModel createPerson)
        {
            if (string.IsNullOrWhiteSpace(createPerson.Name) || string.IsNullOrWhiteSpace(createPerson.CityName))
            { throw new ArgumentException("Name and CityName must be entered"); }

            Person person = new Person()
            {
                Name = createPerson.Name,
                PhoneNumber = createPerson.PhoneNumber,
                CityName = createPerson.CityName
             };
            person = _peopleRepo.Create(person);
            return person;
        }

        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public Person FindById(int id)
        {
            return _peopleRepo.Read(id);
        }
        public List<Person> Search(string search)
        {
            List<Person> searchList = new List<Person>();
            foreach(Person person in _peopleRepo.Read())
            {
                //case insensitive
                if(person.Name == search || person.CityName == search)
                {
                    searchList.Add(person);
                }
                
            }
            return searchList;
        }
        public bool Edit(int id, CreatePersonViewModel person)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            Person person= _peopleRepo.Read(id);
            bool success = _peopleRepo.Delete(person);
            return success;
        }


    }
}
