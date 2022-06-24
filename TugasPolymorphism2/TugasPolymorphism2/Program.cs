using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer = new PrinterWindows();

            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1...3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            IPrinterWindows iprinter;
            if (nomorPrinter == 1)
            {
                iprinter = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                iprinter = new Canon();
            }
            else
            {
                iprinter = new LaserJet();
            }

            iprinter.Show(printer);
            iprinter.Print(printer);

            Console.ReadKey();
        }
    }
}
