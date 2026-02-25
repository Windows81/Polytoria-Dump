namespace System.Security;

[MonoTODO("work in progress - encryption is missing")]
[Token(Token = "0x20002C2")]
public sealed class SecureString : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C12")]
	private int length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C13")]
	private bool disposed; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C14")]
	private Byte[] data; //Field offset: 0x18

	[Token(Token = "0x17000252")]
	public int Length
	{
		[Address(RVA = "0x132FBF0", Offset = "0x132EDF0", Length = "0x64")]
		[CalledBy(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60016FE")]
		 get { } //Length: 100
	}

	[Address(RVA = "0x132FB90", Offset = "0x132ED90", Length = "0x5E")]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016FC")]
	public SecureString() { }

	[Address(RVA = "0x132FA10", Offset = "0x132EC10", Length = "0x177")]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecureString), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x60016FD")]
	public SecureString(Char* value, int length) { }

	[Address(RVA = "0x132F740", Offset = "0x132E940", Length = "0x1B3")]
	[CalledBy(Type = typeof(SecureString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001702")]
	private void Alloc(int length, bool realloc) { }

	[Address(RVA = "0x40DBA0", Offset = "0x40CDA0", Length = "0x3")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001701")]
	private void Decrypt() { }

	[Address(RVA = "0x132F900", Offset = "0x132EB00", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60016FF")]
	public override void Dispose() { }

	[Address(RVA = "0x40DBA0", Offset = "0x40CDA0", Length = "0x3")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001700")]
	private void Encrypt() { }

	[Address(RVA = "0x132FBF0", Offset = "0x132EDF0", Length = "0x64")]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60016FE")]
	public int get_Length() { }

	[Address(RVA = "0x132F960", Offset = "0x132EB60", Length = "0xA3")]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001703")]
	internal Byte[] GetBuffer() { }

}

