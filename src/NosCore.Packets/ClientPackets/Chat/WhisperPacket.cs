﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Chat
{
    [PacketHeader("/")]
    public class WhisperPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}