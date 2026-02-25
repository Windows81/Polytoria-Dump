namespace System.Net;

[Token(Token = "0x2000231")]
internal static class ValidationHelper
{
	[Token(Token = "0x4000904")]
	public static String[] EmptyArray; //Field offset: 0x0
	[Token(Token = "0x4000905")]
	internal static readonly Char[] InvalidMethodChars; //Field offset: 0x8
	[Token(Token = "0x4000906")]
	internal static readonly Char[] InvalidParamChars; //Field offset: 0x10

	[Address(RVA = "0x17E31E0", Offset = "0x17E23E0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000E14")]
	private static ValidationHelper() { }

	[Address(RVA = "0x17E31C0", Offset = "0x17E23C0", Length = "0x10")]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E12")]
	public static bool IsBlankString(string stringValue) { }

	[Address(RVA = "0x17E31D0", Offset = "0x17E23D0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E11")]
	public static string MakeStringNull(string stringValue) { }

	[Address(RVA = "0x17CC030", Offset = "0x17CB230", Length = "0x11")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E13")]
	public static bool ValidateTcpPort(int port) { }

}

