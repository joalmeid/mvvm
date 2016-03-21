using System.Collections.Generic;
using System.Linq;
using AdvancedSample.Models;

namespace AdvancedSample.Services
{
    public class DesignDataService: IDataService
    {
        public IEnumerable<Person> GetItems()
        {
            var people = from n in Enumerable.Range(1, 100)
                         select new Person
                         {
                             Name = "Design Time First Name " + n,
                             Surname = "Design Time Last Name " + n
                         };

            return people;
        }
    }
}
