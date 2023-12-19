using BusinessProcessControl;


namespace ProcessControl_ContinousCharge
{
    
    public class ReadFile : Task, ITask
    {
        #region Properties

        public override string Name
        {
            get { return "ReadFile"; }
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