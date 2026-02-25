namespace MoonSharp.Interpreter.Tree.Expressions;

[Token(Token = "0x20000AA")]
internal class SymbolRefExpression : Expression, IVariable
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400035B")]
	private SymbolRef m_Ref; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400035C")]
	private string m_VarName; //Field offset: 0x28

	[Address(RVA = "0x32C290", Offset = "0x32B490", Length = "0x193")]
	[CalledBy(Type = typeof(Expression), Member = "SimpleExp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "PrefixExp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BuildTimeScope), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Lexer), Member = "Next", ReturnType = typeof(void))]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BuildTimeScope), Member = "CurrentFunctionHasVarArgs", ReturnType = typeof(bool))]
	[Token(Token = "0x60007A4")]
	public SymbolRefExpression(Token T, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x32C1F0", Offset = "0x32B3F0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DynamicExpressionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A5")]
	public SymbolRefExpression(ScriptLoadingContext lcontext, SymbolRef refr) { }

	[Address(RVA = "0x32C160", Offset = "0x32B360", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A6")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x32C130", Offset = "0x32B330", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolRef), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A7")]
	public override void CompileAssignment(ByteCode bc, int stackofs, int tupleidx) { }

	[Address(RVA = "0x32C190", Offset = "0x32B390", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "EvaluateSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A8")]
	public virtual DynValue Eval(ScriptExecutionContext context) { }

	[Address(RVA = "0x32C1C0", Offset = "0x32B3C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "FindSymbolByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A9")]
	public virtual SymbolRef FindDynamic(ScriptExecutionContext context) { }

}

