namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200017B")]
public sealed class Blake3Digest : IDigest, IMemoable, IXof
{
	[Token(Token = "0x4000332")]
	private static readonly Byte[] SIGMA; //Field offset: 0x0
	[Token(Token = "0x4000333")]
	private static readonly UInt32[] IV; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000334")]
	private readonly Byte[] m_theBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000335")]
	private readonly UInt32[] m_theK; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000336")]
	private readonly UInt32[] m_theChaining; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000337")]
	private readonly UInt32[] m_theV; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000338")]
	private readonly UInt32[] m_theM; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000339")]
	private readonly Byte[] m_theIndices; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400033A")]
	private readonly List<UInt32[]> m_theStack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400033B")]
	private readonly int m_theDigestLen; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400033C")]
	private bool m_outputting; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400033D")]
	private long m_outputAvailable; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400033E")]
	private int m_theMode; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400033F")]
	private int m_theOutputMode; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000340")]
	private int m_theOutputDataLen; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000341")]
	private long m_theCounter; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000342")]
	private int m_theCurrBytes; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000343")]
	private int m_thePos; //Field offset: 0x74

	[Address(RVA = "0x11FC290", Offset = "0x11FB490", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D72")]
	private static Blake3Digest() { }

	[Address(RVA = "0x11FC390", Offset = "0x11FB590", Length = "0x17C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D51")]
	public Blake3Digest(int pDigestSize) { }

	[Address(RVA = "0x11FC510", Offset = "0x11FB710", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Blake3Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D52")]
	public Blake3Digest(Blake3Digest pSource) { }

	[Address(RVA = "0x11F9C90", Offset = "0x11F8E90", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D65")]
	private void AdjustChaining() { }

	[Address(RVA = "0x11F9DA0", Offset = "0x11F8FA0", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitParentBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "CopyOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D60")]
	private void AdjustStack() { }

	[Address(RVA = "0x11F9F20", Offset = "0x11F9120", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000D57")]
	public override void BlockUpdate(Byte[] pMessage, int pOffset, int pLen) { }

	[Address(RVA = "0x11FA3F0", Offset = "0x11F95F0", Length = "0x39F")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "NextOutputBlock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "AdjustStack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "ProcessStack", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "PerformRound", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1811F67C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000D63")]
	private void Compress() { }

	[Address(RVA = "0x11FA0C0", Offset = "0x11F92C0", Length = "0x1BC")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitChunkBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitParentBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "CopyOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D5E")]
	private void CompressBlock(Byte[] pMessage, int pMsgPos) { }

	[Address(RVA = "0x11FA280", Offset = "0x11F9480", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blake3Digest), Member = "InitChunkBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitParentBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "SetRoot", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D61")]
	private void CompressFinalBlock(int pDataLen) { }

	[Address(RVA = "0x11FA790", Offset = "0x11F9990", Length = "0x1AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Blake3Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D5D")]
	public override IMemoable Copy() { }

	[Address(RVA = "0x11FA940", Offset = "0x11F9B40", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D58")]
	public override int DoFinal(Byte[] pOutput, int pOutOffset) { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D53")]
	public override int GetByteLength() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D54")]
	public override int GetDigestSize() { }

	[Address(RVA = "0x11FA9D0", Offset = "0x11F9BD0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D6F")]
	private void IncrementBlockCount() { }

	[Address(RVA = "0x11FAE00", Offset = "0x11FA000", Length = "0x4A8")]
	[CalledBy(Type = typeof(Blake3Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Blake3Digest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Arrays), Member = "CopyOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitParentBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitChunkBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitNullKey", ReturnType = typeof(void))]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Blake3Parameters), Member = "GetContext", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Blake3Parameters), Member = "GetKey", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D55")]
	public void Init(Blake3Parameters pParams) { }

	[Address(RVA = "0x11FA9E0", Offset = "0x11F9BE0", Length = "0x1A5")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Blake3Digest), Member = "SetRoot", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D6C")]
	private void InitChunkBlock(int pDataLen, bool pFinal) { }

	[Address(RVA = "0x11FAB90", Offset = "0x11F9D90", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D67")]
	private void InitIndices() { }

	[Address(RVA = "0x11FAC30", Offset = "0x11F9E30", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D6A")]
	private void InitKey(Byte[] pKey) { }

	[Address(RVA = "0x11FABF0", Offset = "0x11F9DF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D6B")]
	private void InitKeyFromContext() { }

	[Address(RVA = "0x11FAC60", Offset = "0x11F9E60", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D5F")]
	private void InitM(Byte[] pMessage, int pMsgPos) { }

	[Address(RVA = "0x11FAC80", Offset = "0x11F9E80", Length = "0x71")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D69")]
	private void InitNullKey() { }

	[Address(RVA = "0x11FAD00", Offset = "0x11F9F00", Length = "0xF6")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "AdjustStack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "ProcessStack", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D6D")]
	private void InitParentBlock() { }

	[Address(RVA = "0x11FB2B0", Offset = "0x11FA4B0", Length = "0x2B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000D66")]
	private void MixG(int msgIdx, int posA, int posB, int posC, int posD) { }

	[Address(RVA = "0x11FB570", Offset = "0x11FA770", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D6E")]
	private void NextOutputBlock() { }

	[Address(RVA = "0x11FB700", Offset = "0x11FA900", Length = "0x410")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "OutputFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Blake3Digest), Member = "SetRoot", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitParentBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitChunkBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Check), Member = "OutputLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D5A")]
	public override int Output(Byte[] pOut, int pOutOffset, int pOutLen) { }

	[Address(RVA = "0x11FB680", Offset = "0x11FA880", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D59")]
	public override int OutputFinal(Byte[] pOut, int pOutOffset, int pOutLen) { }

	[Address(RVA = "0x11F6A80", Offset = "0x11F5C80", Length = "0x175")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1811F67C0")]
	[Token(Token = "0x6000D64")]
	private void PerformRound() { }

	[Address(RVA = "0x11FBB20", Offset = "0x11FAD20", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D68")]
	private void PermuteIndices() { }

	[Address(RVA = "0x11FBC00", Offset = "0x11FAE00", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "InitParentBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "SetRoot", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = "Compress", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D62")]
	private void ProcessStack() { }

	[Address(RVA = "0x11FBD50", Offset = "0x11FAF50", Length = "0x33C")]
	[CalledBy(Type = typeof(Blake3Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D5C")]
	public override void Reset(IMemoable pSource) { }

	[Address(RVA = "0x11FC090", Offset = "0x11FB290", Length = "0x5C")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Blake3Parameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D5B")]
	public override void Reset() { }

	[Address(RVA = "0x11FBD40", Offset = "0x11FAF40", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D70")]
	private void ResetBlockCount() { }

	[Address(RVA = "0x11FC0F0", Offset = "0x11FB2F0", Length = "0x82")]
	[CalledBy(Type = typeof(Blake3Digest), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "CompressFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "ProcessStack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Blake3Digest), Member = "InitChunkBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D71")]
	private void SetRoot() { }

	[Address(RVA = "0x11FC180", Offset = "0x11FB380", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Blake3Digest), Member = "CompressBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D56")]
	public override void Update(byte b) { }

}

