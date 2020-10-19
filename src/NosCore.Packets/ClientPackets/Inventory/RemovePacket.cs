﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("remove", BlockedByTrading = true)]
    public class RemovePacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public EquipmentType InventorySlot { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }
    }
}