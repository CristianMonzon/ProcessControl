using System;

namespace BusinessProcessControl
{

    public class ProcessFile :Task, ITask
    {
        #region Properties

        public override string Name
        {
            get { return "ProcessFile"; }
        }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public override void Execute()
        {
            base.Execute();

            //Add code here
        }

        #endregion
    }
}