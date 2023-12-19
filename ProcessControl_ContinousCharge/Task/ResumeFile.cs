using BusinessProcessControl;

namespace ProcessControl_ContinousCharge
{
    
    public class ResumeFile : Task, ITask
    {
        #region Properties

        public override string Name
        {
            get { return "ResumeFile"; }
        }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public override void Execute()
        {
            base.Execute();
            
            //AddCode
        }

        #endregion
    }

}