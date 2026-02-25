namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000196")]
public sealed class WhirlpoolDigest : IDigest, IMemoable
{
	[Token(Token = "0x400040A")]
	private static readonly Int32[] SBOX; //Field offset: 0x0
	[Token(Token = "0x400040B")]
	private static readonly UInt64[] C0; //Field offset: 0x8
	[Token(Token = "0x400040C")]
	private static readonly UInt64[] C1; //Field offset: 0x10
	[Token(Token = "0x400040D")]
	private static readonly UInt64[] C2; //Field offset: 0x18
	[Token(Token = "0x400040E")]
	private static readonly UInt64[] C3; //Field offset: 0x20
	[Token(Token = "0x400040F")]
	private static readonly UInt64[] C4; //Field offset: 0x28
	[Token(Token = "0x4000410")]
	private static readonly UInt64[] C5; //Field offset: 0x30
	[Token(Token = "0x4000411")]
	private static readonly UInt64[] C6; //Field offset: 0x38
	[Token(Token = "0x4000412")]
	private static readonly UInt64[] C7; //Field offset: 0x40
	[Token(Token = "0x4000413")]
	private static readonly Int16[] EIGHT; //Field offset: 0x48
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000414")]
	private readonly UInt64[] _rc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000415")]
	private Byte[] _buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000416")]
	private int _bufferPos; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000417")]
	private Int16[] _bitCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000418")]
	private UInt64[] _hash; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000419")]
	private UInt64[] _K; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400041A")]
	private UInt64[] _L; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400041B")]
	private UInt64[] _block; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400041C")]
	private UInt64[] _state; //Field offset: 0x50

	[Address(RVA = "0x10FA0F0", Offset = "0x10F92F0", Length = "0x70B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EF4")]
	private static WhirlpoolDigest() { }

	[Address(RVA = "0x10FA800", Offset = "0x10F9A00", Length = "0x3CE")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EF7")]
	public WhirlpoolDigest() { }

	[Address(RVA = "0x10FABD0", Offset = "0x10F9DD0", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EF8")]
	public WhirlpoolDigest(WhirlpoolDigest originalDigest) { }

	[Address(RVA = "0x10F89E0", Offset = "0x10F7BE0", Length = "0x206")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F00")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Address(RVA = "0x10F8C90", Offset = "0x10F7E90", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F04")]
	public override IMemoable Copy() { }

	[Address(RVA = "0x10F8BF0", Offset = "0x10F7DF0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F02")]
	private Byte[] CopyBitLength() { }

	[Address(RVA = "0x10F8E30", Offset = "0x10F8030", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFA")]
	public override int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10F8F50", Offset = "0x10F8150", Length = "0x1AD")]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F01")]
	private void Finish() { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F03")]
	public override int GetByteLength() { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF9")]
	public override int GetDigestSize() { }

	[Address(RVA = "0x10F9100", Offset = "0x10F8300", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EFF")]
	private void Increment() { }

	[Address(RVA = "0x10F9230", Offset = "0x10F8430", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EF5")]
	private static int MulX(int input) { }

	[Address(RVA = "0x10F9250", Offset = "0x10F8450", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EF6")]
	private static ulong PackIntoUInt64(int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0) { }

	[Address(RVA = "0x10F92B0", Offset = "0x10F84B0", Length = "0x967")]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "ProcessFilledBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "Finish", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EFD")]
	private void ProcessBlock() { }

	[Address(RVA = "0x10F9C20", Offset = "0x10F8E20", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFC")]
	private void ProcessFilledBuffer() { }

	[Address(RVA = "0x10F9C80", Offset = "0x10F8E80", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFB")]
	public override void Reset() { }

	[Address(RVA = "0x10F9D70", Offset = "0x10F8F70", Length = "0x1D3")]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhirlpoolDigest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000F05")]
	public override void Reset(IMemoable other) { }

	[Address(RVA = "0x10F9F50", Offset = "0x10F9150", Length = "0x194")]
	[CalledBy(Type = typeof(WhirlpoolDigest), Member = "Finish", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WhirlpoolDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EFE")]
	public override void Update(byte input) { }

}

