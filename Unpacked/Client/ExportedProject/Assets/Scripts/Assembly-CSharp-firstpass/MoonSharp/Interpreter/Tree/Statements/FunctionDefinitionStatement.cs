namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x2000093")]
internal class FunctionDefinitionStatement : Statement
{
	[CompilerGenerated]
	[Token(Token = "0x2000094")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002F9")]
		public FunctionDefinitionStatement <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002FA")]
		public ByteCode bc; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000733")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x32E720", Offset = "0x32D920", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000734")]
		internal int <Compile>b__0() { }

		[Address(RVA = "0x32E780", Offset = "0x32D980", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000735")]
		internal int <Compile>b__1() { }

		[Address(RVA = "0x32E7E0", Offset = "0x32D9E0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FunctionDefinitionStatement), Member = "SetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000736")]
		internal int <Compile>b__2() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F1")]
	private SymbolRef m_FuncSymbol; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F2")]
	private SourceRef m_SourceRef; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F3")]
	private bool m_Local; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40002F4")]
	private bool m_IsMethodCallingConvention; //Field offset: 0x31
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002F5")]
	private string m_MethodName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F6")]
	private string m_FriendlyName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F7")]
	private List<String> m_TableAccessors; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002F8")]
	private FunctionDefinitionExpression m_FuncDef; //Field offset: 0x50

	[Address(RVA = "0x320AC0", Offset = "0x31FCC0", Length = "0x564")]
	[CalledBy(Type = typeof(Statement), Member = "CreateStatement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Boolean&)}, ReturnType = typeof(Statement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BuildTimeScope), Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BuildTimeScope), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NodeBase), Member = "UnexpectedTokenType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600072F")]
	public FunctionDefinitionStatement(ScriptLoadingContext lcontext, bool local, Token localToken) { }

	[Address(RVA = "0x320530", Offset = "0x31F730", Length = "0x339")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ByteCode), Member = "EnterSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(FunctionDefinitionExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode), typeof(System.Func`1<System.Int32>), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Literal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000730")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x320870", Offset = "0x31FA70", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000732")]
	private int SetFunction(ByteCode bc, int numPop) { }

	[Address(RVA = "0x3208D0", Offset = "0x31FAD0", Length = "0x1E9")]
	[CalledBy(Type = typeof(<>c__DisplayClass9_0), Member = "<Compile>b__2", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(bool), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_IndexSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DynValue), typeof(bool), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000731")]
	private int SetMethod(ByteCode bc) { }

}

