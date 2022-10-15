using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessProcessControl
{

    //public delegate void Func<LazyValue>();

    public delegate void OnReportMessage(string message);


    public class BusinessTask : IBusinessTask
    {

        public event OnReportMessage ReportMessage;

        #region Properties

        private IList<ITask> ListTasks; 

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
            ReadTask();

            Start();

            Execute();

            End();
        }

        private void ReadTask()
        {
            this.ListTasks.Add(new ReadFile());
            this.ListTasks.Add(new ProcessFile());
            this.ListTasks.Add(new ResumeFile());
        }

        private void Execute()
        {

            //IList<ITask> pList
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
