using BusinessProcessControl;
using System;

namespace FabricatorProcessControl
{
    public class Fabricator
    {

        public Fabricator()
        {

        }

        public IBusinessTask CreateBusinessTask() {

            IBusinessTask BussinessTask = new BusinessTask();
            return BussinessTask;
                        
        }

    }

}
