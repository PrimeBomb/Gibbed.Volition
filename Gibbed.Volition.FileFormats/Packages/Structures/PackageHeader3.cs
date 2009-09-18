﻿using System;
using System.Runtime.InteropServices;
using Gibbed.Helpers;

namespace Gibbed.Volition.FileFormats.Packages.Structures
{
    [StructLayout(LayoutKind.Sequential, Size = 384, CharSet = CharSet.Ansi, Pack = 1)]
    internal struct PackageHeader3
    {
        public uint Magic;                  // 000
        public uint Version;                // 004
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x41)]
        public string String1;              // 008
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x100)]
        public string String2;              // 049
        public byte Pad1;
        public byte Pad2;
        public byte Pad3;
        public PackageFlags Flags;          // 14C
        public UInt32 Unknown150;           // 150
        public int IndexCount;              // 154
        public int PackageSize;             // 158
        public int IndexSize;               // 15C
        public int NamesSize;               // 160
        public int UncompressedDataSize;    // 164
        public int CompressedDataSize;      // 168
        public int IndexPointer;            // 16C
        public int NamesPointer;            // 170
        public int DataPointer;             // 174
        public int Unknown178;              // 178
        public int Unknown17C;              // 17C

        public PackageHeader3 Swap()
        {
            PackageHeader3 swapped = new PackageHeader3();
            swapped.Magic = this.Magic.Swap();
            swapped.Version = this.Version.Swap();
            swapped.Flags = (PackageFlags)(((uint)(this.Flags)).Swap());
            swapped.IndexCount = this.IndexCount.Swap();
            swapped.PackageSize = this.PackageSize.Swap();
            swapped.IndexSize = this.IndexSize.Swap();
            swapped.NamesSize = this.NamesSize.Swap();
            swapped.UncompressedDataSize = this.UncompressedDataSize.Swap();
            swapped.CompressedDataSize = this.CompressedDataSize.Swap();
            swapped.IndexPointer = this.IndexPointer.Swap();
            swapped.NamesPointer = this.NamesPointer.Swap();
            swapped.DataPointer = this.DataPointer.Swap();
            return swapped;
        }
    }
}
