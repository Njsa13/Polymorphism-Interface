using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism2
{
    public class Epson : IPrinterWindows
    {
        public void Show(PrinterWindows printer)
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public void Print(PrinterWindows printer)
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}