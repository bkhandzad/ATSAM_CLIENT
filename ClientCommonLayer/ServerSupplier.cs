﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atsam;

namespace ClientCommonLayer
{
    public class ServerSupplier
    {
        private static IBFL pBFL;

        public ServerSupplier(IBFL BFL)
        {
            pBFL = BFL;
        }

        public static IBFL BFL
        {
            get
            {
                return pBFL;
            }
        }

    }
}
