﻿using System;

namespace Jitex.PE.Signature
{
    [Flags]
    public enum CorElementType : byte
    {
        ELEMENT_TYPE_END = 0,
        ELEMENT_TYPE_VOID = 1,
        ELEMENT_TYPE_BOOLEAN = 2,
        ELEMENT_TYPE_CHAR = 3,
        ELEMENT_TYPE_I1 = 4,
        ELEMENT_TYPE_U1 = 5,
        ELEMENT_TYPE_I2 = 6,
        ELEMENT_TYPE_U2 = 7,
        ELEMENT_TYPE_I4 = 8,
        ELEMENT_TYPE_U4 = 9,
        ELEMENT_TYPE_I8 = 10, // 0x0A
        ELEMENT_TYPE_U8 = 11, // 0x0B
        ELEMENT_TYPE_R4 = 12, // 0x0C
        ELEMENT_TYPE_R8 = 13, // 0x0D
        ELEMENT_TYPE_STRING = 14, // 0x0E
        ELEMENT_TYPE_PTR = 15, // 0x0F
        ELEMENT_TYPE_BYREF = 16, // 0x10
        ELEMENT_TYPE_VALUETYPE = 17, // 0x11
        ELEMENT_TYPE_CLASS = 18, // 0x12
        ELEMENT_TYPE_VAR = 19, // 0x13
        ELEMENT_TYPE_ARRAY = 20, // 0x14
        ELEMENT_TYPE_GENERICINST = 21, // 0x15
        ELEMENT_TYPE_TYPEDBYREF = 22, // 0x16
        ELEMENT_TYPE_I = 24, // 0x18
        ELEMENT_TYPE_U = 25, // 0x19
        ELEMENT_TYPE_FNPTR = 27, // 0x1B
        ELEMENT_TYPE_OBJECT = 28, // 0x1C
        ELEMENT_TYPE_SZARRAY = 29, // 0x1D
        ELEMENT_TYPE_MVAR = 30, // 0x1E
        ELEMENT_TYPE_CMOD_REQD = 31, // 0x1F
        ELEMENT_TYPE_CMOD_OPT = 32, // 0x20
        ELEMENT_TYPE_INTERNAL = 33, // 0x21
        ELEMENT_TYPE_MAX = 34, // 0x22
        ELEMENT_TYPE_MODIFIER = 64, // 0x40
        ELEMENT_TYPE_SENTINEL = 65, // 0x41
        ELEMENT_TYPE_PINNED = 69, // 0x45
    }
}