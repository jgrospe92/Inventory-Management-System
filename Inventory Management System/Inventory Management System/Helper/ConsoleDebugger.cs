using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Helper
{
    public class ConsoleDebugger
    {

    

        public static void consoleDebugger(string data)
        {
            AllocConsole();
            [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
