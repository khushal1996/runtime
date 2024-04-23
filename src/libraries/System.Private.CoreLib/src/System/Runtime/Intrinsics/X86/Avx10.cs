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

        /// From AVX512F VL
        /// <summary>
        /// __m128i _mm_abs_epi64 (__m128i a)
        ///   VPABSQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<ulong> Abs(Vector128<long> value) => Abs(value);

        /// <summary>
        /// __m128i _mm_alignr_epi32 (__m128i a, __m128i b, const int count)
        ///   VALIGND xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<int> AlignRight32(Vector128<int> left, Vector128<int> right, [ConstantExpected] byte mask) => AlignRight32(left, right, mask);

        /// <summary>
        /// __m128i _mm_alignr_epi32 (__m128i a, __m128i b, const int count)
        ///   VALIGND xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<uint> AlignRight32(Vector128<uint> left, Vector128<uint> right, [ConstantExpected] byte mask) => AlignRight32(left, right, mask);

        /// <summary>
        /// __m128i _mm_alignr_epi64 (__m128i a, __m128i b, const int count)
        ///   VALIGNQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<long> AlignRight64(Vector128<long> left, Vector128<long> right, [ConstantExpected] byte mask) => AlignRight64(left, right, mask);

        /// <summary>
        /// __m128i _mm_alignr_epi64 (__m128i a, __m128i b, const int count)
        ///   VALIGNQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<ulong> AlignRight64(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected] byte mask) => AlignRight64(left, right, mask);

        /// <summary>
        /// __m128i _mm_cmpge_epi32 (__m128i a, __m128i b)
        ///   VPCMPD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(5)
        /// </summary>
        public static Vector128<int> CompareGreaterThanOrEqual(Vector128<int> left, Vector128<int> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epi32 (__m128i a, __m128i b)
        ///   VPCMPD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(1)
        /// </summary>
        public static new Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epi32 (__m128i a, __m128i b)
        ///   VPCMPD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(2)
        /// </summary>
        public static Vector128<int> CompareLessThanOrEqual(Vector128<int> left, Vector128<int> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epi32 (__m128i a, __m128i b)
        ///   VPCMPD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(4)
        /// </summary>
        public static Vector128<int> CompareNotEqual(Vector128<int> left, Vector128<int> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epi64 (__m128i a, __m128i b)
        ///   VPCMPQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(5)
        /// </summary>
        public static Vector128<long> CompareGreaterThanOrEqual(Vector128<long> left, Vector128<long> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epi64 (__m128i a, __m128i b)
        ///   VPCMPQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(1)
        /// </summary>
        public static Vector128<long> CompareLessThan(Vector128<long> left, Vector128<long> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epi64 (__m128i a, __m128i b)
        ///   VPCMPQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(2)
        /// </summary>
        public static Vector128<long> CompareLessThanOrEqual(Vector128<long> left, Vector128<long> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epi64 (__m128i a, __m128i b)
        ///   VPCMPQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(4)
        /// </summary>
        public static Vector128<long> CompareNotEqual(Vector128<long> left, Vector128<long> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpgt_epu32 (__m128i a, __m128i b)
        ///   VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(6)
        /// </summary>
        public static Vector128<uint> CompareGreaterThan(Vector128<uint> left, Vector128<uint> right) => CompareGreaterThan(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epu32 (__m128i a, __m128i b)
        ///   VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(5)
        /// </summary>
        public static Vector128<uint> CompareGreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epu32 (__m128i a, __m128i b)
        ///   VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(1)
        /// </summary>
        public static Vector128<uint> CompareLessThan(Vector128<uint> left, Vector128<uint> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epu32 (__m128i a, __m128i b)
        ///   VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(2)
        /// </summary>
        public static Vector128<uint> CompareLessThanOrEqual(Vector128<uint> left, Vector128<uint> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epu32 (__m128i a, __m128i b)
        ///   VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8(4)
        /// </summary>
        public static Vector128<uint> CompareNotEqual(Vector128<uint> left, Vector128<uint> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpgt_epu64 (__m128i a, __m128i b)
        ///   VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(6)
        /// </summary>
        public static Vector128<ulong> CompareGreaterThan(Vector128<ulong> left, Vector128<ulong> right) => CompareGreaterThan(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epu64 (__m128i a, __m128i b)
        ///   VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(5)
        /// </summary>
        public static Vector128<ulong> CompareGreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epu64 (__m128i a, __m128i b)
        ///   VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(1)
        /// </summary>
        public static Vector128<ulong> CompareLessThan(Vector128<ulong> left, Vector128<ulong> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epu64 (__m128i a, __m128i b)
        ///   VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(2)
        /// </summary>
        public static Vector128<ulong> CompareLessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epu64 (__m128i a, __m128i b)
        ///   VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8(4)
        /// </summary>
        public static Vector128<ulong> CompareNotEqual(Vector128<ulong> left, Vector128<ulong> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi8 (__m128i a)
        ///   VPMOVDB xmm1/m32 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128Byte(Vector128<int> value) => ConvertToVector128Byte(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi8 (__m128i a)
        ///   VPMOVQB xmm1/m16 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128Byte(Vector128<long> value) => ConvertToVector128Byte(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi8 (__m128i a)
        ///   VPMOVDB xmm1/m32 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128Byte(Vector128<uint> value) => ConvertToVector128Byte(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi8 (__m128i a)
        ///   VPMOVQB xmm1/m16 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128Byte(Vector128<ulong> value) => ConvertToVector128Byte(value);

        /// <summary>
        /// __m128i _mm_cvtusepi32_epi8 (__m128i a)
        ///   VPMOVUSDB xmm1/m32 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<uint> value) => ConvertToVector128ByteWithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtusepi64_epi8 (__m128i a)
        ///   VPMOVUSQB xmm1/m16 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ulong> value) => ConvertToVector128ByteWithSaturation(value);

        /// <summary>
        /// __m128d _mm_cvtepu32_pd (__m128i a)
        ///   VCVTUDQ2PD xmm1 {k1}{z}, xmm2/m64/m32bcst
        /// </summary>
        public static Vector128<double> ConvertToVector128Double(Vector128<uint> value) => ConvertToVector128Double(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi16 (__m128i a)
        ///   VPMOVDW xmm1/m64 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<short> ConvertToVector128Int16(Vector128<int> value) => ConvertToVector128Int16(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi16 (__m128i a)
        ///   VPMOVQW xmm1/m32 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<short> ConvertToVector128Int16(Vector128<long> value) => ConvertToVector128Int16(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi16 (__m128i a)
        ///   VPMOVDW xmm1/m64 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<short> ConvertToVector128Int16(Vector128<uint> value) => ConvertToVector128Int16(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi16 (__m128i a)
        ///   VPMOVQW xmm1/m32 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<short> ConvertToVector128Int16(Vector128<ulong> value) => ConvertToVector128Int16(value);

        /// <summary>
        /// __m128i _mm_cvtsepi32_epi16 (__m128i a)
        ///   VPMOVSDW xmm1/m64 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector128<int> value) => ConvertToVector128Int16WithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtsepi64_epi16 (__m128i a)
        ///   VPMOVSQW xmm1/m32 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector128<long> value) => ConvertToVector128Int16WithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi32 (__m128i a)
        ///   VPMOVQD xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<int> ConvertToVector128Int32(Vector128<long> value) => ConvertToVector128Int32(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi32 (__m128i a)
        ///   VPMOVQD xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<int> ConvertToVector128Int32(Vector128<ulong> value) => ConvertToVector128Int32(value);

        /// <summary>
        /// __m128i _mm_cvtsepi64_epi32 (__m128i a)
        ///   VPMOVSQD xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<int> ConvertToVector128Int32WithSaturation(Vector128<long> value) => ConvertToVector128Int32WithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi8 (__m128i a)
        ///   VPMOVDB xmm1/m32 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByte(Vector128<int> value) => ConvertToVector128SByte(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi8 (__m128i a)
        ///   VPMOVQB xmm1/m16 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByte(Vector128<long> value) => ConvertToVector128SByte(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi8 (__m128i a)
        ///   VPMOVDB xmm1/m32 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByte(Vector128<uint> value) => ConvertToVector128SByte(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi8 (__m128i a)
        ///   VPMOVQB xmm1/m16 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ulong> value) => ConvertToVector128SByte(value);

        /// <summary>
        /// __m128i _mm_cvtsepi32_epi8 (__m128i a)
        ///   VPMOVSDB xmm1/m32 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<int> value) => ConvertToVector128SByteWithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtsepi64_epi8 (__m128i a)
        ///   VPMOVSQB xmm1/m16 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<long> value) => ConvertToVector128SByteWithSaturation(value);

        /// <summary>
        /// __m128 _mm_cvtepu32_ps (__m128i a)
        ///   VCVTUDQ2PS xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<float> ConvertToVector128Single(Vector128<uint> value) => ConvertToVector128Single(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi16 (__m128i a)
        ///   VPMOVDW xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<ushort> ConvertToVector128UInt16(Vector128<int> value) => ConvertToVector128UInt16(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi16 (__m128i a)
        ///   VPMOVQW xmm1/m32 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<ushort> ConvertToVector128UInt16(Vector128<long> value) => ConvertToVector128UInt16(value);

        /// <summary>
        /// __m128i _mm_cvtepi32_epi16 (__m128i a)
        ///   VPMOVDW xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<ushort> ConvertToVector128UInt16(Vector128<uint> value) => ConvertToVector128UInt16(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi16 (__m128i a)
        ///   VPMOVQW xmm1/m32 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<ushort> ConvertToVector128UInt16(Vector128<ulong> value) => ConvertToVector128UInt16(value);

        /// <summary>
        /// __m128i _mm_cvtusepi32_epi16 (__m128i a)
        ///   VPMOVUSDW xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector128<uint> value) => ConvertToVector128UInt16WithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtusepi64_epi16 (__m128i a)
        ///   VPMOVUSQW xmm1/m32 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector128<ulong> value) => ConvertToVector128UInt16WithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi32 (__m128i a)
        ///   VPMOVQD xmm1/m128 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32(Vector128<long> value) => ConvertToVector128UInt32(value);

        /// <summary>
        /// __m128i _mm_cvtepi64_epi32 (__m128i a)
        ///   VPMOVQD xmm1/m128 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32(Vector128<ulong> value) => ConvertToVector128UInt32(value);

        /// <summary>
        /// __m128i _mm_cvtps_epu32 (__m128 a)
        ///   VCVTPS2UDQ xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32(Vector128<float> value) => ConvertToVector128UInt32(value);

        /// <summary>
        /// __m128i _mm_cvtpd_epu32 (__m128d a)
        ///   VCVTPD2UDQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32(Vector128<double> value) => ConvertToVector128UInt32(value);

        /// <summary>
        /// __m128i _mm_cvtusepi64_epi32 (__m128i a)
        ///   VPMOVUSQD xmm1/m128 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32WithSaturation(Vector128<ulong> value) => ConvertToVector128UInt32WithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvttps_epu32 (__m128 a)
        ///   VCVTTPS2UDQ xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector128<float> value) => ConvertToVector128UInt32WithTruncation(value);

        /// <summary>
        /// __m128i _mm_cvttpd_epu32 (__m128d a)
        ///   VCVTTPD2UDQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector128<double> value) => ConvertToVector128UInt32WithTruncation(value);

        /// <summary>
        /// __m128 _mm_fixupimm_ps(__m128 a, __m128 b, __m128i tbl, int imm);
        ///   VFIXUPIMMPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<float> Fixup(Vector128<float> left, Vector128<float> right, Vector128<int> table, [ConstantExpected] byte control) => Fixup(left, right, table, control);

        /// <summary>
        /// __m128d _mm_fixupimm_pd(__m128d a, __m128d b, __m128i tbl, int imm);
        ///   VFIXUPIMMPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<double> Fixup(Vector128<double> left, Vector128<double> right, Vector128<long> table, [ConstantExpected] byte control) => Fixup(left, right, table, control);

        /// <summary>
        /// __m128 _mm_getexp_ps (__m128 a)
        ///   VGETEXPPS xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<float> GetExponent(Vector128<float> value) => GetExponent(value);

        /// <summary>
        /// __m128d _mm_getexp_pd (__m128d a)
        ///   VGETEXPPD xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<double> GetExponent(Vector128<double> value) => GetExponent(value);

        /// <summary>
        /// __m128 _mm_getmant_ps (__m128 a)
        ///   VGETMANTPS xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<float> GetMantissa(Vector128<float> value, [ConstantExpected(Max = (byte)(0x0F))] byte control) => GetMantissa(value, control);

        /// <summary>
        /// __m128d _mm_getmant_pd (__m128d a)
        ///   VGETMANTPD xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<double> GetMantissa(Vector128<double> value, [ConstantExpected(Max = (byte)(0x0F))] byte control) => GetMantissa(value, control);

        /// <summary>
        /// __m128i _mm_max_epi64 (__m128i a, __m128i b)
        ///   VPMAXSQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) => Max(left, right);

        /// <summary>
        /// __m128i _mm_max_epu64 (__m128i a, __m128i b)
        ///   VPMAXUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) => Max(left, right);

        /// <summary>
        /// __m128i _mm_min_epi64 (__m128i a, __m128i b)
        ///   VPMINSQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) => Min(left, right);

        /// <summary>
        /// __m128i _mm_min_epu64 (__m128i a, __m128i b)
        ///   VPMINUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) => Min(left, right);

        /// <summary>
        /// __m128i _mm_permutex2var_epi64 (__m128i a, __m128i idx, __m128i b)
        ///   VPERMI2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        ///   VPERMT2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<long> PermuteVar2x64x2(Vector128<long> lower, Vector128<long> indices, Vector128<long> upper) => PermuteVar2x64x2(lower, indices, upper);

        /// <summary>
        /// __m128i _mm_permutex2var_epi64 (__m128i a, __m128i idx, __m128i b)
        ///   VPERMI2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        ///   VPERMT2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<ulong> PermuteVar2x64x2(Vector128<ulong> lower, Vector128<ulong> indices, Vector128<ulong> upper) => PermuteVar2x64x2(lower, indices, upper);

        /// <summary>
        /// __m128d _mm_permutex2var_pd (__m128d a, __m128i idx, __m128i b)
        ///   VPERMI2PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        ///   VPERMT2PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<double> PermuteVar2x64x2(Vector128<double> lower, Vector128<long> indices, Vector128<double> upper) => PermuteVar2x64x2(lower, indices, upper);

        /// <summary>
        /// __m128i _mm_permutex2var_epi32 (__m128i a, __m128i idx, __m128i b)
        ///   VPERMI2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        ///   VPERMT2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<int> PermuteVar4x32x2(Vector128<int> lower, Vector128<int> indices, Vector128<int> upper) => PermuteVar4x32x2(lower, indices, upper);

        /// <summary>
        /// __m128i _mm_permutex2var_epi32 (__m128i a, __m128i idx, __m128i b)
        ///   VPERMI2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        ///   VPERMT2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<uint> PermuteVar4x32x2(Vector128<uint> lower, Vector128<uint> indices, Vector128<uint> upper) => PermuteVar4x32x2(lower, indices, upper);

        /// <summary>
        /// __m128 _mm_permutex2var_ps (__m128 a, __m128i idx, __m128i b)
        ///   VPERMI2PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        ///   VPERMT2PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<float> PermuteVar4x32x2(Vector128<float> lower, Vector128<int> indices, Vector128<float> upper) => PermuteVar4x32x2(lower, indices, upper);

        /// <summary>
        /// __m128 _mm_rcp14_ps (__m128 a, __m128 b)
        ///   VRCP14PS xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<float> Reciprocal14(Vector128<float> value) => Reciprocal14(value);

        /// <summary>
        /// __m128d _mm_rcp14_pd (__m128d a, __m128d b)
        ///   VRCP14PD xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<double> Reciprocal14(Vector128<double> value) => Reciprocal14(value);

        /// <summary>
        /// __m128 _mm_rsqrt14_ps (__m128 a, __m128 b)
        ///   VRSQRT14PS xmm1 {k1}{z}, xmm2/m128/m32bcst
        /// </summary>
        public static Vector128<float> ReciprocalSqrt14(Vector128<float> value) => ReciprocalSqrt14(value);

        /// <summary>
        /// __m128d _mm_rsqrt14_pd (__m128d a, __m128d b)
        ///   VRSQRT14PD xmm1 {k1}{z}, xmm2/m128/m64bcst
        /// </summary>
        public static Vector128<double> ReciprocalSqrt14(Vector128<double> value) => ReciprocalSqrt14(value);

        /// <summary>
        /// __m128i _mm_rol_epi32 (__m128i a, int imm8)
        ///   VPROLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<int> RotateLeft(Vector128<int> value, [ConstantExpected] byte count) => RotateLeft(value, count);

        /// <summary>
        /// __m128i _mm_rol_epi32 (__m128i a, int imm8)
        ///   VPROLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<uint> RotateLeft(Vector128<uint> value, [ConstantExpected] byte count) => RotateLeft(value, count);

        /// <summary>
        /// __m128i _mm_rol_epi64 (__m128i a, int imm8)
        ///   VPROLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<long> RotateLeft(Vector128<long> value, [ConstantExpected] byte count) => RotateLeft(value, count);

        /// <summary>
        /// __m128i _mm_rol_epi64 (__m128i a, int imm8)
        ///   VPROLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<ulong> RotateLeft(Vector128<ulong> value, [ConstantExpected] byte count) => RotateLeft(value, count);

        /// <summary>
        /// __m128i _mm_rolv_epi32 (__m128i a, __m128i b)
        ///   VPROLDV xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<int> RotateLeftVariable(Vector128<int> value, Vector128<uint> count) => RotateLeftVariable(value, count);

        /// <summary>
        /// __m128i _mm_rolv_epi32 (__m128i a, __m128i b)
        ///   VPROLDV xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<uint> RotateLeftVariable(Vector128<uint> value, Vector128<uint> count) => RotateLeftVariable(value, count);

        /// <summary>
        /// __m128i _mm_rolv_epi64 (__m128i a, __m128i b)
        ///   VPROLQV xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<long> RotateLeftVariable(Vector128<long> value, Vector128<ulong> count) => RotateLeftVariable(value, count);

        /// <summary>
        /// __m128i _mm_rolv_epi64 (__m128i a, __m128i b)
        ///   VPROLQV xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<ulong> RotateLeftVariable(Vector128<ulong> value, Vector128<ulong> count) => RotateLeftVariable(value, count);

        /// <summary>
        /// __m128i _mm_ror_epi32 (__m128i a, int imm8)
        ///   VPRORD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<int> RotateRight(Vector128<int> value, [ConstantExpected] byte count) => RotateRight(value, count);

        /// <summary>
        /// __m128i _mm_ror_epi32 (__m128i a, int imm8)
        ///   VPRORD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<uint> RotateRight(Vector128<uint> value, [ConstantExpected] byte count) => RotateRight(value, count);

        /// <summary>
        /// __m128i _mm_ror_epi64 (__m128i a, int imm8)
        ///   VPRORQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<long> RotateRight(Vector128<long> value, [ConstantExpected] byte count) => RotateRight(value, count);

        /// <summary>
        /// __m128i _mm_ror_epi64 (__m128i a, int imm8)
        ///   VPRORQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<ulong> RotateRight(Vector128<ulong> value, [ConstantExpected] byte count) => RotateRight(value, count);

        /// <summary>
        /// __m128i _mm_rorv_epi32 (__m128i a, __m128i b)
        ///   VPRORDV xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<int> RotateRightVariable(Vector128<int> value, Vector128<uint> count) => RotateRightVariable(value, count);

        /// <summary>
        /// __m128i _mm_rorv_epi32 (__m128i a, __m128i b)
        ///   VPRORDV xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<uint> RotateRightVariable(Vector128<uint> value, Vector128<uint> count) => RotateRightVariable(value, count);

        /// <summary>
        /// __m128i _mm_rorv_epi64 (__m128i a, __m128i b)
        ///   VPRORQV xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<long> RotateRightVariable(Vector128<long> value, Vector128<ulong> count) => RotateRightVariable(value, count);

        /// <summary>
        /// __m128i _mm_rorv_epi64 (__m128i a, __m128i b)
        ///   VPRORQV xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<ulong> RotateRightVariable(Vector128<ulong> value, Vector128<ulong> count) => RotateRightVariable(value, count);

        /// <summary>
        /// __m128 _mm_roundscale_ps (__m128 a, int imm)
        ///   VRNDSCALEPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<float> RoundScale(Vector128<float> value, [ConstantExpected] byte control) => RoundScale(value, control);

        /// <summary>
        /// __m128d _mm_roundscale_pd (__m128d a, int imm)
        ///   VRNDSCALEPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<double> RoundScale(Vector128<double> value, [ConstantExpected] byte control) => RoundScale(value, control);

        /// <summary>
        /// __m128 _mm_scalef_ps (__m128 a, int imm)
        ///   VSCALEFPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        /// </summary>
        public static Vector128<float> Scale(Vector128<float> left, Vector128<float> right) => Scale(left, right);

        /// <summary>
        /// __m128d _mm_scalef_pd (__m128d a, int imm)
        ///   VSCALEFPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<double> Scale(Vector128<double> left, Vector128<double> right) => Scale(left, right);

        /// <summary>
        /// __m128i _mm_sra_epi64 (__m128i a, __m128i count)
        ///   VPSRAQ xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, Vector128<long> count) => ShiftRightArithmetic(value, count);

        /// <summary>
        /// __128i _mm_srai_epi64 (__m128i a, int imm8)
        ///   VPSRAQ xmm1 {k1}{z}, xmm2, imm8
        /// </summary>
        public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, [ConstantExpected] byte count) => ShiftRightArithmetic(value, count);

        /// <summary>
        /// __m128i _mm_srav_epi64 (__m128i a, __m128i count)
        ///   VPSRAVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        /// </summary>
        public static Vector128<long> ShiftRightArithmeticVariable(Vector128<long> value, Vector128<ulong> count) => ShiftRightArithmeticVariable(value, count);

        /// <summary>
        /// __m128i _mm_ternarylogic_si128 (__m128i a, __m128i b, __m128i c, byte imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
        /// </summary>
        public static Vector128<sbyte> TernaryLogic(Vector128<sbyte> a, Vector128<sbyte> b, Vector128<sbyte> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_si128 (__m128i a, __m128i b, __m128i c, byte imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
        /// </summary>
        public static Vector128<byte> TernaryLogic(Vector128<byte> a, Vector128<byte> b, Vector128<byte> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_si128 (__m128i a, __m128i b, __m128i c, short imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
        /// </summary>
        public static Vector128<short> TernaryLogic(Vector128<short> a, Vector128<short> b, Vector128<short> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_si128 (__m128i a, __m128i b, __m128i c, short imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
        /// </summary>
        public static Vector128<ushort> TernaryLogic(Vector128<ushort> a, Vector128<ushort> b, Vector128<ushort> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_epi32 (__m128i a, __m128i b, __m128i c, int imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<int> TernaryLogic(Vector128<int> a, Vector128<int> b, Vector128<int> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_epi32 (__m128i a, __m128i b, __m128i c, int imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        /// </summary>
        public static Vector128<uint> TernaryLogic(Vector128<uint> a, Vector128<uint> b, Vector128<uint> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_epi64 (__m128i a, __m128i b, __m128i c, int imm)
        ///   VPTERNLOGQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<long> TernaryLogic(Vector128<long> a, Vector128<long> b, Vector128<long> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128i _mm_ternarylogic_epi64 (__m128i a, __m128i b, __m128i c, int imm)
        ///   VPTERNLOGQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        /// </summary>
        public static Vector128<ulong> TernaryLogic(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128 _mm_ternarylogic_ps (__m128 a, __m128 b, __m128 c, int imm)
        ///   VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
        /// </summary>
        public static Vector128<float> TernaryLogic(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// <summary>
        /// __m128d _mm_ternarylogic_pd (__m128d a, __m128d b, __m128d c, int imm)
        ///   VPTERNLOGQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
        /// </summary>
        public static Vector128<double> TernaryLogic(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

        /// From AVX512BW VL
        /// <summary>
        /// __m128i _mm_cmpgt_epu8 (__m128i a, __m128i b)
        ///   VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(6)
        /// </summary>
        public static Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right) => CompareGreaterThan(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epu8 (__m128i a, __m128i b)
        ///   VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(5)
        /// </summary>
        public static Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epu8 (__m128i a, __m128i b)
        ///   VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(1)
        /// </summary>
        public static Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epu8 (__m128i a, __m128i b)
        ///   VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(2)
        /// </summary>
        public static Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epu8 (__m128i a, __m128i b)
        ///   VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(4)
        /// </summary>
        public static Vector128<byte> CompareNotEqual(Vector128<byte> left, Vector128<byte> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epi16 (__m128i a, __m128i b)
        ///   VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(5)
        /// </summary>
        public static Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epi16 (__m128i a, __m128i b)
        ///   VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(1)
        /// </summary>
        public static new Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epi16 (__m128i a, __m128i b)
        ///   VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(2)
        /// </summary>
        public static Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epi16 (__m128i a, __m128i b)
        ///   VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(4)
        /// </summary>
        public static Vector128<short> CompareNotEqual(Vector128<short> left, Vector128<short> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epi8 (__m128i a, __m128i b)
        ///   VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(5)
        /// </summary>
        public static Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epi8 (__m128i a, __m128i b)
        ///   VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(1)
        /// </summary>
        public static new Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epi8 (__m128i a, __m128i b)
        ///   VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(2)
        /// </summary>
        public static Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epi8 (__m128i a, __m128i b)
        ///   VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(4)
        /// </summary>
        public static Vector128<sbyte> CompareNotEqual(Vector128<sbyte> left, Vector128<sbyte> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpgt_epu16 (__m128i a, __m128i b)
        ///   VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(6)
        /// </summary>
        public static Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right) => CompareGreaterThan(left, right);

        /// <summary>
        /// __m128i _mm_cmpge_epu16 (__m128i a, __m128i b)
        ///   VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(5)
        /// </summary>
        public static Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) => CompareGreaterThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmplt_epu16 (__m128i a, __m128i b)
        ///   VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(1)
        /// </summary>
        public static Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right) => CompareLessThan(left, right);

        /// <summary>
        /// __m128i _mm_cmple_epu16 (__m128i a, __m128i b)
        ///   VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(2)
        /// </summary>
        public static Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) => CompareLessThanOrEqual(left, right);

        /// <summary>
        /// __m128i _mm_cmpne_epu16 (__m128i a, __m128i b)
        ///   VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(4)
        /// </summary>
        public static Vector128<ushort> CompareNotEqual(Vector128<ushort> left, Vector128<ushort> right) => CompareNotEqual(left, right);

        /// <summary>
        /// __m128i _mm_cvtepi16_epi8 (__m128i a)
        ///   VPMOVWB xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128Byte(Vector128<short> value) => ConvertToVector128Byte(value);

        /// <summary>
        /// __m128i _mm_cvtepi16_epi8 (__m128i a)
        ///   VPMOVWB xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128Byte(Vector128<ushort> value) => ConvertToVector128Byte(value);

        /// <summary>
        /// __m128i _mm_cvtusepi16_epi8 (__m128i a)
        ///   VPMOVUWB xmm1/m64 {k1}{z}, xmm2
        /// </summary>
        public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ushort> value) => ConvertToVector128ByteWithSaturation(value);

        /// <summary>
        /// __m128i _mm_cvtepi16_epi8 (__m128i a)
        ///   VPMOVWB xmm1/m64 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByte(Vector128<short> value) => ConvertToVector128SByte(value);

        /// <summary>
        /// __m128i _mm_cvtepi16_epi8 (__m128i a)
        ///   VPMOVWB xmm1/m64 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ushort> value) => ConvertToVector128SByte(value);

        /// <summary>
        /// __m128i _mm_cvtsepi16_epi8 (__m128i a)
        ///   VPMOVSWB xmm1/m64 {k1}{z}, zmm2
        /// </summary>
        public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<short> value) => ConvertToVector128SByteWithSaturation(value);

        /// <summary>
        /// __m128i _mm_permutevar8x16_epi16 (__m128i a, __m128i b)
        ///   VPERMW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<short> PermuteVar8x16(Vector128<short> left, Vector128<short> control) => PermuteVar8x16(left, control);

        /// <summary>
        /// __m128i _mm_permutevar8x16_epi16 (__m128i a, __m128i b)
        ///   VPERMW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<ushort> PermuteVar8x16(Vector128<ushort> left, Vector128<ushort> control) => PermuteVar8x16(left, control);

        /// <summary>
        /// __m128i _mm_permutex2var_epi16 (__m128i a, __m128i idx, __m128i b)
        ///   VPERMI2W xmm1 {k1}{z}, xmm2, xmm3/m128
        ///   VPERMT2W xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<short> PermuteVar8x16x2(Vector128<short> lower, Vector128<short> indices, Vector128<short> upper) => PermuteVar8x16x2(lower, indices, upper);

        /// <summary>
        /// __m128i _mm_permutex2var_epi16 (__m128i a, __m128i idx, __m128i b)
        ///   VPERMI2W xmm1 {k1}{z}, xmm2, xmm3/m128
        ///   VPERMT2W xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<ushort> PermuteVar8x16x2(Vector128<ushort> lower, Vector128<ushort> indices, Vector128<ushort> upper) => PermuteVar8x16x2(lower, indices, upper);

        /// <summary>
        /// __m128i _mm_sllv_epi16 (__m128i a, __m128i count)
        ///   VPSLLVW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<short> ShiftLeftLogicalVariable(Vector128<short> value, Vector128<ushort> count) => ShiftLeftLogicalVariable(value, count);

        /// <summary>
        /// __m128i _mm_sllv_epi16 (__m128i a, __m128i count)
        ///   VPSLLVW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<ushort> ShiftLeftLogicalVariable(Vector128<ushort> value, Vector128<ushort> count) => ShiftLeftLogicalVariable(value, count);

        /// <summary>
        /// __m128i _mm_srav_epi16 (__m128i a, __m128i count)
        ///   VPSRAVW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<short> ShiftRightArithmeticVariable(Vector128<short> value, Vector128<ushort> count) => ShiftRightArithmeticVariable(value, count);

        /// <summary>
        /// __m128i _mm_srlv_epi16 (__m128i a, __m128i count)
        ///   VPSRLVW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<short> ShiftRightLogicalVariable(Vector128<short> value, Vector128<ushort> count) => ShiftRightLogicalVariable(value, count);

        /// <summary>
        /// __m128i _mm_srlv_epi16 (__m128i a, __m128i count)
        ///   VPSRLVW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<ushort> ShiftRightLogicalVariable(Vector128<ushort> value, Vector128<ushort> count) => ShiftRightLogicalVariable(value, count);

        /// <summary>
        /// __m128i _mm_dbsad_epu8 (__m128i a, __m128i b, int imm8)
        ///   VDBPSADBW xmm1 {k1}{z}, xmm2, xmm3/m128
        /// </summary>
        public static Vector128<ushort> SumAbsoluteDifferencesInBlock32(Vector128<byte> left, Vector128<byte> right, [ConstantExpected] byte control) => SumAbsoluteDifferencesInBlock32(left, right, control);

        [Intrinsic]
        public abstract class V256 : Avx2
        {
            internal V256() { }

            public static new bool IsSupported { get => IsSupported; }

            /// From AVX512F VL
            /// <summary>
            /// __m256i _mm256_abs_epi64 (__m128i a)
            ///   VPABSQ ymm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> Abs(Vector256<long> value) => Abs(value);

            /// <summary>
            /// __m256i _mm256_alignr_epi32 (__m256i a, __m256i b, const int count)
            ///   VALIGND ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<int> AlignRight32(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte mask) => AlignRight32(left, right, mask);

            /// <summary>
            /// __m256i _mm256_alignr_epi32 (__m256i a, __m256i b, const int count)
            ///   VALIGND ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<uint> AlignRight32(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte mask) => AlignRight32(left, right, mask);

            /// <summary>
            /// __m256i _mm256_alignr_epi64 (__m256i a, __m256i b, const int count)
            ///   VALIGNQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<long> AlignRight64(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte mask) => AlignRight64(left, right, mask);

            /// <summary>
            /// __m256i _mm256_alignr_epi64 (__m256i a, __m256i b, const int count)
            ///   VALIGNQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<ulong> AlignRight64(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte mask) => AlignRight64(left, right, mask);

            /// <summary>
            /// __m256i _mm256_cmpge_epi32 (__m256i a, __m256i b)
            ///   VPCMPD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(5)
            /// </summary>
            public static Vector256<int> CompareGreaterThanOrEqual(Vector256<int> left, Vector256<int> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epi32 (__m256i a, __m256i b)
            ///   VPCMPD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(1)
            /// </summary>
            public static Vector256<int> CompareLessThan(Vector256<int> left, Vector256<int> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epi32 (__m256i a, __m256i b)
            ///   VPCMPD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(2)
            /// </summary>
            public static Vector256<int> CompareLessThanOrEqual(Vector256<int> left, Vector256<int> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epi32 (__m256i a, __m256i b)
            ///   VPCMPD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(4)
            /// </summary>
            public static Vector256<int> CompareNotEqual(Vector256<int> left, Vector256<int> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epi64 (__m256i a, __m256i b)
            ///   VPCMPQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(5)
            /// </summary>
            public static Vector256<long> CompareGreaterThanOrEqual(Vector256<long> left, Vector256<long> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epi64 (__m256i a, __m256i b)
            ///   VPCMPQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(1)
            /// </summary>
            public static Vector256<long> CompareLessThan(Vector256<long> left, Vector256<long> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epi64 (__m256i a, __m256i b)
            ///   VPCMPQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(2)
            /// </summary>
            public static Vector256<long> CompareLessThanOrEqual(Vector256<long> left, Vector256<long> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epi64 (__m256i a, __m256i b)
            ///   VPCMPQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(4)
            /// </summary>
            public static Vector256<long> CompareNotEqual(Vector256<long> left, Vector256<long> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpgt_epu32 (__m256i a, __m256i b)
            ///   VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(6)
            /// </summary>
            public static Vector256<uint> CompareGreaterThan(Vector256<uint> left, Vector256<uint> right) => CompareGreaterThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epu32 (__m256i a, __m256i b)
            ///   VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(5)
            /// </summary>
            public static Vector256<uint> CompareGreaterThanOrEqual(Vector256<uint> left, Vector256<uint> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epu32 (__m256i a, __m256i b)
            ///   VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(1)
            /// </summary>
            public static Vector256<uint> CompareLessThan(Vector256<uint> left, Vector256<uint> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epu32 (__m256i a, __m256i b)
            ///   VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(2)
            /// </summary>
            public static Vector256<uint> CompareLessThanOrEqual(Vector256<uint> left, Vector256<uint> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epu32 (__m256i a, __m256i b)
            ///   VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8(4)
            /// </summary>
            public static Vector256<uint> CompareNotEqual(Vector256<uint> left, Vector256<uint> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpgt_epu64 (__m256i a, __m256i b)
            ///   VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(6)
            /// </summary>
            public static Vector256<ulong> CompareGreaterThan(Vector256<ulong> left, Vector256<ulong> right) => CompareGreaterThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epu64 (__m256i a, __m256i b)
            ///   VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(5)
            /// </summary>
            public static Vector256<ulong> CompareGreaterThanOrEqual(Vector256<ulong> left, Vector256<ulong> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epu64 (__m256i a, __m256i b)
            ///   VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(1)
            /// </summary>
            public static Vector256<ulong> CompareLessThan(Vector256<ulong> left, Vector256<ulong> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epu64 (__m256i a, __m256i b)
            ///   VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(2)
            /// </summary>
            public static Vector256<ulong> CompareLessThanOrEqual(Vector256<ulong> left, Vector256<ulong> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epu64 (__m256i a, __m256i b)
            ///   VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8(4)
            /// </summary>
            public static Vector256<ulong> CompareNotEqual(Vector256<ulong> left, Vector256<ulong> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi8 (__m256i a)
            ///   VPMOVDB xmm1/m64 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<int> value) => ConvertToVector128Byte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi8 (__m256i a)
            ///   VPMOVQB xmm1/m32 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<long> value) => ConvertToVector128Byte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi8 (__m256i a)
            ///   VPMOVDB xmm1/m64 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<uint> value) => ConvertToVector128Byte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi8 (__m256i a)
            ///   VPMOVQB xmm1/m32 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<ulong> value) => ConvertToVector128Byte(value);

            /// <summary>
            /// __m128i _mm256_cvtusepi32_epi8 (__m256i a)
            ///   VPMOVUSDB xmm1/m64 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<uint> value) => ConvertToVector128ByteWithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtusepi64_epi8 (__m256i a)
            ///   VPMOVUSQB xmm1/m32 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ulong> value) => ConvertToVector128ByteWithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi16 (__m256i a)
            ///   VPMOVDW xmm1/m128 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<short> ConvertToVector128Int16(Vector256<int> value) => ConvertToVector128Int16(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi16 (__m256i a)
            ///   VPMOVQW xmm1/m64 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<short> ConvertToVector128Int16(Vector256<long> value) => ConvertToVector128Int16(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi16 (__m256i a)
            ///   VPMOVDW xmm1/m128 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<short> ConvertToVector128Int16(Vector256<uint> value) => ConvertToVector128Int16(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi16 (__m256i a)
            ///   VPMOVQW xmm1/m64 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<short> ConvertToVector128Int16(Vector256<ulong> value) => ConvertToVector128Int16(value);

            /// <summary>
            /// __m128i _mm256_cvtsepi32_epi16 (__m256i a)
            ///   VPMOVSDW xmm1/m128 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector256<int> value) => ConvertToVector128Int16WithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtsepi64_epi16 (__m256i a)
            ///   VPMOVSQW xmm1/m64 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector256<long> value) => ConvertToVector128Int16WithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi32 (__m256i a)
            ///   VPMOVQD xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<int> ConvertToVector128Int32(Vector256<long> value) => ConvertToVector128Int32(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi32 (__m256i a)
            ///   VPMOVQD xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<int> ConvertToVector128Int32(Vector256<ulong> value) => ConvertToVector128Int32(value);

            /// <summary>
            /// __m128i _mm256_cvtsepi64_epi32 (__m256i a)
            ///   VPMOVSQD xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<int> ConvertToVector128Int32WithSaturation(Vector256<long> value) => ConvertToVector128Int32WithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi8 (__m256i a)
            ///   VPMOVDB xmm1/m64 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<int> value) => ConvertToVector128SByte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi8 (__m256i a)
            ///   VPMOVQB xmm1/m32 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<long> value) => ConvertToVector128SByte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi8 (__m256i a)
            ///   VPMOVDB xmm1/m64 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<uint> value) => ConvertToVector128SByte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi8 (__m256i a)
            ///   VPMOVQB xmm1/m32 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ulong> value) => ConvertToVector128SByte(value);

            /// <summary>
            /// __m128i _mm256_cvtsepi32_epi8 (__m256i a)
            ///   VPMOVSDB xmm1/m64 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<int> value) => ConvertToVector128SByteWithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtsepi64_epi8 (__m256i a)
            ///   VPMOVSQB xmm1/m32 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<long> value) => ConvertToVector128SByteWithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi16 (__m256i a)
            ///   VPMOVDW xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<ushort> ConvertToVector128UInt16(Vector256<int> value) => ConvertToVector128UInt16(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi16 (__m256i a)
            ///   VPMOVQW xmm1/m64 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<ushort> ConvertToVector128UInt16(Vector256<long> value) => ConvertToVector128UInt16(value);

            /// <summary>
            /// __m128i _mm256_cvtepi32_epi16 (__m256i a)
            ///   VPMOVDW xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<ushort> ConvertToVector128UInt16(Vector256<uint> value) => ConvertToVector128UInt16(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi16 (__m256i a)
            ///   VPMOVQW xmm1/m64 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<ushort> ConvertToVector128UInt16(Vector256<ulong> value) => ConvertToVector128UInt16(value);

            /// <summary>
            /// __m128i _mm256_cvtusepi32_epi16 (__m256i a)
            ///   VPMOVUSDW xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector256<uint> value) => ConvertToVector128UInt16WithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtusepi64_epi16 (__m256i a)
            ///   VPMOVUSQW xmm1/m64 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector256<ulong> value) => ConvertToVector128UInt16WithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi32 (__m256i a)
            ///   VPMOVQD xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<uint> ConvertToVector128UInt32(Vector256<long> value) => ConvertToVector128UInt32(value);

            /// <summary>
            /// __m128i _mm256_cvtepi64_epi32 (__m256i a)
            ///   VPMOVQD xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<uint> ConvertToVector128UInt32(Vector256<ulong> value) => ConvertToVector128UInt32(value);

            /// <summary>
            /// __m128i _mm256_cvtpd_epu32 (__m256d a)
            ///   VCVTPD2UDQ xmm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector128<uint> ConvertToVector128UInt32(Vector256<double> value) => ConvertToVector128UInt32(value);

            /// <summary>
            /// __m128i _mm256_cvtusepi64_epi32 (__m256i a)
            ///   VPMOVUSQD xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<uint> ConvertToVector128UInt32WithSaturation(Vector256<ulong> value) => ConvertToVector128UInt32WithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvttpd_epu32 (__m256d a)
            ///   VCVTTPD2UDQ xmm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector256<double> value) => ConvertToVector128UInt32WithTruncation(value);

            /// <summary>
            /// __m256d _mm512_cvtepu32_pd (__m128i a)
            ///   VCVTUDQ2PD ymm1 {k1}{z}, xmm2/m128/m32bcst
            /// </summary>
            public static Vector256<double> ConvertToVector256Double(Vector128<uint> value) => ConvertToVector256Double(value);

            /// <summary>
            /// __m256 _mm256_cvtepu32_ps (__m256i a)
            ///   VCVTUDQ2PS ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<float> ConvertToVector256Single(Vector256<uint> value) => ConvertToVector256Single(value);

            /// <summary>
            /// __m256i _mm256_cvtps_epu32 (__m256 a)
            ///   VCVTPS2UDQ ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<uint> ConvertToVector256UInt32(Vector256<float> value) => ConvertToVector256UInt32(value);

            /// <summary>
            /// __m256i _mm256_cvttps_epu32 (__m256 a)
            ///   VCVTTPS2UDQ ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<uint> ConvertToVector256UInt32WithTruncation(Vector256<float> value) => ConvertToVector256UInt32WithTruncation(value);

            /// <summary>
            /// __m256 _mm256_fixupimm_ps(__m256 a, __m256 b, __m256i tbl, int imm);
            ///   VFIXUPIMMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<float> Fixup(Vector256<float> left, Vector256<float> right, Vector256<int> table, [ConstantExpected] byte control) => Fixup(left, right, table, control);

            /// <summary>
            /// __m256d _mm256_fixupimm_pd(__m256d a, __m256d b, __m256i tbl, int imm);
            ///   VFIXUPIMMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<double> Fixup(Vector256<double> left, Vector256<double> right, Vector256<long> table, [ConstantExpected] byte control) => Fixup(left, right, table, control);

            /// <summary>
            /// __m256 _mm256_getexp_ps (__m256 a)
            ///   VGETEXPPS ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<float> GetExponent(Vector256<float> value) => GetExponent(value);

            /// <summary>
            /// __m256d _mm256_getexp_pd (__m256d a)
            ///   VGETEXPPD ymm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector256<double> GetExponent(Vector256<double> value) => GetExponent(value);

            /// <summary>
            /// __m256 _mm256_getmant_ps (__m256 a)
            ///   VGETMANTPS ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<float> GetMantissa(Vector256<float> value, [ConstantExpected(Max = (byte)(0x0F))] byte control) => GetMantissa(value, control);

            /// <summary>
            /// __m256d _mm256_getmant_pd (__m256d a)
            ///   VGETMANTPD ymm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector256<double> GetMantissa(Vector256<double> value, [ConstantExpected(Max = (byte)(0x0F))] byte control) => GetMantissa(value, control);

            /// <summary>
            /// __m256i _mm256_max_epi64 (__m256i a, __m256i b)
            ///   VPMAXSQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> Max(Vector256<long> left, Vector256<long> right) => Max(left, right);

            /// <summary>
            /// __m256i _mm256_max_epu64 (__m256i a, __m256i b)
            ///   VPMAXUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right) => Max(left, right);

            /// <summary>
            /// __m256i _mm256_min_epi64 (__m256i a, __m256i b)
            ///   VPMINSQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> Min(Vector256<long> left, Vector256<long> right) => Min(left, right);

            /// <summary>
            /// __m256i _mm256_min_epu64 (__m256i a, __m256i b)
            ///   VPMINUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right) => Min(left, right);

            /// <summary>
            /// __m256i _mm256_permute4x64_epi64 (__m256i a, __m256i b)
            ///   VPERMQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> PermuteVar4x64(Vector256<long> value, Vector256<long> control) => PermuteVar4x64(value, control);

            /// <summary>
            /// __m256i _mm256_permute4x64_pd (__m256d a, __m256i b)
            ///   VPERMQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> PermuteVar4x64(Vector256<ulong> value, Vector256<ulong> control) => PermuteVar4x64(value, control);

            /// <summary>
            /// __m256d _mm256_permute4x64_pd (__m256d a, __m256i b)
            ///   VPERMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<double> PermuteVar4x64(Vector256<double> value, Vector256<long> control) => PermuteVar4x64(value, control);

            /// <summary>
            /// __m256i _mm256_permutex2var_epi64 (__m256i a, __m256i idx, __m256i b)
            ///   VPERMI2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            ///   VPERMT2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> PermuteVar4x64x2(Vector256<long> lower, Vector256<long> indices, Vector256<long> upper) => PermuteVar4x64x2(lower, indices, upper);

            /// <summary>
            /// __m256i _mm256_permutex2var_epi64 (__m256i a, __m256i idx, __m256i b)
            ///   VPERMI2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            ///   VPERMT2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> PermuteVar4x64x2(Vector256<ulong> lower, Vector256<ulong> indices, Vector256<ulong> upper) => PermuteVar4x64x2(lower, indices, upper);

            /// <summary>
            /// __m256d _mm256_permutex2var_pd (__m256d a, __m256i idx, __m256i b)
            ///   VPERMI2PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            ///   VPERMT2PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<double> PermuteVar4x64x2(Vector256<double> lower, Vector256<long> indices, Vector256<double> upper) => PermuteVar4x64x2(lower, indices, upper);

            /// <summary>
            /// __m256i _mm256_permutex2var_epi32 (__m256i a, __m256i idx, __m256i b)
            ///   VPERMI2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            ///   VPERMT2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<int> PermuteVar8x32x2(Vector256<int> lower, Vector256<int> indices, Vector256<int> upper) => PermuteVar8x32x2(lower, indices, upper);

            /// <summary>
            /// __m256i _mm256_permutex2var_epi32 (__m256i a, __m256i idx, __m256i b)
            ///   VPERMI2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            ///   VPERMT2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<uint> PermuteVar8x32x2(Vector256<uint> lower, Vector256<uint> indices, Vector256<uint> upper) => PermuteVar8x32x2(lower, indices, upper);

            /// <summary>
            /// __m256 _mm256_permutex2var_ps (__m256 a, __m256i idx, __m256i b)
            ///   VPERMI2PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            ///   VPERMT2PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<float> PermuteVar8x32x2(Vector256<float> lower, Vector256<int> indices, Vector256<float> upper) => PermuteVar8x32x2(lower, indices, upper);

            /// <summary>
            /// __m256 _mm256_rcp14_ps (__m256 a, __m256 b)
            ///   VRCP14PS ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<float> Reciprocal14(Vector256<float> value) => Reciprocal14(value);

            /// <summary>
            /// __m256d _mm256_rcp14_pd (__m256d a, __m256d b)
            ///   VRCP14PD ymm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector256<double> Reciprocal14(Vector256<double> value) => Reciprocal14(value);

            /// <summary>
            /// __m256 _mm256_rsqrt14_ps (__m256 a, __m256 b)
            ///   VRSQRT14PS ymm1 {k1}{z}, ymm2/m256/m32bcst
            /// </summary>
            public static Vector256<float> ReciprocalSqrt14(Vector256<float> value) => ReciprocalSqrt14(value);

            /// <summary>
            /// __m256d _mm256_rsqrt14_pd (__m256d a, __m256d b)
            ///   VRSQRT14PD ymm1 {k1}{z}, ymm2/m256/m64bcst
            /// </summary>
            public static Vector256<double> ReciprocalSqrt14(Vector256<double> value) => ReciprocalSqrt14(value);

            /// <summary>
            /// __m256i _mm256_rol_epi32 (__m256i a, int imm8)
            ///   VPROLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<int> RotateLeft(Vector256<int> value, [ConstantExpected] byte count) => RotateLeft(value, count);

            /// <summary>
            /// __m256i _mm256_rol_epi32 (__m256i a, int imm8)
            ///   VPROLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<uint> RotateLeft(Vector256<uint> value, [ConstantExpected] byte count) => RotateLeft(value, count);

            /// <summary>
            /// __m256i _mm256_rol_epi64 (__m256i a, int imm8)
            ///   VPROLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<long> RotateLeft(Vector256<long> value, [ConstantExpected] byte count) => RotateLeft(value, count);

            /// <summary>
            /// __m256i _mm256_rol_epi64 (__m256i a, int imm8)
            ///   VPROLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<ulong> RotateLeft(Vector256<ulong> value, [ConstantExpected] byte count) => RotateLeft(value, count);

            /// <summary>
            /// __m256i _mm256_rolv_epi32 (__m256i a, __m256i b)
            ///   VPROLDV ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<int> RotateLeftVariable(Vector256<int> value, Vector256<uint> count) => RotateLeftVariable(value, count);

            /// <summary>
            /// __m256i _mm256_rolv_epi32 (__m256i a, __m256i b)
            ///   VPROLDV ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<uint> RotateLeftVariable(Vector256<uint> value, Vector256<uint> count) => RotateLeftVariable(value, count);

            /// <summary>
            /// __m256i _mm256_rolv_epi64 (__m256i a, __m256i b)
            ///   VPROLQV ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> RotateLeftVariable(Vector256<long> value, Vector256<ulong> count) => RotateLeftVariable(value, count);

            /// <summary>
            /// __m256i _mm256_rolv_epi64 (__m256i a, __m256i b)
            ///   VPROLQV ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> RotateLeftVariable(Vector256<ulong> value, Vector256<ulong> count) => RotateLeftVariable(value, count);

            /// <summary>
            /// __m256i _mm256_ror_epi32 (__m256i a, int imm8)
            ///   VPRORD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<int> RotateRight(Vector256<int> value, [ConstantExpected] byte count) => RotateRight(value, count);

            /// <summary>
            /// __m256i _mm256_ror_epi32 (__m256i a, int imm8)
            ///   VPRORD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<uint> RotateRight(Vector256<uint> value, [ConstantExpected] byte count) => RotateRight(value, count);

            /// <summary>
            /// __m256i _mm256_ror_epi64 (__m256i a, int imm8)
            ///   VPRORQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<long> RotateRight(Vector256<long> value, [ConstantExpected] byte count) => RotateRight(value, count);

            /// <summary>
            /// __m256i _mm256_ror_epi64 (__m256i a, int imm8)
            ///   VPRORQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<ulong> RotateRight(Vector256<ulong> value, [ConstantExpected] byte count) => RotateRight(value, count);

            /// <summary>
            /// __m256i _mm256_rorv_epi32 (__m256i a, __m256i b)
            ///   VPRORDV ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<int> RotateRightVariable(Vector256<int> value, Vector256<uint> count) => RotateRightVariable(value, count);

            /// <summary>
            /// __m256i _mm256_rorv_epi32 (__m256i a, __m256i b)
            ///   VPRORDV ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<uint> RotateRightVariable(Vector256<uint> value, Vector256<uint> count) => RotateRightVariable(value, count);

            /// <summary>
            /// __m256i _mm256_rorv_epi64 (__m256i a, __m256i b)
            ///   VPRORQV ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> RotateRightVariable(Vector256<long> value, Vector256<ulong> count) => RotateRightVariable(value, count);

            /// <summary>
            /// __m256i _mm256_rorv_epi64 (__m256i a, __m256i b)
            ///   VPRORQV ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<ulong> RotateRightVariable(Vector256<ulong> value, Vector256<ulong> count) => RotateRightVariable(value, count);

            /// <summary>
            /// __m256 _mm256_roundscale_ps (__m256 a, int imm)
            ///   VRNDSCALEPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<float> RoundScale(Vector256<float> value, [ConstantExpected] byte control) => RoundScale(value, control);

            /// <summary>
            /// __m256d _mm256_roundscale_pd (__m256d a, int imm)
            ///   VRNDSCALEPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<double> RoundScale(Vector256<double> value, [ConstantExpected] byte control) => RoundScale(value, control);

            /// <summary>
            /// __m256 _mm256_scalef_ps (__m256 a, int imm)
            ///   VSCALEFPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
            /// </summary>
            public static Vector256<float> Scale(Vector256<float> left, Vector256<float> right) => Scale(left, right);

            /// <summary>
            /// __m256d _mm256_scalef_pd (__m256d a, int imm)
            ///   VSCALEFPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<double> Scale(Vector256<double> left, Vector256<double> right) => Scale(left, right);

            /// <summary>
            /// __m256i _mm256_sra_epi64 (__m256i a, __m128i count)
            ///   VPSRAQ ymm1 {k1}{z}, ymm2, xmm3/m128
            /// </summary>
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, Vector128<long> count) => ShiftRightArithmetic(value, count);

            /// <summary>
            /// __m256i _mm256_srai_epi64 (__m256i a, int imm8)
            ///   VPSRAQ ymm1 {k1}{z}, ymm2, imm8
            /// </summary>
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, [ConstantExpected] byte count) => ShiftRightArithmetic(value, count);

            /// <summary>
            /// __m256i _mm256_srav_epi64 (__m256i a, __m256i count)
            ///   VPSRAVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
            /// </summary>
            public static Vector256<long> ShiftRightArithmeticVariable(Vector256<long> value, Vector256<ulong> count) => ShiftRightArithmeticVariable(value, count);

            /// <summary>
            /// __m256d _mm256_shuffle_f64x2 (__m256d a, __m256d b, const int imm8)
            ///   VSHUFF64x2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<double> Shuffle2x128(Vector256<double> left, Vector256<double> right, [ConstantExpected] byte control) => Shuffle2x128(left, right, control);

            /// <summary>
            /// __m256i _mm256_shuffle_i32x4 (__m256i a, __m256i b, const int imm8)
            ///   VSHUFI32x4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<int> Shuffle2x128(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte control) => Shuffle2x128(left, right, control);

            /// <summary>
            /// __m256i _mm256_shuffle_i64x2 (__m256i a, __m256i b, const int imm8)
            ///   VSHUFI64x2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<long> Shuffle2x128(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte control) => Shuffle2x128(left, right, control);

            /// <summary>
            /// __m256 _mm256_shuffle_f32x4 (__m256 a, __m256 b, const int imm8)
            ///   VSHUFF32x4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<float> Shuffle2x128(Vector256<float> left, Vector256<float> right, [ConstantExpected] byte control) => Shuffle2x128(left, right, control);

            /// <summary>
            /// __m256i _mm256_shuffle_i32x4 (__m256i a, __m256i b, const int imm8)
            ///   VSHUFI32x4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<uint> Shuffle2x128(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte control) => Shuffle2x128(left, right, control);

            /// <summary>
            /// __m256i _mm256_shuffle_i64x2 (__m256i a, __m256i b, const int imm8)
            ///   VSHUFI64x2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<ulong> Shuffle2x128(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte control) => Shuffle2x128(left, right, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_si256 (__m256i a, __m256i b, __m256i c, byte imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256, imm8
            /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
            /// </summary>
            public static Vector256<sbyte> TernaryLogic(Vector256<sbyte> a, Vector256<sbyte> b, Vector256<sbyte> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_si256 (__m256i a, __m256i b, __m256i c, byte imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256, imm8
            /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
            /// </summary>
            public static Vector256<byte> TernaryLogic(Vector256<byte> a, Vector256<byte> b, Vector256<byte> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_si256 (__m256i a, __m256i b, __m256i c, short imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256, imm8
            /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
            /// </summary>
            public static Vector256<short> TernaryLogic(Vector256<short> a, Vector256<short> b, Vector256<short> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_si256 (__m256i a, __m256i b, __m256i c, short imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256, imm8
            /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
            /// </summary>
            public static Vector256<ushort> TernaryLogic(Vector256<ushort> a, Vector256<ushort> b, Vector256<ushort> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_epi32 (__m256i a, __m256i b, __m256i c, int imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<int> TernaryLogic(Vector256<int> a, Vector256<int> b, Vector256<int> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_epi32 (__m256i a, __m256i b, __m256i c, int imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// </summary>
            public static Vector256<uint> TernaryLogic(Vector256<uint> a, Vector256<uint> b, Vector256<uint> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_epi64 (__m256i a, __m256i b, __m256i c, int imm)
            ///   VPTERNLOGQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<long> TernaryLogic(Vector256<long> a, Vector256<long> b, Vector256<long> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256i _mm256_ternarylogic_epi64 (__m256i a, __m256i b, __m256i c, int imm)
            ///   VPTERNLOGQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// </summary>
            public static Vector256<ulong> TernaryLogic(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256 _mm256_ternarylogic_ps (__m256 a, __m256 b, __m256 c, int imm)
            ///   VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
            /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
            /// </summary>
            public static Vector256<float> TernaryLogic(Vector256<float> a, Vector256<float> b, Vector256<float> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            /// <summary>
            /// __m256d _mm256_ternarylogic_pd (__m256d a, __m256d b, __m256d c, int imm)
            ///   VPTERNLOGQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
            /// The above native signature does not exist. We provide this additional overload for consistency with the other bitwise APIs.
            /// </summary>
            public static Vector256<double> TernaryLogic(Vector256<double> a, Vector256<double> b, Vector256<double> c, [ConstantExpected] byte control) => TernaryLogic(a, b, c, control);

            // From AVX512BW VL
            /// <summary>
            /// __m256i _mm256_cmpgt_epu8 (__m256i a, __m256i b)
            ///   VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(6)
            /// </summary>
            public static Vector256<byte> CompareGreaterThan(Vector256<byte> left, Vector256<byte> right) => CompareGreaterThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epu8 (__m256i a, __m256i b)
            ///   VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(5)
            /// </summary>
            public static Vector256<byte> CompareGreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epu8 (__m256i a, __m256i b)
            ///   VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(1)
            /// </summary>
            public static Vector256<byte> CompareLessThan(Vector256<byte> left, Vector256<byte> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epu8 (__m256i a, __m256i b)
            ///   VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(2)
            /// </summary>
            public static Vector256<byte> CompareLessThanOrEqual(Vector256<byte> left, Vector256<byte> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epu8 (__m256i a, __m256i b)
            ///   VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(4)
            /// </summary>
            public static Vector256<byte> CompareNotEqual(Vector256<byte> left, Vector256<byte> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epi16 (__m256i a, __m256i b)
            ///   VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(5)
            /// </summary>
            public static Vector256<short> CompareGreaterThanOrEqual(Vector256<short> left, Vector256<short> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epi16 (__m256i a, __m256i b)
            ///   VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(1)
            /// </summary>
            public static Vector256<short> CompareLessThan(Vector256<short> left, Vector256<short> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epi16 (__m256i a, __m256i b)
            ///   VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(2)
            /// </summary>
            public static Vector256<short> CompareLessThanOrEqual(Vector256<short> left, Vector256<short> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epi16 (__m256i a, __m256i b)
            ///   VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(4)
            /// </summary>
            public static Vector256<short> CompareNotEqual(Vector256<short> left, Vector256<short> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epi8 (__m256i a, __m256i b)
            ///   VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(5)
            /// </summary>
            public static Vector256<sbyte> CompareGreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epi8 (__m256i a, __m256i b)
            ///   VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(1)
            /// </summary>
            public static Vector256<sbyte> CompareLessThan(Vector256<sbyte> left, Vector256<sbyte> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epi8 (__m256i a, __m256i b)
            ///   VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(2)
            /// </summary>
            public static Vector256<sbyte> CompareLessThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epi8 (__m256i a, __m256i b)
            ///   VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(4)
            /// </summary>
            public static Vector256<sbyte> CompareNotEqual(Vector256<sbyte> left, Vector256<sbyte> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpgt_epu16 (__m256i a, __m256i b)
            ///   VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(6)
            /// </summary>
            public static Vector256<ushort> CompareGreaterThan(Vector256<ushort> left, Vector256<ushort> right) => CompareGreaterThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmpge_epu16 (__m256i a, __m256i b)
            ///   VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(5)
            /// </summary>
            public static Vector256<ushort> CompareGreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) => CompareGreaterThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmplt_epu16 (__m256i a, __m256i b)
            ///   VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(1)
            /// </summary>
            public static Vector256<ushort> CompareLessThan(Vector256<ushort> left, Vector256<ushort> right) => CompareLessThan(left, right);

            /// <summary>
            /// __m256i _mm256_cmple_epu16 (__m256i a, __m256i b)
            ///   VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(2)
            /// </summary>
            public static Vector256<ushort> CompareLessThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) => CompareLessThanOrEqual(left, right);

            /// <summary>
            /// __m256i _mm256_cmpne_epu16 (__m256i a, __m256i b)
            ///   VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(4)
            /// </summary>
            public static Vector256<ushort> CompareNotEqual(Vector256<ushort> left, Vector256<ushort> right) => CompareNotEqual(left, right);

            /// <summary>
            /// __m128i _mm256_cvtepi16_epi8 (__m256i a)
            ///   VPMOVWB xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<short> value) => ConvertToVector128Byte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi16_epi8 (__m256i a)
            ///   VPMOVWB xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<ushort> value) => ConvertToVector128Byte(value);

            /// <summary>
            /// __m128i _mm256_cvtusepi16_epi8 (__m256i a)
            ///   VPMOVUWB xmm1/m128 {k1}{z}, ymm2
            /// </summary>
            public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ushort> value) => ConvertToVector128ByteWithSaturation(value);

            /// <summary>
            /// __m128i _mm256_cvtepi16_epi8 (__m256i a)
            ///   VPMOVWB xmm1/m128 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<short> value) => ConvertToVector128SByte(value);

            /// <summary>
            /// __m128i _mm256_cvtepi16_epi8 (__m256i a)
            ///   VPMOVWB xmm1/m128 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ushort> value) => ConvertToVector128SByte(value);

            /// <summary>
            /// __m128i _mm256_cvtsepi16_epi8 (__m256i a)
            ///   VPMOVSWB xmm1/m128 {k1}{z}, zmm2
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<short> value) => ConvertToVector128SByteWithSaturation(value);

            /// <summary>
            /// __m256i _mm256_permutevar16x16_epi16 (__m256i a, __m256i b)
            ///   VPERMW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<short> PermuteVar16x16(Vector256<short> left, Vector256<short> control) => PermuteVar16x16(left, control);

            /// <summary>
            /// __m256i _mm256_permutevar16x16_epi16 (__m256i a, __m256i b)
            ///   VPERMW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<ushort> PermuteVar16x16(Vector256<ushort> left, Vector256<ushort> control) => PermuteVar16x16(left, control);

            /// <summary>
            /// __m256i _mm256_permutex2var_epi16 (__m256i a, __m256i idx, __m256i b)
            ///   VPERMI2W ymm1 {k1}{z}, ymm2, ymm3/m256
            ///   VPERMT2W ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<short> PermuteVar16x16x2(Vector256<short> lower, Vector256<short> indices, Vector256<short> upper) => PermuteVar16x16x2(lower, indices, upper);

            /// <summary>
            /// __m256i _mm256_permutex2var_epi16 (__m256i a, __m256i idx, __m256i b)
            ///   VPERMI2W ymm1 {k1}{z}, ymm2, ymm3/m256
            ///   VPERMT2W ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<ushort> PermuteVar16x16x2(Vector256<ushort> lower, Vector256<ushort> indices, Vector256<ushort> upper) => PermuteVar16x16x2(lower, indices, upper);

            /// <summary>
            /// __m256i _mm256_sllv_epi16 (__m256i a, __m256i count)
            ///   VPSLLVW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<short> ShiftLeftLogicalVariable(Vector256<short> value, Vector256<ushort> count) => ShiftLeftLogicalVariable(value, count);

            /// <summary>
            /// __m256i _mm256_sllv_epi16 (__m256i a, __m256i count)
            ///   VPSLLVW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<ushort> ShiftLeftLogicalVariable(Vector256<ushort> value, Vector256<ushort> count) => ShiftLeftLogicalVariable(value, count);

            /// <summary>
            /// __m256i _mm256_srav_epi16 (__m256i a, __m256i count)
            ///   VPSRAVW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<short> ShiftRightArithmeticVariable(Vector256<short> value, Vector256<ushort> count) => ShiftRightArithmeticVariable(value, count);

            /// <summary>
            /// __m256i _mm256_srlv_epi16 (__m256i a, __m256i count)
            ///   VPSRLVW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<short> ShiftRightLogicalVariable(Vector256<short> value, Vector256<ushort> count) => ShiftRightLogicalVariable(value, count);

            /// <summary>
            /// __m256i _mm256_srlv_epi16 (__m256i a, __m256i count)
            ///   VPSRLVW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<ushort> ShiftRightLogicalVariable(Vector256<ushort> value, Vector256<ushort> count) => ShiftRightLogicalVariable(value, count);

            /// <summary>
            /// __m256i _mm256_dbsad_epu8 (__m256i a, __m256i b, int imm8)
            ///   VDBPSADBW ymm1 {k1}{z}, ymm2, ymm3/m256
            /// </summary>
            public static Vector256<ushort> SumAbsoluteDifferencesInBlock32(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte control) => SumAbsoluteDifferencesInBlock32(left, right, control);
        }

        [Intrinsic]
        public abstract class V512 : Avx512BW
        {
            internal V512() { }

            public static new bool IsSupported { get => IsSupported; }
        }
    }
}
