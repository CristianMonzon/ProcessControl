using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessProcessControl;

namespace ConsoleProcessControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO. Add Fabricator
            BusinessTask bt = new BusinessTask();
            bt.ReportMessage += Bt_ReportMessage;
            bt.Run();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }


        private static void Bt_ReportMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
