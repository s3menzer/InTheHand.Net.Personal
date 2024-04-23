// 32feet.NET - Personal Area Networking for .NET
//
// InTheHand.Net.Bluetooth.BLUETOOTH_RADIO_INFO
//
// Copyright (c) 2003-2010 In The Hand Ltd, All rights reserved.
// This source code is licensed under the In The Hand Community License - see License.txt

using System;
using System.Runtime.InteropServices;

namespace InTheHand.Net.Bluetooth.Msft
{
#if (WinXP || WIN7)
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
#endif
    internal struct BLUETOOTH_RADIO_INFO
    {
        private const int BLUETOOTH_MAX_NAME_SIZE = 248;

        internal int dwSize;
        internal long address;
#if (WinXP || WIN7)
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = BLUETOOTH_MAX_NAME_SIZE)]
#endif
        internal string szName;
        internal uint ulClassofDevice;
        internal ushort lmpSubversion;
#if (WinXP || WIN7)
        [MarshalAs(UnmanagedType.U2)]
#endif
        internal Manufacturer manufacturer;
    }
}
