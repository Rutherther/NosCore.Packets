// 
// SrPacket.cs
// 
// Copyright (c) Christofel authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle;

[PacketHeader("sr", Scope.InGame)]
public class SrPacket : PacketBase
{
    [PacketIndex(0)]
    public long SkillVnum { get; set; }
}