﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("say_p")]
    public class SayPetPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public long PetId { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}