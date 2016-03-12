using System.Collections.Generic;

namespace Capitalism.Models.Interfaces
{
    /// <summary>
    /// IBoss interface contains collection of subordinate employees.
    /// </summary>
    public interface IBoss
    {
        ICollection<IEmployee> SubordinateEmployees { get; }
    }
}
