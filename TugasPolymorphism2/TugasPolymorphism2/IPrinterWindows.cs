using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism2
{
    public interface IPrinterWindows
    {
        void Show(PrinterWindows printer);
        void Print(PrinterWindows printer);
    }
}
