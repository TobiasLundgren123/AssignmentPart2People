namespace AssignmentPart2People.Models.Repos
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        static int idCounter = 0;
        static List<Person> personList = new List<Person>();
        public Person Create(Person person)
        {
            person.Id = ++idCounter;
            personList.Add(person);
            return person;
        }

        public List<Person> Read()
        {
            return personList;
        }

        public Person Read(int id)
        {
            Person person = null;
            foreach (Person p in personList)
            {
                if (p.Id == id)
                {
                    person = p;
                    break;
                }
            }
            return person;
        }

        public bool Update(Person person)
        {
            Person originalPerson = Read(person.Id);
            if (originalPerson != null)
            {
                originalPerson.Name = person.Name;
                originalPerson.CityName = person.CityName;
                originalPerson.PhoneNumber = person.PhoneNumber;
                return true;
            } else
            {
                return false;
            }
        }

        public bool Delete(Person person)
        {
            if(person!=null)
            {
                personList.Remove(person);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
