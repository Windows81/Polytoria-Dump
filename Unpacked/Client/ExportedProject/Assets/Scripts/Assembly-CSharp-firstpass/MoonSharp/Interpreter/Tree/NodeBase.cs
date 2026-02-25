namespace MoonSharp.Interpreter.Tree;

[Token(Token = "0x2000088")]
internal abstract class NodeBase
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D5")]
	private Script <Script>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D6")]
	private ScriptLoadingContext <LoadingContext>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000F3")]
	protected private ScriptLoadingContext LoadingContext
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600070B")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600070C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000F2")]
	public private Script Script
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000709")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600070A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x31C350", Offset = "0x31B550", Length = "0x3C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600070D")]
	public NodeBase(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x326DF0", Offset = "0x325FF0", Length = "0x20A")]
	[CalledBy(Type = typeof(Expression), Member = "PrimaryExp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "PrefixExp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(FunctionCallExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Expression), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "BuildParamList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(Token), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000714")]
	protected static Token CheckMatch(ScriptLoadingContext lcontext, Token originalToken, TokenType expectedTokenType, string expectedTokenText) { }

	[Address(RVA = "0x327040", Offset = "0x326240", Length = "0x69")]
	[CalledBy(Type = typeof(Expression), Member = "PrimaryExp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Token(Token = "0x6000710")]
	protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType) { }

	[Address(RVA = "0x327150", Offset = "0x326350", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Token(Token = "0x6000711")]
	protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2) { }

	[Address(RVA = "0x3270B0", Offset = "0x3262B0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Token(Token = "0x6000712")]
	protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2, TokenType tokenType3) { }

	[Address(RVA = "0x327000", Offset = "0x326200", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000713")]
	protected static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType) { }

	[Token(Token = "0x600070E")]
	public abstract void Compile(ByteCode bc) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600070B")]
	protected ScriptLoadingContext get_LoadingContext() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000709")]
	public Script get_Script() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600070C")]
	private void set_LoadingContext(ScriptLoadingContext value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600070A")]
	private void set_Script(Script value) { }

	[Address(RVA = "0x3271D0", Offset = "0x3263D0", Length = "0xDF")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600070F")]
	protected static Token UnexpectedTokenType(Token t) { }

}

