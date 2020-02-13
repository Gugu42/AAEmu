using System;

namespace AAEmu.LoginServer.Network.Message
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LoginMessageHandlerAttribute : Attribute
    {
        public LoginMessageOpcode Opcode { get; }

        public LoginMessageHandlerAttribute(LoginMessageOpcode opcode)
        {
            Opcode = opcode;
        }
    }
}
