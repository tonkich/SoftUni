namespace Capitalism.Models.Interfaces
{
    /// <summary>
    /// IEmployee interface inheriting the IPaidPerson interface. Adds SalaryFactor and Department properties.
    /// </summary>
    public interface IEmployee : IPaidPerson
    {
        Department Department { get; set; }

        double SalaryFactor { get; }
    }
}