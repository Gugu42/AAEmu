using System;

namespace AAEmu.LoginServer.Network.Message
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LoginMessageAttribute : Attribute
    {
        public LoginMessageOpcode Opcode { get; }
        
        public LoginMessageAttribute(LoginMessageOpcode opcode)
        {
            Opcode = opcode;
        }
    }
}
