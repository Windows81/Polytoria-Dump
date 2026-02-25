namespace Mirror.BouncyCastle.Security;

[Token(Token = "0x200001E")]
public class SecureRandom : Random
{
	[Token(Token = "0x400004B")]
	private static long counter; //Field offset: 0x0
	[Token(Token = "0x400004C")]
	private static readonly SecureRandom MasterRandom; //Field offset: 0x8
	[Token(Token = "0x400004D")]
	internal static readonly SecureRandom ArbitraryRandom; //Field offset: 0x10
	[Token(Token = "0x400004F")]
	private static readonly double DoubleScale; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	protected readonly IRandomGenerator generator; //Field offset: 0x20

	[Address(RVA = "0x10C2E70", Offset = "0x10C2070", Length = "0x259")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptoApiRandomGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VmpcRandomGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SecureRandom), Member = "AutoSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRandomGenerator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A6")]
	private static SecureRandom() { }

	[Address(RVA = "0x10C3140", Offset = "0x10C2340", Length = "0x1CF")]
	[CalledBy(Type = typeof(CryptoServicesRegistrar), Member = "GetSecureRandom", ReturnType = typeof(SecureRandom))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyGenerationParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "Generate", ReturnType = "Mirror.Transports.Encryption.EncryptionCredentials")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DigestUtilities), Member = "GetDigest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DigestRandomGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SecureRandom), Member = "AutoSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRandomGenerator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009B")]
	public SecureRandom() { }

	[Address(RVA = "0x10C30D0", Offset = "0x10C22D0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600009C")]
	public SecureRandom(IRandomGenerator generator) { }

	[Address(RVA = "0x10C3310", Offset = "0x10C2510", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecureRandom), Member = "AutoSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRandomGenerator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600009D")]
	public SecureRandom(IRandomGenerator generator, int autoSeedLengthInBytes) { }

	[Address(RVA = "0x10C2750", Offset = "0x10C1950", Length = "0x191")]
	[CalledBy(Type = typeof(SecureRandom), Member = "CreatePrng", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(DigestRandomGenerator))]
	[CalledBy(Type = typeof(SecureRandom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecureRandom), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRandomGenerator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecureRandom), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A5")]
	private static void AutoSeed(IRandomGenerator generator, int seedLength) { }

	[Address(RVA = "0x10C28F0", Offset = "0x10C1AF0", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DigestUtilities), Member = "GetDigest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DigestRandomGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SecureRandom), Member = "AutoSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRandomGenerator), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	private static DigestRandomGenerator CreatePrng(string digestName, bool autoSeed) { }

	[Address(RVA = "0x10C2E50", Offset = "0x10C2050", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600009E")]
	public virtual int Next() { }

	[Address(RVA = "0x10C2C80", Offset = "0x10C1E80", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600009F")]
	public virtual int Next(int maxValue) { }

	[Address(RVA = "0x10C2D70", Offset = "0x10C1F70", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A0")]
	public virtual int Next(int minValue, int maxValue) { }

	[Address(RVA = "0x10C2A40", Offset = "0x10C1C40", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A1")]
	public virtual void NextBytes(Byte[] buf) { }

	[Address(RVA = "0x10C2AA0", Offset = "0x10C1CA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Token(Token = "0x6000099")]
	private static long NextCounterValue() { }

	[Address(RVA = "0x10C2AF0", Offset = "0x10C1CF0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A2")]
	public virtual double NextDouble() { }

	[Address(RVA = "0x10C2BA0", Offset = "0x10C1DA0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A3")]
	public override int NextInt() { }

	[Address(RVA = "0x10C2C10", Offset = "0x10C1E10", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A4")]
	public override long NextLong() { }

}

