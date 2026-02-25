namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000306")]
public class SHA1Managed : SHA1
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D17")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D18")]
	private long _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D19")]
	private UInt32[] _stateSHA1; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D1A")]
	private UInt32[] _expandedBuffer; //Field offset: 0x40

	[Address(RVA = "0x1341A70", Offset = "0x1340C70", Length = "0x1AC")]
	[CalledBy(Type = typeof(SHA1Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "DWORDToBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001863")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1341C20", Offset = "0x1340E20", Length = "0x195")]
	[CalledBy(Type = typeof(SHA1Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001862")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1341DC0", Offset = "0x1340FC0", Length = "0x13F")]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600185D")]
	public SHA1Managed() { }

	[Address(RVA = "0x1341430", Offset = "0x1340630", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600185F")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1341440", Offset = "0x1340640", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6001860")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1341450", Offset = "0x1340650", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600185E")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1339130", Offset = "0x1338330", Length = "0x8A")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001861")]
	private void InitializeState() { }

	[Address(RVA = "0x13414B0", Offset = "0x13406B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001865")]
	private static void SHAExpand(UInt32* x) { }

	[Address(RVA = "0x13414F0", Offset = "0x13406F0", Length = "0x575")]
	[CalledBy(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DWORDFromBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(Byte*)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001864")]
	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

}

