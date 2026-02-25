namespace System.Runtime.InteropServices;

[IsReadOnly]
[Token(Token = "0x2000430")]
public struct OSPlatform : IEquatable<OSPlatform>
{
	[CompilerGenerated]
	[Token(Token = "0x4001190")]
	private static readonly OSPlatform <Linux>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4001191")]
	private static readonly OSPlatform <OSX>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4001192")]
	private static readonly OSPlatform <Windows>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400118F")]
	private readonly string _osPlatform; //Field offset: 0x0

	[Token(Token = "0x170003E7")]
	public static OSPlatform Linux
	{
		[Address(RVA = "0x13BFBD0", Offset = "0x13BEDD0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6001F5A")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170003E8")]
	public static OSPlatform OSX
	{
		[Address(RVA = "0x13BFC20", Offset = "0x13BEE20", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6001F5B")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170003E9")]
	public static OSPlatform Windows
	{
		[Address(RVA = "0x13BFC70", Offset = "0x13BEE70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6001F5C")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x13BF7B0", Offset = "0x13BE9B0", Length = "0x34E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F65")]
	private static OSPlatform() { }

	[Address(RVA = "0x13BFB00", Offset = "0x13BED00", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F5D")]
	private OSPlatform(string osPlatform) { }

	[Address(RVA = "0x13BF530", Offset = "0x13BE730", Length = "0xDB")]
	[CalledBy(Type = typeof(RuntimeInformation), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F5E")]
	public static OSPlatform Create(string osPlatform) { }

	[Address(RVA = "0x13BF610", Offset = "0x13BE810", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001F5F")]
	public override bool Equals(OSPlatform other) { }

	[Address(RVA = "0x13BF750", Offset = "0x13BE950", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001F60")]
	internal bool Equals(string other) { }

	[Address(RVA = "0x13BF670", Offset = "0x13BE870", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001F61")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x13BFBD0", Offset = "0x13BEDD0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6001F5A")]
	public static OSPlatform get_Linux() { }

	[Address(RVA = "0x13BFC20", Offset = "0x13BEE20", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6001F5B")]
	public static OSPlatform get_OSX() { }

	[Address(RVA = "0x13BFC70", Offset = "0x13BEE70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6001F5C")]
	public static OSPlatform get_Windows() { }

	[Address(RVA = "0x13BF770", Offset = "0x13BE970", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F62")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13BFCC0", Offset = "0x13BEEC0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001F64")]
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	[Address(RVA = "0x13BF790", Offset = "0x13BE990", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001F63")]
	public virtual string ToString() { }

}

