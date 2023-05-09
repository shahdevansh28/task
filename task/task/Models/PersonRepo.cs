namespace task.Models
{
    public class PersonRepo:IPersonRepo
    {
        private readonly AppDbContext context;

        public PersonRepo(AppDbContext context)
        {
            this.context = context;
        }

        IEnumerable<Person> IPersonRepo.GetAllPerson()
        {
            return context.Persons;
        }

        Person IPersonRepo.Add(Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();
            return person;
        }
    }
}
