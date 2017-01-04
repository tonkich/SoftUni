using System.Collections.Generic;

namespace Capitalism.Interfaces
{
    /// <summary>
    /// ICommand interface contains name of commands and a list of input parameters.
    /// </summary>
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}
