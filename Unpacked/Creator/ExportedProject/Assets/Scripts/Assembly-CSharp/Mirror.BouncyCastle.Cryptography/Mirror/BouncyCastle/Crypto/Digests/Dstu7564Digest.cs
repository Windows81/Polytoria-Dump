namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200017C")]
public class Dstu7564Digest : IDigest, IMemoable
{
	[Token(Token = "0x400034E")]
	private static readonly Byte[] S0; //Field offset: 0x0
	[Token(Token = "0x400034F")]
	private static readonly Byte[] S1; //Field offset: 0x8
	[Token(Token = "0x4000350")]
	private static readonly Byte[] S2; //Field offset: 0x10
	[Token(Token = "0x4000351")]
	private static readonly Byte[] S3; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000344")]
	private int hashSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000345")]
	private int blockSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000346")]
	private int columns; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000347")]
	private int rounds; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000348")]
	private UInt64[] state; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000349")]
	private UInt64[] tempState1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400034A")]
	private UInt64[] tempState2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400034B")]
	private ulong inputBlocks; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400034C")]
	private int bufOff; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400034D")]
	private Byte[] buf; //Field offset: 0x48

	[Address(RVA = "0x11FDF20", Offset = "0x11FD120", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D86")]
	private static Dstu7564Digest() { }

	[Address(RVA = "0x11FE0D0", Offset = "0x11FD2D0", Length = "0x18C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D75")]
	public Dstu7564Digest(int hashSizeBits) { }

	[Address(RVA = "0x11FE260", Offset = "0x11FD460", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dstu7564Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dstu7564Digest)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D73")]
	public Dstu7564Digest(Dstu7564Digest digest) { }

	[Address(RVA = "0x11FC6A0", Offset = "0x11FB8A0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000D79")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Address(RVA = "0x11FC910", Offset = "0x11FBB10", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dstu7564Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dstu7564Digest)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D84")]
	public override IMemoable Copy() { }

	[Address(RVA = "0x11FC7B0", Offset = "0x11FB9B0", Length = "0x15E")]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dstu7564Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D74")]
	private void CopyIn(Dstu7564Digest digest) { }

	[Address(RVA = "0x11FC970", Offset = "0x11FBB70", Length = "0x2CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "ShiftRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "SubBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "MixColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000D7A")]
	public override int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D77")]
	public override int GetByteLength() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D76")]
	public override int GetDigestSize() { }

	[Address(RVA = "0x11FCC40", Offset = "0x11FBE40", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000D7F")]
	private static ulong MixColumn(ulong c) { }

	[Address(RVA = "0x11FCD80", Offset = "0x11FBF80", Length = "0x1E0")]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "P", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D80")]
	private void MixColumns(UInt64[] s) { }

	[Address(RVA = "0x11FCF70", Offset = "0x11FC170", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dstu7564Digest), Member = "ShiftRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "SubBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "MixColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7D")]
	private void P(UInt64[] s) { }

	[Address(RVA = "0x11FD020", Offset = "0x11FC220", Length = "0x22E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "ShiftRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "SubBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "MixColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7C")]
	protected override void ProcessBlock(Byte[] input, int inOff) { }

	[Address(RVA = "0x11FD250", Offset = "0x11FC450", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dstu7564Digest), Member = "ShiftRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "SubBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = "MixColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7E")]
	private void Q(UInt64[] s) { }

	[Address(RVA = "0x11FD330", Offset = "0x11FC530", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D7B")]
	public override void Reset() { }

	[Address(RVA = "0x11FD390", Offset = "0x11FC590", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dstu7564Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dstu7564Digest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000D85")]
	public override void Reset(IMemoable other) { }

	[Address(RVA = "0x11FD410", Offset = "0x11FC610", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D81")]
	private static ulong Rotate(int n, ulong x) { }

	[Address(RVA = "0x11FD430", Offset = "0x11FC630", Length = "0x7E2")]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "P", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D82")]
	private void ShiftRows(UInt64[] s) { }

	[Address(RVA = "0x11FDC20", Offset = "0x11FCE20", Length = "0x283")]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "P", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dstu7564Digest), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D83")]
	private void SubBytes(UInt64[] s) { }

	[Address(RVA = "0x11FDEB0", Offset = "0x11FD0B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D78")]
	public override void Update(byte input) { }

}

