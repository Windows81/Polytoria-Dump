namespace System.Net;

[Token(Token = "0x2000202")]
internal static class HttpValidationHelpers
{
	[Token(Token = "0x4000799")]
	private static readonly Char[] s_httpTrimCharacters; //Field offset: 0x0

	[Address(RVA = "0x17C12B0", Offset = "0x17C04B0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000CCB")]
	private static HttpValidationHelpers() { }

	[Address(RVA = "0x17C1160", Offset = "0x17C0360", Length = "0x108")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000CCA")]
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

}

