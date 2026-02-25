namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030A")]
public class SHA384Managed : SHA384
{
	[Token(Token = "0x4000D24")]
	private static readonly UInt64[] _K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D20")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D21")]
	private ulong _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D22")]
	private UInt64[] _stateSHA384; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D23")]
	private UInt64[] _W; //Field offset: 0x40

	[Address(RVA = "0x1344660", Offset = "0x1343860", Length = "0x1AF")]
	[CalledBy(Type = typeof(SHA384Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA384Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "QuadWordToBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001881")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1344810", Offset = "0x1343A10", Length = "0x1EF")]
	[CalledBy(Type = typeof(SHA384Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA384Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001880")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1344A00", Offset = "0x1343C00", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600188B")]
	private static SHA384Managed() { }

	[Address(RVA = "0x1344A90", Offset = "0x1343C90", Length = "0x13F")]
	[CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA384), Member = "Create", ReturnType = typeof(SHA384))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SHA384Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600187B")]
	public SHA384Managed() { }

	[Address(RVA = "0x12055A0", Offset = "0x12047A0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001884")]
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x1343540", Offset = "0x1342740", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA384Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600187D")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1343550", Offset = "0x1342750", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA384Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600187E")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1343690", Offset = "0x1342890", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA384Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600187C")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1343560", Offset = "0x1342760", Length = "0x124")]
	[CalledBy(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA384Managed), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600187F")]
	private void InitializeState() { }

	[Address(RVA = "0x1205870", Offset = "0x1204A70", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001885")]
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x11F8070", Offset = "0x11F7270", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001883")]
	private static ulong RotateRight(ulong x, int n) { }

	[Address(RVA = "0x13436F0", Offset = "0x13428F0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600188A")]
	private static void SHA384Expand(UInt64* x) { }

	[Address(RVA = "0x1343850", Offset = "0x1342A50", Length = "0xD0A")]
	[CalledBy(Type = typeof(SHA384Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "QuadWordFromBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001882")]
	private static void SHATransform(UInt64* expandedBuffer, UInt64* state, Byte* block) { }

	[Address(RVA = "0x1344BD0", Offset = "0x1343DD0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001888")]
	private static ulong sigma_0(ulong x) { }

	[Address(RVA = "0x1344560", Offset = "0x1343760", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001886")]
	private static ulong Sigma_0(ulong x) { }

	[Address(RVA = "0x1344C40", Offset = "0x1343E40", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001889")]
	private static ulong sigma_1(ulong x) { }

	[Address(RVA = "0x13445E0", Offset = "0x13437E0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001887")]
	private static ulong Sigma_1(ulong x) { }

}

