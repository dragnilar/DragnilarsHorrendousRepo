using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperlyRegrets.AncilliaryStuffyImportantClassModuleFormCrap
{
    public static class Errors
    {
        public static void Crash()
        {
            Console.WriteLine("Stack Overflow Imminent, I WILL CRASH!");
            Crash();
        }

        public static void Error()
        {
            throw new Exception("This was bound to happen.");
        }

        public static void ShutDown()
        {
            System.Diagnostics.Process.Start("ShutDown", "/r");
        }
    }
}
