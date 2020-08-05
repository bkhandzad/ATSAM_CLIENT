using System;

using Atsam;

namespace ClientCommonLayer
{
    public class User : AUser
    {
        public User(string strUserID, string strPassword)
        {
            _IP = GetLocalIP();
            if ((strUserID == _UserID) && (strPassword == _Password))
            {
                isUserChanged = false;
                ecErrorCode = ErrorCode.ecNone;
            }
            else if (IsPasswordChanged == false)
            {
                ecErrorCode = ServerSupplier.BFL.CreateUser(strUserID, strPassword, ref intUserCode, ref strUserName, ref intWorkGroupCode, ref strWorkGroup, ref intWorkStationCode, ref strWorkStation, ref isUserChanged, ref utUserType, _IP);
                if (ecErrorCode == ErrorCode.ecNone)
                {
                    _UserID = strUserID;
                    _Password = strPassword;
                }
            }
        }


        public override string GetLocalIP()
        {
            string _IP = null;

            // Resolves a host name or IP address to an IPHostEntry instance.
            // IPHostEntry - Provides a container class for Internet host address information.
            System.Net.IPHostEntry _IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            // IPAddress class contains the address of a computer on an IP network.
            foreach (System.Net.IPAddress _IPAddress in _IPHostEntry.AddressList)
            {
                // InterNetwork indicates that an IP version 4 address is expected
                // when a Socket connects to an endpoint
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    _IP = _IPAddress.ToString();
                }
            }
            return _IP;
        }
    }
}
