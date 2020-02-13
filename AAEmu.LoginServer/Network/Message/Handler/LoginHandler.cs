using System;
using System.Xml.Linq;
using AAEmu.LoginServer.Network.Message.Model.Incoming;
using AAEmu.Shared.Utils;
using NLog;

namespace AAEmu.LoginServer.Network.Message.Handler
{
    public static class LoginHandler
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();

        [LoginMessageHandler(LoginMessageOpcode.ClientRequestAuth)]
        public static void HandleRequestAuth(LoginSession session, ClientRequestAuth requestAuth)
        {
            // TODO : Code this out.

            void SendServerLoginDenied(int error)
            {
                // TODO : Send packet with error
                // Error -> Enum
            }
            
            var xmlDoc = XDocument.Parse(requestAuth.Ticket);

            if (xmlDoc.Root == null)
            {
                _log.Error("RequestAuthTrion: Catch parse ticket");
                SendServerLoginDenied(2);
                return;
            }

            var username = xmlDoc.Root.Element("username")?.Value;
            var password = xmlDoc.Root.Element("password")?.Value;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _log.Error("RequestAuthTrion: username or password is empty or white space");
                SendServerLoginDenied(2);
                return;
            }

            var token = Helpers.StringToByteArray(password);
            
            // TODO : Get account from DB
            /** Note: Database usage will be in other classes. This will just call something like AccountDatabase.Get(username, password) **/
            Object account = null; // TODO : Null -> Database call

            if (account == null)
            {
                SendServerLoginDenied(2);
            }

            // send ServerJoinResponse
            // send ServerAuthResponse
        }
    }
}
