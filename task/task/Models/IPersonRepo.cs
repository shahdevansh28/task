namespace task.Models
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetAllPerson();
        Person Add(Person person);
    }
}
