﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using System.Collections.Generic;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("bpp", Scope.InGame)]
    public class BppPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte BearingCount { get; set; }

        [PacketIndex(1)]
        public int Points { get; set; }

        [PacketIndex(2)]
        public bool IsPremium { get; set; }

        [PacketIndex(3)]
        public List<BppSubTypePacket>? ItemList { get; set; }
    }
}
