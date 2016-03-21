using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedSample.Models;

namespace AdvancedSample.Services
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
