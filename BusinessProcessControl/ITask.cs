using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessProcessControl
{

    public interface ITask
    {
        string Name { get; }

        void Execute();
    }

}
