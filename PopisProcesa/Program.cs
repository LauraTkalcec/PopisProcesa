using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;

namespace PopisProcesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n    Popis 10 procesa:    \n");
            Process[] procesi = Process.GetProcesses();

            //ispisati popis procesa
            var popisProcesa = System.Diagnostics.Process.GetProcesses();
            var proces = popisProcesa[0];
            for(int j=0;j<popisProcesa.Length;j++)
            {
                for(int i=0;i<popisProcesa.Length;i++)
                {
                    var p1 = popisProcesa[i];
                    var p2 = popisProcesa[j];

                    if(popisProcesa[i].WorkingSet64>popisProcesa[j].WorkingSet64)
                    {
                        var drzi = popisProcesa[i];
                        popisProcesa[i] = popisProcesa[j];
                        popisProcesa[j] = drzi;
                    }
                }
            }

            for (int i=0; i<10; i++)
            {
                var p = popisProcesa[i];
                Console.WriteLine("{0}-{1}", p.WorkingSet64, p.ProcessName);
            }
        }
    }
}
