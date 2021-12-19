//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum SuPacketHitMode : short
    {
        SuccessAttack = 0,
        Miss = 1,
        CriticalAttack = 3,
        LongRangeMiss = 4,
        SuccessfulBuff = 5, // probably successful buff
        Unknown = -2,
    }
}