﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CpfCommonTools.Tests
{
    public static class CpfInputs
    {
        public static List<string> CpfsInvalidos = new List<string>
        {
            "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
        };
    }
}
