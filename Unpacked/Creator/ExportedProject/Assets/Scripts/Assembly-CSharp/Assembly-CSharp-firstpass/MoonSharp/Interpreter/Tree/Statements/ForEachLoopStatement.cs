namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x200008F")]
internal class ForEachLoopStatement : Statement
{
	[CompilerGenerated]
	[Token(Token = "0x2000090")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002E7")]
		public ScriptLoadingContext lcontext; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000727")]
		public <>c__DisplayClass7_0() { }

		[Address(RVA = "0x32E620", Offset = "0x32D820", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BuildTimeScope), Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000728")]
		internal SymbolRef <.ctor>b__0(string n) { }

		[Address(RVA = "0x32E650", Offset = "0x32D850", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000729")]
		internal SymbolRefExpression <.ctor>b__1(SymbolRef s) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E0")]
	private RuntimeScopeBlock m_StackFrame; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E1")]
	private SymbolRef[] m_Names; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002E2")]
	private IVariable[] m_NameExps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002E3")]
	private Expression m_RValues; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002E4")]
	private Statement m_Block; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002E5")]
	private SourceRef m_RefFor; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002E6")]
	private SourceRef m_RefEnd; //Field offset: 0x50

	[Address(RVA = "0x31D750", Offset = "0x31C950", Length = "0x728")]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CalledBy(Type = typeof(Statement), Member = "DispatchForLoopStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ExprList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Tree.Expression>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000725")]
	public ForEachLoopStatement(ScriptLoadingContext lcontext, Token firstNameToken, Token forToken) { }

	[Address(RVA = "0x31D2C0", Offset = "0x31C4C0", Length = "0x482")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(FastStack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "PopSourceRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_IterUpd", ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_ExpTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_IterPrep", ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(FastStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Loop), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ByteCode), Member = "PushSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000726")]
	public virtual void Compile(ByteCode bc) { }

}

