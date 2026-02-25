namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001DC")]
[VisibleToOtherModules]
internal struct OutStringMarshaller
{

	[Address(RVA = "0x1985A40", Offset = "0x1984C40", Length = "0x86")]
	[CallerCount(Count = 69)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C88")]
	public static string GetStringAndDispose(ManagedSpanWrapper managedSpan) { }

}

