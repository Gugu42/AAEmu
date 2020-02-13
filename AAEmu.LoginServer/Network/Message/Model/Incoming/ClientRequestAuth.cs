using System;
using AAEmu.Shared.Network;
using AAEmu.Shared.Network.Message;

namespace AAEmu.LoginServer.Network.Message.Model.Incoming
{
    [LoginMessage(LoginMessageOpcode.ClientRequestAuth)]
    public class ClientRequestAuth : IReadable
    {
        public uint From { get; private set; }
        public uint To { get; private set; }
        public bool Dev { get; private set; }
        public byte[] Mac { get; private set; }
        public string Ticket { get; private set; }
        public string Signature { get; private set; }
        public bool IsLast { get; private set; }
        
        public void Read(PacketStream stream)
        {
            From = stream.ReadUInt32();
            To = stream.ReadUInt32();
            Dev = stream.ReadBoolean();
            Mac = stream.ReadBytes();
            Ticket = stream.ReadString();
            Signature = stream.ReadString();
            IsLast = stream.ReadBoolean();
        }
    }
}
