using System.Collections.Generic;
using Template10Sample.Models;

namespace Template10Sample.Services
{
    public class DataService: IDataService
    {
        public IEnumerable<Person> GetItems()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person {Name = "Peter", Surname = "Parker"});
            people.Add(new Person {Name = "Tony", Surname = "Stark"});
            people.Add(new Person {Name = "Steve", Surname = "Rodgers"});

            return people;
        }
    }
}
