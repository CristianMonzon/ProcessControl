using System;

namespace BusinessProcessControl
{
    public abstract class Task //: ITask
    {
        public virtual string Name
        {
            get
            {
                return "Not defined";
            }
        }

        #region Constructor

        public virtual void Execute()
        {
            System.Threading.Thread.Sleep(2000);
        }

        #endregion
    }

}