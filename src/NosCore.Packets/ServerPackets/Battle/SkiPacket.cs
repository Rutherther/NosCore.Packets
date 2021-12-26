// 
// SkiPacket.cs
// 
// Copyright (c) Christofel authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Battle;

[PacketHeader("ski", Scope.InGame)]
public class SkiPacket : PacketBase
{
    [PacketIndex(0)]
    public long PrimarySkill { get; set; }
    
    [PacketIndex(1)]
    public long SecondarySkill { get; set; }
    
    [PacketListIndex(2, ListSeparator = " ", SpecialSeparator = "|")]
    public List<SkiSubPacket>? SkiSubPackets { get; set; } 
}