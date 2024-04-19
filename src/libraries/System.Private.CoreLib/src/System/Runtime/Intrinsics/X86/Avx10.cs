// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>This class provides access to X86 AVX512BW hardware instructions via intrinsics</summary>
    [Intrinsic]
    [CLSCompliant(false)]
    public abstract class Avx10v1 : Avx2
    {
        internal Avx10v1() { }

        public static new bool IsSupported { get => IsSupported; }

        public static Vector128<ulong> Abs(Vector128<long> value) => Abs(value);

        [Intrinsic]
        public abstract class V256 : Avx2
        {
            internal V256() { }

            public static new bool IsSupported { get => IsSupported; }

            public static Vector256<ulong> Abs(Vector256<long> value) => Abs(value);
        }

        [Intrinsic]
        public abstract class V512 : Avx512BW
        {
            internal V512() { }

            public static new bool IsSupported { get => IsSupported; }
        }
    }
}
