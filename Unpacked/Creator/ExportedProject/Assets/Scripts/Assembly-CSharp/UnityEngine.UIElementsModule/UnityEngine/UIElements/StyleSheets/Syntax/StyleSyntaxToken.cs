namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x2000619")]
internal struct StyleSyntaxToken
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40016DD")]
	public StyleSyntaxTokenType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40016DE")]
	public string text; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016DF")]
	public int number; //Field offset: 0x10

	[Address(RVA = "0x1BCC000", Offset = "0x1BCB200", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AD2")]
	public StyleSyntaxToken(StyleSyntaxTokenType t) { }

	[Address(RVA = "0x1BCC030", Offset = "0x1BCB230", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AD3")]
	public StyleSyntaxToken(StyleSyntaxTokenType type, string text) { }

	[Address(RVA = "0x1BCC060", Offset = "0x1BCB260", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002AD4")]
	public StyleSyntaxToken(StyleSyntaxTokenType type, int number) { }

}

