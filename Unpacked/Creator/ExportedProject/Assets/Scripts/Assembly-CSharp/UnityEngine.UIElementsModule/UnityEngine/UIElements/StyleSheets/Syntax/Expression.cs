namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x2000611")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Expression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001698")]
	public ExpressionType type; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001699")]
	public ExpressionMultiplier multiplier; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400169A")]
	public DataType dataType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400169B")]
	public ExpressionCombinator combinator; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400169C")]
	public Expression[] subExpressions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400169D")]
	public string keyword; //Field offset: 0x30

	[Address(RVA = "0x1BBEDF0", Offset = "0x1BBDFF0", Length = "0x64")]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002ABD")]
	public Expression(ExpressionType type) { }

}

