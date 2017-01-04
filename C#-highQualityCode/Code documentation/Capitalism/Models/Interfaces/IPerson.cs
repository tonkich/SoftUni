namespace Capitalism.Models.Interfaces
{
    /// <summary>
    /// IPerson interface containing the properties first and last name of a given person.
    /// </summary>
    public interface IPerson
    {
        string FirstName { get; }

        string LastName { get; }
    }
}