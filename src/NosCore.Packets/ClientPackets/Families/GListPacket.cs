﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("glist")]
    public class GListPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(1)]
        public byte Type { get; set; }
    }
}