﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    interface IRecovery
    {
        int Recovery { get; set; }
        void TakeRecovery();
    }
}
