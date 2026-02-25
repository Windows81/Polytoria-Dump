namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x200009C")]
internal class WhileStatement : Statement
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031C")]
	private Expression m_Condition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031D")]
	private Statement m_Block; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031E")]
	private RuntimeScopeBlock m_StackFrame; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400031F")]
	private SourceRef m_Start; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000320")]
	private SourceRef m_End; //Field offset: 0x40

	[Address(RVA = "0x330240", Offset = "0x32F440", Length = "0x397")]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Expr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000762")]
	public WhileStatement(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x32FF60", Offset = "0x32F160", Length = "0x2D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(FastStack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "PopSourceRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "PushSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FastStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Loop), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000763")]
	public virtual void Compile(ByteCode bc) { }

}

