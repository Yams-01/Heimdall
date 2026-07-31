using System.ComponentModel;
using System.Diagnostics;

namespace Heimdall
{
    class Program
    {

        private static void WriteColor(string message, ConsoleColor clr)
        {
            Console.ForegroundColor = clr;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        static void PrintProcess(Process processes)
        {
            try
            {

                Console.WriteLine($"{processes.Id} --- {processes.ProcessName} --- {processes.StartTime}");
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Win32Exception win )
            {
                WriteColor($"{win.Message} : {processes.ProcessName}", ConsoleColor.Red);
            }

        }
         

        static void Main()
        {
            Process[] allProccesses = Process.GetProcesses();
            Process activeProc = Process.GetCurrentProcess();

            foreach (Process process in allProccesses)
            {
                PrintProcess(process);
                
            }
            
        }
    }
}