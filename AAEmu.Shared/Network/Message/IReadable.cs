namespace AAEmu.Shared.Network.Message
{
    public interface IReadable
    {
        void Read(PacketStream stream);
    }
}
