namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x200008C")]
internal class ChunkStatement : Statement, IClosureBuilder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002DB")]
	private Statement m_Block; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002DC")]
	private RuntimeScopeFrame m_StackFrame; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002DD")]
	private SymbolRef m_Env; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002DE")]
	private SymbolRef m_VarArgs; //Field offset: 0x38

	[Address(RVA = "0x319F80", Offset = "0x319180", Length = "0x260")]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lexer), Member = "get_Current", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BuildTimeScope), Member = "PopFunction", ReturnType = typeof(RuntimeScopeFrame))]
	[Calls(Type = typeof(CompositeStatement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BuildTimeScope), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(BuildTimeScope), Member = "PushFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClosureBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600071E")]
	public ChunkStatement(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x319D90", Offset = "0x318F90", Length = "0x1E4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Args", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef[])}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Ret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolRef), Member = "Upvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ByteCode), Member = "Emit_BeginFn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeScopeFrame)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(ByteCode), Member = "GetJumpPointForLastInstruction", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Meta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OpCodeMetadataType), typeof(DynValue)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071F")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000720")]
	public override SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) { }

}

