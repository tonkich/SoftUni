namespace Capitalism.Models.Interfaces
{
    /// <summary>
    /// IPaidPerson interface inheriting the IPerson interface, adds salary property.
    /// </summary>
    public interface IPaidPerson: IPerson
    {
        decimal Salary { get; set; }
    }
}
