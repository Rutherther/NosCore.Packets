﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Infrastructure
{
    [PacketHeader("DAC", Scope.OnCharacterScreen)]
    public class DacPacket : PacketBase
    {
        [PacketIndex(0)]
        [Required]
        public string AccountName { get; set; } = null!;

        [PacketIndex(1)]
        [Range(0, 3)]
        public byte Slot { get; set; }

    }
}
