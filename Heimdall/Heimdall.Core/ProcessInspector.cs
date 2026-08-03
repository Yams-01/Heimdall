using System.Diagnostics;
using System.ComponentModel;
namespace Heimdall.Core;

public static class ProcessInspector
{
    private static void WriteColor(string message, ConsoleColor clr)
    {
        Console.ForegroundColor = clr;
        Console.WriteLine(message);
        Console.ResetColor();
    }


    public static void PrintProcess(Process process)
    {

        try
        {
            string description = process.MainModule?.FileVersionInfo?.FileDescription;
            string name = string.IsNullOrWhiteSpace(description) ? process.ProcessName : description; 
                
            Console.WriteLine($"{process.Id} --- {name} --- {process.StartTime}");
        }
        catch (NotSupportedException e)
        {
            WriteColor($"{e}", ConsoleColor.Blue);
        }
        catch (Win32Exception win)
        {
            WriteColor($"{win.Message} : {process.ProcessName}", ConsoleColor.Red);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
          

    }
}