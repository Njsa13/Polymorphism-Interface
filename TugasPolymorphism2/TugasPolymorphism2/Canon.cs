using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism2
{
    public class Canon : IPrinterWindows
    {
        public void Show(PrinterWindows printer)
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }

        public void Print(PrinterWindows printer)
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}