namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000308")]
public class SHA256Managed : SHA256
{
	[Token(Token = "0x4000D1F")]
	private static readonly UInt32[] _K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D1B")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D1C")]
	private long _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D1D")]
	private UInt32[] _stateSHA256; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D1E")]
	private UInt32[] _W; //Field offset: 0x40

	[Address(RVA = "0x1342EB0", Offset = "0x13420B0", Length = "0x1AC")]
	[CalledBy(Type = typeof(SHA256Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "DWORDToBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600186E")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1343060", Offset = "0x1342260", Length = "0x1DF")]
	[CalledBy(Type = typeof(SHA256Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600186D")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1343240", Offset = "0x1342440", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001878")]
	private static SHA256Managed() { }

	[Address(RVA = "0x13432D0", Offset = "0x13424D0", Length = "0x13F")]
	[CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256), Member = "Create", ReturnType = typeof(SHA256))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SHA256Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001868")]
	public SHA256Managed() { }

	[Address(RVA = "0x10F39E0", Offset = "0x10F2BE0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001871")]
	private static uint Ch(uint x, uint y, uint z) { }

	[Address(RVA = "0x1341F50", Offset = "0x1341150", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600186A")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1341F60", Offset = "0x1341160", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600186B")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1342060", Offset = "0x1341260", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA256Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001869")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1341F70", Offset = "0x1341170", Length = "0xE4")]
	[CalledBy(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600186C")]
	private void InitializeState() { }

	[Address(RVA = "0x10F3BD0", Offset = "0x10F2DD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001872")]
	private static uint Maj(uint x, uint y, uint z) { }

	[Address(RVA = "0x10BD170", Offset = "0x10BC370", Length = "0x19")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001870")]
	private static uint RotateRight(uint x, int n) { }

	[Address(RVA = "0x13420C0", Offset = "0x13412C0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001877")]
	private static void SHA256Expand(UInt32* x) { }

	[Address(RVA = "0x1342200", Offset = "0x1341400", Length = "0xBC3")]
	[CalledBy(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "DWORDFromBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600186F")]
	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

	[Address(RVA = "0x1343410", Offset = "0x1342610", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001873")]
	private static uint sigma_0(uint x) { }

	[Address(RVA = "0x1342DD0", Offset = "0x1341FD0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001875")]
	private static uint Sigma_0(uint x) { }

	[Address(RVA = "0x1343470", Offset = "0x1342670", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001874")]
	private static uint sigma_1(uint x) { }

	[Address(RVA = "0x1342E40", Offset = "0x1342040", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001876")]
	private static uint Sigma_1(uint x) { }

}

