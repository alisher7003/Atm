namespace Atm
{
    internal class V1Logger : ILogger
    {
        public void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
        }
    }
}
