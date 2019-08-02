using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLibrary_0802
{
    [DefaultValue(PowerOff)]
    enum MachineState
    {
        PowerOff = 1,
        Running = 2,
        Sleeping = 3
    }

}
