namespace System.Web.Util;

[Token(Token = "0x20000D8")]
internal class Helpers
{
	[Token(Token = "0x4000345")]
	public static readonly CultureInfo InvariantCulture; //Field offset: 0x0

	[Address(RVA = "0x1751200", Offset = "0x1750400", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000462")]
	private static Helpers() { }

}

