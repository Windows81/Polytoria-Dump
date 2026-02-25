namespace Mirror.BouncyCastle.Crypto.Prng;

[Token(Token = "0x200011F")]
public sealed class VmpcRandomGenerator : IRandomGenerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023F")]
	private readonly Byte[] P; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000240")]
	private byte s; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000241")]
	private byte n; //Field offset: 0x19

	[Address(RVA = "0x11F5070", Offset = "0x11F4270", Length = "0x83")]
	[CalledBy(Type = typeof(SecureRandom), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B61")]
	public VmpcRandomGenerator() { }

	[Address(RVA = "0x11F4D50", Offset = "0x11F3F50", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B62")]
	public override void AddSeedMaterial(Byte[] seed) { }

	[Address(RVA = "0x11F4BA0", Offset = "0x11F3DA0", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B63")]
	public override void AddSeedMaterial(long seed) { }

	[Address(RVA = "0x11F5040", Offset = "0x11F4240", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VmpcRandomGenerator), Member = "NextBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B64")]
	public override void NextBytes(Byte[] bytes) { }

	[Address(RVA = "0x11F4E40", Offset = "0x11F4040", Length = "0x1FA")]
	[CalledBy(Type = typeof(VmpcRandomGenerator), Member = "NextBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000B65")]
	public override void NextBytes(Byte[] bytes, int start, int len) { }

}

