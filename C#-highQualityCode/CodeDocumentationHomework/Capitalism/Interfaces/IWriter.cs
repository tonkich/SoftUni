namespace Capitalism.Interfaces
{
    /// <summary>
    /// IWriter interface enables printing commands on the console.
    /// </summary>
    public interface IWriter
    {
        void WriteLine(string output);
        void WriteLine(string format, params object[] args);
    }
}
