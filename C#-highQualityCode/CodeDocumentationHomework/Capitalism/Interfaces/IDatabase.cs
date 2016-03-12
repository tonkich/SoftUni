using Capitalism.Models;
using Capitalism.Models.Interfaces;
using System.Collections.Generic;

namespace Capitalism.Interfaces
{
    /// <summary>
    /// IDatabase interface contains a collection of companies and a dictionary of the total salaries.
    /// </summary>
    public interface IDatabase
    {
        ICollection<Company> Companies { get; }

        IDictionary<IPaidPerson, decimal> TotalSalaries { get; }
    }
}
