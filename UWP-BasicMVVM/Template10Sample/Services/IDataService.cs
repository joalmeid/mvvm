using System.Collections.Generic;
using Template10Sample.Models;

namespace Template10Sample.Services
{
    public interface IDataService
    {
        IEnumerable<Person> GetItems();
    }
}
