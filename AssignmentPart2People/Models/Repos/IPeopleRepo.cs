namespace AssignmentPart2People.Models.Repos
{
    public interface IPeopleRepo
    {

        //Crud
        // C
        Person Create(Person person);
        // R
        List<Person> Read();
        Person Read(int id);
        // U
        bool Update(Person person);
        // D
        bool Delete(Person person);
    }
}
