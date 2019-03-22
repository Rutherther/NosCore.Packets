﻿namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader(";")]
    public class GroupTalkPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}