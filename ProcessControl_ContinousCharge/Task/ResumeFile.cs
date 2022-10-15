using BusinessProcessControl;
using System.Threading.Tasks;

namespace ProcessControl_ContinousCharge
{
    
    public class ResumeFile : BusinessProcessControl.Task, ITask
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