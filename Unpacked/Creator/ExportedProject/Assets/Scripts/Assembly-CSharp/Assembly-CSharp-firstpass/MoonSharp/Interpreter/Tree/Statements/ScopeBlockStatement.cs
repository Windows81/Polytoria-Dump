namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x200009B")]
internal class ScopeBlockStatement : Statement
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000318")]
	private Statement m_Block; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000319")]
	private RuntimeScopeBlock m_StackFrame; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031A")]
	private SourceRef m_Do; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400031B")]
	private SourceRef m_End; //Field offset: 0x38

	[Address(RVA = "0x3298E0", Offset = "0x328AE0", Length = "0x299")]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000760")]
	public ScopeBlockStatement(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x329760", Offset = "0x328960", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteCode), Member = "EnterSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000761")]
	public virtual void Compile(ByteCode bc) { }

}

