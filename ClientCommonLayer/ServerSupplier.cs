using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atsam;
using Atsam.Server;

namespace ClientCommonLayer
{
    public class ServerSupplier
    {
        private static ABFL pBFL;

        public ServerSupplier(ABFL BFL)
        {
            pBFL = BFL;
        }

        public static ABFL BFL
        {
            get
            {
                return pBFL;
            }
        }

    }
}
