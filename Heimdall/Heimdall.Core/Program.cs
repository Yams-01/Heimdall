using System.Diagnostics;

namespace Heimdall.Core;

  
    public class Program
    {
        static void Main()
        {
            var allProcesses = Process.GetProcesses();

            foreach (var process in allProcesses)
            {
               ProcessInspector.PrintProcess(process);
                
            }
            
        }
    }
