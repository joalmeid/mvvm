using System.Collections.Generic;
using AdvancedSample.Models;

namespace AdvancedSample.Services
{
    public interface IDataService
    {
        IEnumerable<Person> GetItems();
    }
}
