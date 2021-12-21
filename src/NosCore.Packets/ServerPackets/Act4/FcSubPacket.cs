// 
// FcSubPacket.cs
// 
// Copyright (c) Christofel authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Act4;

public class FcSubPacket : PacketBase
{
    [PacketIndex(0)]
    public short Percentage { get; set; }
    
    [PacketIndex(1)]
    public Act4Mode Mode { get; set; }
    
    [PacketIndex(2)]
    public long CurrentTime { get; set; }
    
    [PacketIndex(3)]
    public long TotalTime { get; set; }
    
    [PacketIndex(4)]
    public bool IsMorcos { get; set; }
    
    [PacketIndex(5)]
    public bool IsHatus { get; set; }
    
    [PacketIndex(6)]
    public bool IsCalvina { get; set; }
    
    [PacketIndex(7)]
    public bool IsBerios { get; set; }
}