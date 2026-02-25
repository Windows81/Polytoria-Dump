namespace MoonSharp.Interpreter.Tree.Expressions;

[Token(Token = "0x20000A6")]
internal class FunctionDefinitionExpression : Expression, IClosureBuilder
{
	[CompilerGenerated]
	[Token(Token = "0x20000A7")]
	private sealed class <>c
	{
		[Token(Token = "0x4000355")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000356")]
		public static Func<Int32> <>9__21_0; //Field offset: 0x8

		[Address(RVA = "0x32E840", Offset = "0x32DA40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000797")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000798")]
		public <>c() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000799")]
		internal int <Compile>b__21_0() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400034B")]
	private SymbolRef[] m_ParamNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400034C")]
	private Statement m_Statement; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400034D")]
	private RuntimeScopeFrame m_StackFrame; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400034E")]
	private List<SymbolRef> m_Closure; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400034F")]
	private bool m_HasVarArgs; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000350")]
	private Instruction m_ClosureInstruction; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000351")]
	private bool m_UsesGlobalEnv; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000352")]
	private SymbolRef m_Env; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000353")]
	private SourceRef m_Begin; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000354")]
	private SourceRef m_End; //Field offset: 0x68

	[Address(RVA = "0x3204E0", Offset = "0x31F6E0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600078B")]
	public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool usesGlobalEnv) { }

	[Address(RVA = "0x320510", Offset = "0x31F710", Length = "0x1F")]
	[CalledBy(Type = typeof(Expression), Member = "SimpleExp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600078C")]
	public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool isLambda) { }

	[Address(RVA = "0x3200D0", Offset = "0x31F2D0", Length = "0x409")]
	[CalledBy(Type = typeof(FunctionDefinitionStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "BuildParamList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(Token), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopFunction", ReturnType = typeof(RuntimeScopeFrame))]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "CreateLambdaBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Statement))]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "CreateBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Statement))]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "DefineArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(ScriptLoadingContext)}, ReturnType = typeof(SymbolRef[]))]
	[Calls(Type = typeof(BuildTimeScope), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(BuildTimeScope), Member = "ForceEnvUpValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClosureBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600078D")]
	private FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool usesGlobalEnv, bool isLambda) { }

	[Address(RVA = "0x31F030", Offset = "0x31E230", Length = "0x243")]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeBase), Member = "CheckMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Token), typeof(TokenType), typeof(string)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000790")]
	private List<String> BuildParamList(ScriptLoadingContext lcontext, bool pushSelfParam, Token openBracketToken, bool isLambda) { }

	[Address(RVA = "0x31F560", Offset = "0x31E760", Length = "0x177")]
	[CalledBy(Type = typeof(FunctionDefinitionStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteCode), Member = "EnterSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Closure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef[]), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "CompileBody", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000795")]
	public int Compile(ByteCode bc, Func<Int32> afterDecl, string friendlyName) { }

	[Address(RVA = "0x31F6E0", Offset = "0x31E8E0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode), typeof(System.Func`1<System.Int32>), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000796")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x31F280", Offset = "0x31E480", Length = "0x2DC")]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode), typeof(System.Func`1<System.Int32>), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FastStack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Ret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "PopSourceRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Args", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef[])}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolRef), Member = "Upvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_BeginFn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeFrame)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForLastInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Meta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OpCodeMetadataType), typeof(DynValue)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "PushSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SourceRef), Member = "FormatLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FastStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000794")]
	public int CompileBody(ByteCode bc, string friendlyName) { }

	[Address(RVA = "0x31F810", Offset = "0x31EA10", Length = "0x225")]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600078F")]
	private Statement CreateBody(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x31FA40", Offset = "0x31EC40", Length = "0x215")]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Expression), Member = "Expr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600078E")]
	private Statement CreateLambdaBody(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x31FC60", Offset = "0x31EE60", Length = "0x1DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SymbolRef), Member = "Upvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000792")]
	public override SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) { }

	[Address(RVA = "0x31FE40", Offset = "0x31F040", Length = "0x230")]
	[CalledBy(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(BuildTimeScope), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000791")]
	private SymbolRef[] DefineArguments(List<String> paramnames, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x320080", Offset = "0x31F280", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000793")]
	public virtual DynValue Eval(ScriptExecutionContext context) { }

}

