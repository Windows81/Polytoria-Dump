namespace System.Xml;

[Token(Token = "0x2000014")]
internal abstract class HtmlTernaryTree
{
	[Token(Token = "0x400003C")]
	internal static Byte[] htmlElements; //Field offset: 0x0
	[Token(Token = "0x400003D")]
	internal static Byte[] htmlAttributes; //Field offset: 0x8

	[Address(RVA = "0x162F2A0", Offset = "0x162E4A0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600004F")]
	private static HtmlTernaryTree() { }

}

