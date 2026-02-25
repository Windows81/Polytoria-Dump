namespace Unity.Properties.Internal;

[Token(Token = "0x20000A5")]
internal static class ReflectionUtilities
{

	[Address(RVA = "0x1A14000", Offset = "0x1A13200", Length = "0xF6")]
	[CalledBy(Type = typeof(FieldMember), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMember), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000347")]
	public static string SanitizeMemberName(MemberInfo info) { }

}

