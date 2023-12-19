using BusinessProcessControl;
using System;
using System.Collections.Generic;

namespace ProcessControl_ContinousCharge
{
    
    public class ContinousCharge : AbstractBusinessTask, IBusinessTask
    {

        public event OnReportMessage ReportMessage;

        #region Properties

        #endregion

        #region Constructor

        public ContinousCharge(IList<ITask> pList)
        {
            ListTasks = pList;
            //https://docs.microsoft.com/es-es/dotnet/api/system.func-1?view=netcore-3.1

        }

        public ContinousCharge()
        {
            ListTasks = new List<ITask>();
        }

        #endregion

        #region Methods

        public void Run()
        {
         
            Start();

            Execute();

            End();
        }

        private void Start()
        {
            ReportMessage("Process start");
        }

        
        public void AddTask(ITask task)
        {
            this.ListTasks.Add(task);            
        }

        private void Execute()
        {
            foreach (ITask item in ListTasks)
            {
                item.Execute();
                ReportMessage(string.Format("Task {0} ended", item.Name));
            }
        }

        private void End()
        {
            ReportMessage("Process end");
        }

        #endregion

    }


}
