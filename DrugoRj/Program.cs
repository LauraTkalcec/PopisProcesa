using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DrugoRj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n   Popis procesa 2:    \n");
            Process[] procesi = Process.GetProcesses();
            foreach(Process p in procesi)
            {
                Console.WriteLine("\n");
                Console.WriteLine("identifikator:{0}", p.Id);
                Console.WriteLine("Naziv procesa:{0}", p.ProcessName);
                Console.WriteLine("Proces radi:{0}", p.Responding);
                Console.WriteLine("Broj dretvi:{0}", p.Threads.Count);
                Console.WriteLine("Kolicina radne memorije: {0}  MB", p.WorkingSet64);
            }

        }
    }
}
