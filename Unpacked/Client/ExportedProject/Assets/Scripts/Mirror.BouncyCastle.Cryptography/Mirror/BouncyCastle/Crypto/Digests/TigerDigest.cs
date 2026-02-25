namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000195")]
public class TigerDigest : IDigest, IMemoable
{
	[Token(Token = "0x40003FE")]
	private static readonly Int64[] t1; //Field offset: 0x0
	[Token(Token = "0x40003FF")]
	private static readonly Int64[] t2; //Field offset: 0x8
	[Token(Token = "0x4000400")]
	private static readonly Int64[] t3; //Field offset: 0x10
	[Token(Token = "0x4000401")]
	private static readonly Int64[] t4; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000402")]
	private long a; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000403")]
	private long b; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000404")]
	private long c; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000405")]
	private long byteCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000406")]
	private Byte[] m_buffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000407")]
	private int bOff; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000408")]
	private Int64[] x; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000409")]
	private int xOff; //Field offset: 0x48

	[Address(RVA = "0x10F8620", Offset = "0x10F7820", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000EF3")]
	private static TigerDigest() { }

	[Address(RVA = "0x10F87D0", Offset = "0x10F79D0", Length = "0x8C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TigerDigest), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EE1")]
	public TigerDigest() { }

	[Address(RVA = "0x10F8860", Offset = "0x10F7A60", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EE2")]
	public TigerDigest(TigerDigest t) { }

	[Address(RVA = "0x10F7020", Offset = "0x10F6220", Length = "0x1C2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EE7")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Address(RVA = "0x10F71F0", Offset = "0x10F63F0", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EF1")]
	public override IMemoable Copy() { }

	[Address(RVA = "0x10F73A0", Offset = "0x10F65A0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EEF")]
	public override int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10F7500", Offset = "0x10F6700", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EEE")]
	private void Finish() { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE4")]
	public override int GetByteLength() { }

	[Address(RVA = "0x3CE1D0", Offset = "0x3CD3D0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EE3")]
	public override int GetDigestSize() { }

	[Address(RVA = "0x10F75F0", Offset = "0x10F67F0", Length = "0x290")]
	[CalledBy(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EEB")]
	private void KeySchedule() { }

	[Address(RVA = "0x10F7890", Offset = "0x10F6A90", Length = "0x4CD")]
	[CalledBy(Type = typeof(TigerDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TigerDigest), Member = "RoundABC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = "RoundBCA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = "RoundCAB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = "KeySchedule", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EEC")]
	private void ProcessBlock() { }

	[Address(RVA = "0x10F7D60", Offset = "0x10F6F60", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EED")]
	private void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10F7D90", Offset = "0x10F6F90", Length = "0x80")]
	[CalledBy(Type = typeof(TigerDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EE5")]
	private void ProcessWord(Byte[] b, int off) { }

	[Address(RVA = "0x10F7F30", Offset = "0x10F7130", Length = "0xD2")]
	[CalledBy(Type = typeof(TigerDigest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TigerDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EF0")]
	public override void Reset() { }

	[Address(RVA = "0x10F7E20", Offset = "0x10F7020", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000EF2")]
	public override void Reset(IMemoable other) { }

	[Address(RVA = "0x10F8010", Offset = "0x10F7210", Length = "0x1DC")]
	[CalledBy(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EE8")]
	private void RoundABC(long x, long mul) { }

	[Address(RVA = "0x10F81F0", Offset = "0x10F73F0", Length = "0x1DC")]
	[CalledBy(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EE9")]
	private void RoundBCA(long x, long mul) { }

	[Address(RVA = "0x10F83D0", Offset = "0x10F75D0", Length = "0x1DC")]
	[CalledBy(Type = typeof(TigerDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EEA")]
	private void RoundCAB(long x, long mul) { }

	[Address(RVA = "0x10F85B0", Offset = "0x10F77B0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TigerDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EE6")]
	public override void Update(byte input) { }

}

