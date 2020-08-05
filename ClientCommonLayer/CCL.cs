using System;
using System.Reflection;
using System.Resources;

namespace ClientCommonLayer
{
    public class CCL
    {
        public const int MAX_LENGTH = 2147483647;

        public static MessageBox.MessageBox pMB = new MessageBox.MessageBox();

        public string GetResourceString(string strString)
        {
            ResourceManager rmResourceManager = new ResourceManager("ClientCommonLayer.ClientMessages", Assembly.GetExecutingAssembly(), null);
            return (rmResourceManager.GetString(strString));
        }
    }
}
