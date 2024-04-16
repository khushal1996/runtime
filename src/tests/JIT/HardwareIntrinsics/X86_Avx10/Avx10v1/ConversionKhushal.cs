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
        public static   Vector128<ulong> getAbs(Vector128<long> vall)
        {
            return Avx10v1.Abs(vall);
        }

        [Fact]
        public static unsafe void ConversionKhushal ()
        {
            Vector128<long> val = Vector128.Create<long>(-5);
            Vector128<ulong> absVal = getAbs(val);
        }
    }
}
