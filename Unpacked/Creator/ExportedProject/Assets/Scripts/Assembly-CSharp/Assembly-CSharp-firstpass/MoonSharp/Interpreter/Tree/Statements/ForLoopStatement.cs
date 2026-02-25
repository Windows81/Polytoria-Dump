namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x2000091")]
internal class ForLoopStatement : Statement
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E8")]
	private RuntimeScopeBlock m_StackFrame; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E9")]
	private Statement m_InnerBlock; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002EA")]
	private SymbolRef m_VarName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002EB")]
	private Expression m_Start; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002EC")]
	private Expression m_End; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002ED")]
	private Expression m_Step; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002EE")]
	private SourceRef m_RefFor; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002EF")]
	private SourceRef m_RefEnd; //Field offset: 0x58

	[Address(RVA = "0x31E220", Offset = "0x31D420", Length = "0x4E5")]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CalledBy(Type = typeof(Statement), Member = "DispatchForLoopStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Expr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600072A")]
	public ForLoopStatement(ScriptLoadingContext lcontext, Token nameToken, Token forToken) { }

	[Address(RVA = "0x31DE80", Offset = "0x31D080", Length = "0x394")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(FastStack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Incr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "PopSourceRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_ToNum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(FastStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Loop), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ByteCode), Member = "PushSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600072B")]
	public virtual void Compile(ByteCode bc) { }

}

