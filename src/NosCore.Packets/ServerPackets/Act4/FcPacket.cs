// 
// FcPacket.cs
// 
// Copyright (c) Christofel authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Act4;

[PacketHeader("fc", Scope.InGame)]
public class FcPacket : PacketBase
{
    [PacketIndex(0)]
    public FactionType Faction { get; set; }
        
    [PacketIndex(1)]
    public long MinutesUntilReset { get; set; }
        
    [PacketIndex(2, Length = 8)]
    public FcSubPacket? AngelState { get; set; }
        
    [PacketIndex(3, Length = 8)]
    public FcSubPacket? DemonState { get; set; }
}