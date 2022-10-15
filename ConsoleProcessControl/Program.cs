using System;
using BusinessProcessControl;
using FabricatorProcessControl;

namespace ConsoleProcessControl
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            
            var btProcessFab = new Fabricator();
            IBusinessTask bTask = btProcessFab.CreateBusinessTask();            
            bTask.ReportMessage += Bt_ReportMessage;

            bTask.AddTask(new ProcessControl_ContinousCharge.ProcessFile());
            bTask.AddTask(new ProcessControl_ContinousCharge.ReadFile());
            bTask.AddTask(new ProcessControl_ContinousCharge.ResumeFile());

            bTask.Run();

            Console.ReadKey();
                        
        }


        private static void Bt_ReportMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
