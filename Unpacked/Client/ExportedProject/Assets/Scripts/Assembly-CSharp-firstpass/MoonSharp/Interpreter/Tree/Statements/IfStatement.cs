namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x2000096")]
internal class IfStatement : Statement
{
	[Token(Token = "0x2000097")]
	private class IfBlock
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000305")]
		public Expression Exp; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000306")]
		public Statement Block; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000307")]
		public RuntimeScopeBlock StackFrame; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000308")]
		public SourceRef Source; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000749")]
		public IfBlock() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000302")]
	private List<IfBlock> m_Ifs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000303")]
	private IfBlock m_Else; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000304")]
	private SourceRef m_End; //Field offset: 0x30

	[Address(RVA = "0x321E00", Offset = "0x321000", Length = "0x2B5")]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IfStatement), Member = "CreateIfBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(IfBlock))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IfStatement), Member = "CreateElseBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(IfBlock))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000745")]
	public IfStatement(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x3212C0", Offset = "0x3204C0", Length = "0x698")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForNextInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ByteCode), Member = "EnterSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Jump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpCode), typeof(int), typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeBlock)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000748")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x321960", Offset = "0x320B60", Length = "0x1CD")]
	[CalledBy(Type = typeof(IfStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000747")]
	private IfBlock CreateElseBlock(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x321B30", Offset = "0x320D30", Length = "0x2C3")]
	[CalledBy(Type = typeof(IfStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Expr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SourceRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000746")]
	private IfBlock CreateIfBlock(ScriptLoadingContext lcontext) { }

}

