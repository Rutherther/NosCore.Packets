﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("taw", Scope.InGame)]
    public class TawPacket : PacketBase
    {
        [PacketIndex(0)]
        [Required]
        public string Username { get; set; } = null!;
    }
}
