namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000301")]
public class RIPEMD160Managed : RIPEMD160
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D04")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D05")]
	private long _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D06")]
	private UInt32[] _stateMD160; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D07")]
	private UInt32[] _blockDWords; //Field offset: 0x40

	[Address(RVA = "0x133B2D0", Offset = "0x133A4D0", Length = "0x1AC")]
	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RIPEMD160Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "DWORDToLittleEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600183C")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x133B480", Offset = "0x133A680", Length = "0x195")]
	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RIPEMD160Managed), Member = "MDTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600183B")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x133B620", Offset = "0x133A820", Length = "0x13F")]
	[CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RIPEMD160), Member = "Create", ReturnType = typeof(RIPEMD160))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001836")]
	public RIPEMD160Managed() { }

	[Address(RVA = "0x10D6B30", Offset = "0x10D5D30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600183E")]
	private static uint F(uint x, uint y, uint z) { }

	[Address(RVA = "0x10D6B10", Offset = "0x10D5D10", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600183F")]
	private static uint G(uint x, uint y, uint z) { }

	[Address(RVA = "0x1339100", Offset = "0x1338300", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001840")]
	private static uint H(uint x, uint y, uint z) { }

	[Address(RVA = "0x1339110", Offset = "0x1338310", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RIPEMD160Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001838")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1339120", Offset = "0x1338320", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RIPEMD160Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6001839")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x10D6B20", Offset = "0x10D5D20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001841")]
	private static uint I(uint x, uint y, uint z) { }

	[Address(RVA = "0x13391C0", Offset = "0x13383C0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001837")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1339130", Offset = "0x1338330", Length = "0x8A")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600183A")]
	private void InitializeState() { }

	[Address(RVA = "0x1339220", Offset = "0x1338420", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001842")]
	private static uint J(uint x, uint y, uint z) { }

	[Address(RVA = "0x1339230", Offset = "0x1338430", Length = "0x209D")]
	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DWORDFromLittleEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(Byte*)}, ReturnType = typeof(void))]
	[Token(Token = "0x600183D")]
	private static void MDTransform(UInt32* blockDWords, UInt32* state, Byte* block) { }

}

