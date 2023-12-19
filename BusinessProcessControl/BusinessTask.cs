using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessProcessControl
{

    public delegate void OnReportMessage(string message);

    public class BusinessTask : AbstractBusinessTask, IBusinessTask
    {

        public event OnReportMessage ReportMessage;

        #region Properties

        #endregion

        #region Constructor

        public BusinessTask(IList<ITask> pList)
        {
            ListTasks = pList;
            //https://docs.microsoft.com/es-es/dotnet/api/system.func-1?view=netcore-3.1

        }

        public BusinessTask()
        {
            ListTasks = new List<ITask>();
        }

        #endregion

        #region Methods

        private void Start()
        {
            ReportMessage("Process start");
        }

        public void Run()
        {
            Start();

            Execute();

            End();
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

        public void AddTask(ITask processFile)
        {
            if (ListTasks==null) ListTasks = new List<ITask>();
            this.ListTasks.Add(processFile);
        }

        #endregion

    }

}
