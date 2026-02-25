namespace System.Reflection;

[Extension]
[Token(Token = "0x20004D6")]
public static class IntrospectionExtensions
{

	[Address(RVA = "0x13BA760", Offset = "0x13B9960", Length = "0x1F4")]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "IsValidInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "FindGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6002196")]
	public static TypeInfo GetTypeInfo(Type type) { }

}

