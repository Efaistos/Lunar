﻿using System.Runtime.InteropServices;

namespace Lunar.Native.Structures
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    internal readonly struct ProcessBasicInformation64
    {
        [FieldOffset(0x08)]
        internal readonly long PebBaseAddress;
    }
}