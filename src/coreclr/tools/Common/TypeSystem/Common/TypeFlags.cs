// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Internal.TypeSystem
{
    [Flags]
    public enum TypeFlags
    {
        CategoryMask    = 0x3F,

        // Primitive
        Unknown         = 0x00,
        Void            = 0x01,
        Boolean         = 0x02,
        Char            = 0x03,
        SByte           = 0x04,
        Byte            = 0x05,
        Int16           = 0x06,
        UInt16          = 0x07,
        Int32           = 0x08,
        UInt32          = 0x09,
        Int64           = 0x0A,
        UInt64          = 0x0B,
        IntPtr          = 0x0C,
        UIntPtr         = 0x0D,
        Half            = 0x0E,
        Single          = 0x0F,
        Double          = 0x10,

        ValueType       = 0x11,
        Enum            = 0x12, // Parent is enum
        Nullable        = 0x13, // Nullable instantiation
        // Unused         0x14

        Class           = 0x15,
        Interface       = 0x16,
        // Unused         0x17

        Array           = 0x18,
        SzArray         = 0x19,
        ByRef           = 0x1A,
        Pointer         = 0x1B,
        FunctionPointer = 0x1C,

        GenericParameter        = 0x1D,
        SignatureTypeVariable   = 0x1E,
        SignatureMethodVariable = 0x1F,

        HasGenericVariance         = 0x100,
        HasGenericVarianceComputed = 0x200,

        HasStaticConstructor         = 0x400,
        HasStaticConstructorComputed = 0x800,

        HasFinalizerComputed = 0x1000,
        HasFinalizer         = 0x2000,

        IsByRefLike            = 0x04000,
        IsInlineArray          = 0x08000,
        IsIntrinsic            = 0x10000,
        AttributeCacheComputed = 0x20000,

        IsIDynamicInterfaceCastable         = 0x40000,
        IsIDynamicInterfaceCastableComputed = 0x80000,
    }
}
