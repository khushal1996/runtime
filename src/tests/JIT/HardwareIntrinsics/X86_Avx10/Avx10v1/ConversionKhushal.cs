// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;
using Xunit;

namespace IntelHardwareIntrinsicTest._Avx10v1
{
    public partial class Program
    {
        const float EPS = Single.Epsilon * 5;

        [MethodImplAttribute(MethodImplOptions.NoInlining)]
        public static Vector128<ulong> getAbs128(Vector128<long> val)
        {
            return Avx10v1.Abs(val);
        }

        [MethodImplAttribute(MethodImplOptions.NoInlining)]
        public static Vector256<ulong> getAbs256(Vector256<long> val)
        {
            return Avx10v1_V256.Abs(val);
        }

        [Fact]
        public static unsafe void ConversionKhushal ()
        {
            if (Avx10v1.IsSupported)
            {
                Console.WriteLine("Avx10v1 supported");
                Vector128<long> val = Vector128.Create<long>(-5);
                Vector128<ulong> absVal = getAbs128(val);
            }

            if (Avx10v1_V256.IsSupported)
            {
                Console.WriteLine("Avx10v1_V256 supported");
                Vector256<long> val = Vector256.Create<long>(-5);
                Vector256<ulong> absVal = getAbs256(val);
            }
        }
    }
}
