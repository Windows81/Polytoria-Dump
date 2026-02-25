namespace Mirror.BouncyCastle.Crypto.Utilities;

[Token(Token = "0x200011B")]
internal static class Pack
{

	[Address(RVA = "0x11EF840", Offset = "0x11EEA40", Length = "0x53")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B35")]
	internal static uint BE_To_UInt32(Byte[] bs) { }

	[Address(RVA = "0x11EF7C0", Offset = "0x11EE9C0", Length = "0x74")]
	[CalledBy(Type = typeof(Sha1Digest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha224Digest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha256Digest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SM3Digest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B36")]
	internal static uint BE_To_UInt32(Byte[] bs, int off) { }

	[Address(RVA = "0x11EF700", Offset = "0x11EE900", Length = "0xB0")]
	[CalledBy(Type = typeof(Mod), Member = "Random", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B38")]
	internal static void BE_To_UInt32(Byte[] bs, int off, UInt32[] ns) { }

	[Address(RVA = "0x11EF8A0", Offset = "0x11EEAA0", Length = "0xCB")]
	[CalledBy(Type = typeof(BigInteger), Member = "MakeMagnitudeBE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(UInt32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B39")]
	internal static void BE_To_UInt32(Byte[] bs, int bsOff, UInt32[] ns, int nsOff, int nsLen) { }

	[Address(RVA = "0x11EF690", Offset = "0x11EE890", Length = "0x6B")]
	[CalledBy(Type = typeof(BigInteger), Member = "MakeMagnitudeBE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(UInt32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B37")]
	internal static uint BE_To_UInt32_Low(Byte[] bs, int off, int len) { }

	[Address(RVA = "0x11EFAB0", Offset = "0x11EECB0", Length = "0x104")]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BasicGcmExponentiator), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicGcmMultiplier), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicGcmMultiplier), Member = "MultiplyH", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "AsFieldElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(FieldElement&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tables4kGcmMultiplier), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B3F")]
	internal static ulong BE_To_UInt64(Byte[] bs, int off) { }

	[Address(RVA = "0x11EF970", Offset = "0x11EEB70", Length = "0x13F")]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "ProcessFilledBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "Finish", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B40")]
	internal static void BE_To_UInt64(Byte[] bs, int off, UInt64[] ns) { }

	[Address(RVA = "0x11EFBC0", Offset = "0x11EEDC0", Length = "0xA8")]
	[CalledBy(Type = typeof(SecureRandom), Member = "NextLong", ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B3E")]
	internal static ulong BE_To_UInt64(Byte[] bs) { }

	[Address(RVA = "0x11EFD60", Offset = "0x11EEF60", Length = "0xCB")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B48")]
	internal static void LE_To_UInt32(Byte[] bs, int bOff, UInt32[] ns, int nOff, int count) { }

	[Address(RVA = "0x11EFE30", Offset = "0x11EF030", Length = "0xB0")]
	[CalledBy(Type = typeof(Blake2sDigest), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "InitM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "InitKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B47")]
	internal static void LE_To_UInt32(Byte[] bs, int off, UInt32[] ns) { }

	[Address(RVA = "0x11EFCF0", Offset = "0x11EEEF0", Length = "0x6D")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B45")]
	internal static uint LE_To_UInt32(Byte[] bs, int off) { }

	[Address(RVA = "0x11EFC70", Offset = "0x11EEE70", Length = "0x7F")]
	[CalledBy(Type = typeof(BigInteger), Member = "MakeMagnitudeLE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B46")]
	internal static uint LE_To_UInt32_Low(Byte[] bs, int off, int len) { }

	[Address(RVA = "0x11F0030", Offset = "0x11EF230", Length = "0x105")]
	[CalledBy(Type = typeof(Blake2bDigest), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeccakDigest), Member = "PadAndSwitchToSqueezingPhase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeccakDigest), Member = "Squeeze", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeccakDigest), Member = "KeccakAbsorb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B4C")]
	internal static ulong LE_To_UInt64(Byte[] bs, int off) { }

	[Address(RVA = "0x11EFEF0", Offset = "0x11EF0F0", Length = "0x13F")]
	[CalledBy(Type = typeof(Blake2bDigest), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B4D")]
	internal static void LE_To_UInt64(Byte[] bs, int off, UInt64[] ns) { }

	[Address(RVA = "0x11F0190", Offset = "0x11EF390", Length = "0xAC")]
	[CalledBy(Type = typeof(SM3Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B34")]
	internal static void UInt32_To_BE(UInt32[] ns, Byte[] bs, int off) { }

	[Address(RVA = "0x11F0240", Offset = "0x11EF440", Length = "0x66")]
	[CalledBy(Type = typeof(BigInteger), Member = "ToByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Nat), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat128), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat160), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat192), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat224), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat256), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Sha1Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha224Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha256Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B33")]
	internal static void UInt32_To_BE(uint n, Byte[] bs, int off) { }

	[Address(RVA = "0x11F0140", Offset = "0x11EF340", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B32")]
	internal static void UInt32_To_BE(uint n, Byte[] bs) { }

	[Address(RVA = "0x11F0360", Offset = "0x11EF560", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B41")]
	internal static void UInt32_To_LE(uint n, Byte[] bs) { }

	[Address(RVA = "0x11F03B0", Offset = "0x11EF5B0", Length = "0x66")]
	[CalledBy(Type = typeof(Blake2sDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MD4Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MD5Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD128Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD160Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD256Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD320Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B42")]
	internal static void UInt32_To_LE(uint n, Byte[] bs, int off) { }

	[Address(RVA = "0x11F02B0", Offset = "0x11EF4B0", Length = "0xAA")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "AdjustChaining", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B43")]
	internal static void UInt32_To_LE(UInt32[] ns, Byte[] bs, int off) { }

	[Address(RVA = "0x11F0420", Offset = "0x11EF620", Length = "0xC3")]
	[CalledBy(Type = typeof(Blake2sDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B44")]
	internal static void UInt32_To_LE(UInt32[] ns, int nsOff, int nsLen, Byte[] bs, int bsOff) { }

	[Address(RVA = "0x11F0780", Offset = "0x11EF980", Length = "0xD0")]
	[CalledBy(Type = typeof(BasicGcmExponentiator), Member = "ExponentiateX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tables4kGcmMultiplier), Member = "MultiplyH", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "AsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "AsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicGcmMultiplier), Member = "MultiplyH", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GcmBlockCipher), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Nat576), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat448), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat320), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat256), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat192), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Nat128), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Sha384Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha512Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3C")]
	internal static void UInt64_To_BE(ulong n, Byte[] bs, int off) { }

	[Address(RVA = "0x11F0620", Offset = "0x11EF820", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B3B")]
	internal static void UInt64_To_BE(ulong n, Byte[] bs) { }

	[Address(RVA = "0x11F06B0", Offset = "0x11EF8B0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B3A")]
	internal static Byte[] UInt64_To_BE(ulong n) { }

	[Address(RVA = "0x11F04F0", Offset = "0x11EF6F0", Length = "0x120")]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3D")]
	internal static void UInt64_To_BE(UInt64[] ns, Byte[] bs, int off) { }

	[Address(RVA = "0x11F0860", Offset = "0x11EFA60", Length = "0x81")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B49")]
	internal static void UInt64_To_LE(ulong n, Byte[] bs) { }

	[Address(RVA = "0x11F0A30", Offset = "0x11EFC30", Length = "0xD0")]
	[CalledBy(Type = typeof(Blake2bDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TigerDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B4A")]
	internal static void UInt64_To_LE(ulong n, Byte[] bs, int off) { }

	[Address(RVA = "0x11F08F0", Offset = "0x11EFAF0", Length = "0x13F")]
	[CalledBy(Type = typeof(Blake2bDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(KeccakDigest), Member = "KeccakExtract", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B4B")]
	internal static void UInt64_To_LE(UInt64[] ns, int nsOff, int nsLen, Byte[] bs, int bsOff) { }

}

