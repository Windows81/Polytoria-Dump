namespace System.Reflection;

[Token(Token = "0x200050D")]
internal struct MonoMethodInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001477")]
	private Type parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001478")]
	private Type ret; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001479")]
	internal MethodAttributes attrs; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400147A")]
	internal MethodImplAttributes iattrs; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400147B")]
	private CallingConventions callconv; //Field offset: 0x18

	[Address(RVA = "0x13E4570", Offset = "0x13E3770", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FCB00")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023D6")]
	private static int get_method_attributes(IntPtr handle) { }

	[Address(RVA = "0x13E4770", Offset = "0x13E3970", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023D5")]
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	[Address(RVA = "0x13E4640", Offset = "0x13E3840", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023DD")]
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	[Address(RVA = "0x1353C50", Offset = "0x1352E50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023DF")]
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	[Address(RVA = "0x13E4570", Offset = "0x13E3770", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FCB00")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023DA")]
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	[Address(RVA = "0x13E4580", Offset = "0x13E3780", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023DB")]
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	[Address(RVA = "0x13E45B0", Offset = "0x13E37B0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023D8")]
	internal static Type GetDeclaringType(IntPtr handle) { }

	[Address(RVA = "0x13E45E0", Offset = "0x13E37E0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023DC")]
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	[Address(RVA = "0x13E4610", Offset = "0x13E3810", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023D7")]
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	[Address(RVA = "0x13E4640", Offset = "0x13E3840", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023DE")]
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	[Address(RVA = "0x13E4650", Offset = "0x13E3850", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023E0")]
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }

	[Address(RVA = "0x13E4740", Offset = "0x13E3940", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023D9")]
	internal static Type GetReturnType(IntPtr handle) { }

}

