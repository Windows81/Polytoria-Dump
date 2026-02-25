namespace System;

[Token(Token = "0x2000191")]
internal class ReflectionOnlyType : RuntimeType
{

	[Token(Token = "0x17000143")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x14FD0C0", Offset = "0x14FC2C0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E89")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x14FD070", Offset = "0x14FC270", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeType), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000E88")]
	private ReflectionOnlyType() { }

	[Address(RVA = "0x14FD0C0", Offset = "0x14FC2C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E89")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

}

