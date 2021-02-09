﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Action.Core.Utils
{
    public enum ValidationTypes
    {
        None = 0,
        Email = 1,
        Number = 2,
        Decimal_Number = 3,
        String = 4,
        JObject = 5,
        JArray = 6, 
        Boolean = 7
    }
}
