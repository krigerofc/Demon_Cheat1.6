using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon_app
{
    public static class Offset
    {
    public static readonly int m_dwFovScale1 = 0xEC9E20; // hw.dll
    public static readonly int m_dwFovScale2 = 0xEC9E34; // hw.dll
    public static readonly int m_dwViewMatrix = 0x12EB10; // client.dll
    public static readonly int m_dwOnGround = 0x122E2D4; // hw.dll
    public static readonly int m_dwForceJump = 0x131434; // client.dll
    public static readonly int m_dwForceAttack = 0x131370; // client.dll
    public static readonly int m_dwGetTeam = 0x100DF4; // client.dll
    public static readonly int m_dwPunchAngles = 0x122E324; // hw.dll
    public static readonly int m_dwWeaponId = 0x108DD90; // hw.dll
    public static readonly int m_dwEntityOrigin = 0x12047A0; // hw.dll
    public static readonly int m_dwLocalOrigin = 0x13E7F0; // client.dll
    public static readonly int m_dwViewAngles = 0x108AEC4; // hw.dll

    }
}