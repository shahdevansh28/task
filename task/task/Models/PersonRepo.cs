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
            //Check if Id is exist or not
            IEnumerable<Person> query = context.Persons.Where(p => p.Id == person.Id);
            Console.WriteLine(query.Count());

            /*var temp = context.Persons.Where(p => p.Id == person.Id).ToList().Any();*/
            if (query.Count() == 0)
            {
                context.Persons.Add(person);
                context.SaveChanges();
                return person;
            }
            else
            {
                person = null;
                return person;
            }
        }
    }
}
