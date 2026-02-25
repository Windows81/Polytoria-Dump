namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030C")]
public class SHA512Managed : SHA512
{
	[Token(Token = "0x4000D29")]
	private static readonly UInt64[] _K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D25")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D26")]
	private ulong _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D27")]
	private UInt64[] _stateSHA512; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D28")]
	private UInt64[] _W; //Field offset: 0x40

	[Address(RVA = "0x13508E0", Offset = "0x134FAE0", Length = "0x2C3")]
	[CalledBy(Type = typeof(SHA512Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001894")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1350BB0", Offset = "0x134FDB0", Length = "0x1EF")]
	[CalledBy(Type = typeof(SHA512Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001893")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1350DA0", Offset = "0x134FFA0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600189E")]
	private static SHA512Managed() { }

	[Address(RVA = "0x1350E30", Offset = "0x1350030", Length = "0xCE")]
	[CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA512), Member = "Create", ReturnType = typeof(SHA512))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SHA512), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SHA512Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Token(Token = "0x600188E")]
	public SHA512Managed() { }

	[Address(RVA = "0x12055A0", Offset = "0x12047A0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001897")]
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x134F770", Offset = "0x134E970", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001890")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x134F780", Offset = "0x134E980", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6001891")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x134F8C0", Offset = "0x134EAC0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA512Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600188F")]
	public virtual void Initialize() { }

	[Address(RVA = "0x134F790", Offset = "0x134E990", Length = "0x124")]
	[CalledBy(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA512Managed), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001892")]
	private void InitializeState() { }

	[Address(RVA = "0x1205870", Offset = "0x1204A70", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001898")]
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x11F8070", Offset = "0x11F7270", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001896")]
	private static ulong RotateRight(ulong x, int n) { }

	[Address(RVA = "0x134F920", Offset = "0x134EB20", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600189D")]
	private static void SHA512Expand(UInt64* x) { }

	[Address(RVA = "0x134FA80", Offset = "0x134EC80", Length = "0xD5A")]
	[CalledBy(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001895")]
	private static void SHATransform(UInt64* expandedBuffer, UInt64* state, Byte* block) { }

	[Address(RVA = "0x1350F00", Offset = "0x1350100", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600189B")]
	private static ulong sigma_0(ulong x) { }

	[Address(RVA = "0x13507E0", Offset = "0x134F9E0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001899")]
	private static ulong Sigma_0(ulong x) { }

	[Address(RVA = "0x1350F70", Offset = "0x1350170", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600189C")]
	private static ulong sigma_1(ulong x) { }

	[Address(RVA = "0x1350860", Offset = "0x134FA60", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600189A")]
	private static ulong Sigma_1(ulong x) { }

}

