using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap
{
    public static class Errors
    {

        public static void Crash()
        {
            IntPtr p = Marshal.AllocHGlobal(1);
            for (int i = 0; i < 10000000; ++i)
            {
                p = new IntPtr(p.ToInt64() + 1);
                Marshal.WriteByte(p, 0xFF);
            }
        }

        public static void ShutDown()
        {
            System.Diagnostics.Process.Start("ShutDown", "/r");
        }

        public static void ThrowRandomException()
        {

            var exceptionNumber = new Faker().Random.Int(0,10);

            switch (exceptionNumber)
            {
                case 0:
                    throw new XmlSyntaxException();
                case 1:
                    throw new DivideByZeroException();
                case 2:
                    throw new FieldAccessException();
                case 3:
                    throw new DuplicateNameException();
                case 4:
                    throw new COMException();
                case 5:
                    throw new IOException();
                case 6:
                    throw new FileNotFoundException();
                case 7:
                    throw new OutOfMemoryException();
                case 8:
                    throw new ServerException();
                case 9:
                    throw new TaskCanceledException();
                case 10:
                    throw new InvalidComObjectException();
                default:
                    throw new Exception("SOMETHING HAPPENED!!!");
            }

        }
    }
}
