using System.Management.Automation.Language;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine($"Loop {i++}");
                //Currently used memory
                Console.WriteLine($"Memory: {GC.GetTotalMemory(false)}");
                Task.Delay(3000).Wait();
                await powershell.Trigger();
                

            }
            
        }
    }
}
