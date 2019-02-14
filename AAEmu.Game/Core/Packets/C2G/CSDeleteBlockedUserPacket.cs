using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSDeleteBlockedUserPacket : GamePacket
    {
        public CSDeleteBlockedUserPacket() : base(0x108, 1) // TODO 1.0 opcode: 0x105
        {
        }

        public override void Read(PacketStream stream)
        {
            var name = stream.ReadString();

            _log.Warn("CSDeleteBlockedUserPacket, {0}", name);
        }
    }
}
