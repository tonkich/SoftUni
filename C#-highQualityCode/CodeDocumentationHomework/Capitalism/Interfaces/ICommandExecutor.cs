namespace Capitalism.Interfaces
{
    /// <summary>
    /// ICommandExecutor interface enables executing a number of commands from the engine.
    /// </summary>
    public interface ICommandExecutor
    {
        string ExecuteCommand(ICommand command);
    }
}
