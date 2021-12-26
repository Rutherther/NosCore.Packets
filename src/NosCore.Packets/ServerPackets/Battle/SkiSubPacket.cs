// 
// SkiSubPacket.cs
// 
// Copyright (c) Christofel authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Battle;

public class SkiSubPacket : PacketBase
{
    [PacketIndex(0)]
    public long SkillVNum { get; set; }
    
    [PacketIndex(1)]
    public int Level { get; set; }
}