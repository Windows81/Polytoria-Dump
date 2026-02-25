namespace MoonSharp.Interpreter.Tree;

[Token(Token = "0x2000084")]
internal class Token
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028B")]
	public readonly int SourceId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400028C")]
	public readonly int FromCol; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400028D")]
	public readonly int ToCol; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400028E")]
	public readonly int FromLine; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400028F")]
	public readonly int ToLine; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000290")]
	public readonly int PrevCol; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000291")]
	public readonly int PrevLine; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000292")]
	public readonly TokenType Type; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000293")]
	private string <Text>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170000F1")]
	public string Text
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006F7")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006F8")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x32E1A0", Offset = "0x32D3A0", Length = "0x67")]
	[CalledBy(Type = typeof(Lexer), Member = "CreateToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F9")]
	public Token(TokenType type, int sourceId, int fromLine, int fromCol, int toLine, int toCol, int prevLine, int prevCol) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F7")]
	public string get_Text() { }

	[Address(RVA = "0x32D100", Offset = "0x32C300", Length = "0x19F")]
	[CalledBy(Type = typeof(LiteralExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTableConverter), Member = "ParseJsonNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(Script)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LexerUtils), Member = "ParseHexInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(LexerUtils), Member = "ParseHexFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x60006FC")]
	public double GetNumberValue() { }

	[Address(RVA = "0x32D2A0", Offset = "0x32C4A0", Length = "0x84E")]
	[CalledBy(Type = typeof(Lexer), Member = "ReadToken", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(Lexer), Member = "CreateNameToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[Token(Token = "0x60006FB")]
	public static Nullable<TokenType> GetReservedTokenType(string reservedWord) { }

	[Address(RVA = "0x32DC70", Offset = "0x32CE70", Length = "0xAA")]
	[CalledBy(Type = typeof(LabelStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyntaxErrorException), Member = "DecorateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CalledBy(Type = typeof(BreakStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForEachLoopStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForLoopStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IfStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IfStatement), Member = "CreateElseBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = "MoonSharp.Interpreter.Tree.Statements.IfStatement+IfBlock")]
	[CalledBy(Type = typeof(RepeatStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReturnStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScopeBlockStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhileStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "CreateBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000700")]
	internal SourceRef GetSourceRef(bool isStepStop = true) { }

	[Address(RVA = "0x32DBB0", Offset = "0x32CDB0", Length = "0xB7")]
	[CalledBy(Type = typeof(FunctionDefinitionStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionCallExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Expression), typeof(Token)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000701")]
	internal SourceRef GetSourceRef(Token to, bool isStepStop = true) { }

	[Address(RVA = "0x32DAF0", Offset = "0x32CCF0", Length = "0xB7")]
	[CalledBy(Type = typeof(ReturnStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionCallExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Expression), typeof(Token)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000702")]
	internal SourceRef GetSourceRefUpTo(Token to, bool isStepStop = true) { }

	[Address(RVA = "0x32DD20", Offset = "0x32CF20", Length = "0x3C")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006FF")]
	public bool IsBinaryOperator() { }

	[Address(RVA = "0x32DDA0", Offset = "0x32CFA0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006FD")]
	public bool IsEndOfBlock() { }

	[Address(RVA = "0x32DDC0", Offset = "0x32CFC0", Length = "0x17")]
	[CalledBy(Type = typeof(Expression), Member = "SubExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006FE")]
	public bool IsUnaryOperator() { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F8")]
	public void set_Text(string value) { }

	[Address(RVA = "0x32DDE0", Offset = "0x32CFE0", Length = "0x3B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60006FA")]
	public virtual string ToString() { }

}

