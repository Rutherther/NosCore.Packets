﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Mates
{
    [PacketHeader("ib", Scope.InGame)]
    public class IbPacket : PacketBase
    {
        [PacketIndex(0)]
        public short FirstArgument { get; set; }

        [PacketIndex(1)]
        public byte SecondArgument { get; set; }
    }
}