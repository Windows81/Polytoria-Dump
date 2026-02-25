namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000184")]
public class MD2Digest : IDigest, IMemoable
{
	[Token(Token = "0x4000392")]
	private static readonly Byte[] S; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400038C")]
	private Byte[] X; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400038D")]
	private int xOff; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400038E")]
	private Byte[] M; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400038F")]
	private int mOff; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000390")]
	private Byte[] C; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000391")]
	private int COff; //Field offset: 0x38

	[Address(RVA = "0x12070F0", Offset = "0x12062F0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E01")]
	private static MD2Digest() { }

	[Address(RVA = "0x1207180", Offset = "0x1206380", Length = "0xA1")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MD2Digest), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF4")]
	public MD2Digest() { }

	[Address(RVA = "0x1207230", Offset = "0x1206430", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MD2Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD2Digest)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF5")]
	public MD2Digest(MD2Digest t) { }

	[Address(RVA = "0x12067F0", Offset = "0x12059F0", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MD2Digest), Member = "ProcessChecksum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD2Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DFC")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Address(RVA = "0x1206A60", Offset = "0x1205C60", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MD2Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD2Digest)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DFF")]
	public override IMemoable Copy() { }

	[Address(RVA = "0x1206990", Offset = "0x1205B90", Length = "0xC0")]
	[CalledBy(Type = typeof(MD2Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD2Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD2Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(MD2Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DF6")]
	private void CopyIn(MD2Digest t) { }

	[Address(RVA = "0x1206B40", Offset = "0x1205D40", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MD2Digest), Member = "ProcessChecksum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD2Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD2Digest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DF9")]
	public override int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF8")]
	public override int GetByteLength() { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF7")]
	public override int GetDigestSize() { }

	[Address(RVA = "0x1206C30", Offset = "0x1205E30", Length = "0x1AB")]
	[CalledBy(Type = typeof(MD2Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MD2Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD2Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DFE")]
	internal void ProcessBlock(Byte[] m) { }

	[Address(RVA = "0x1206DE0", Offset = "0x1205FE0", Length = "0x124")]
	[CalledBy(Type = typeof(MD2Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MD2Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD2Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DFD")]
	internal void ProcessChecksum(Byte[] m) { }

	[Address(RVA = "0x1206F10", Offset = "0x1206110", Length = "0xED")]
	[CalledBy(Type = typeof(MD2Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD2Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DFA")]
	public override void Reset() { }

	[Address(RVA = "0x1207000", Offset = "0x1206200", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MD2Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD2Digest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E00")]
	public override void Reset(IMemoable other) { }

	[Address(RVA = "0x1207080", Offset = "0x1206280", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MD2Digest), Member = "ProcessChecksum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD2Digest), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DFB")]
	public override void Update(byte input) { }

}

