using System.Collections.Generic;

namespace Capitalism.Models.Interfaces
{
    /// <summary>
    /// ICompanyStructure interface containing Name property and a collection of employees.
    /// </summary>
    public interface ICompanyStructure
    {
        string Name { get; }

        ICollection<IEmployee> Employees { get; }
    }
}
