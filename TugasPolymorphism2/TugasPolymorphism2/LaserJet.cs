using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism2
{
    public class LaserJet : IPrinterWindows
    {
        public void Show(PrinterWindows printer)
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }

        public void Print(PrinterWindows printer)
        {
            Console.WriteLine("Laserjet printer printing....");
        }
    }
}