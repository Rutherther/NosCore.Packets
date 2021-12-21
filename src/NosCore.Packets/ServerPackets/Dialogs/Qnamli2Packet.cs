// 
// Qnamli2Packet.cs
// 
// Copyright (c) Christofel authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Dialogs;

[PacketHeader("qnamli2", Scope.InGame)]
public class Qnamli2Packet : PacketBase
{
    [PacketIndex(1)]
    public string? Command { get; set; }

    [PacketIndex(2)]
    public Game18NConstString Type { get; set; }

    [PacketIndex(3)]
    public int ParametersCount { get; set; }

    [PacketListIndex(4, ListSeparator = " ")]
    public IEnumerable<string>? Parameters { get; set; }
}