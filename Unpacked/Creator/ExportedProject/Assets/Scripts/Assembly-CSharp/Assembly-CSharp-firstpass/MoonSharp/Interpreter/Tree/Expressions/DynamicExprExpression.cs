namespace MoonSharp.Interpreter.Tree.Expressions;

[Token(Token = "0x20000A3")]
internal class DynamicExprExpression : Expression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000344")]
	private Expression m_Exp; //Field offset: 0x20

	[Address(RVA = "0x31BFB0", Offset = "0x31B1B0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600077E")]
	public DynamicExprExpression(Expression exp, ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x31BF10", Offset = "0x31B110", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000780")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x31BF50", Offset = "0x31B150", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600077F")]
	public virtual DynValue Eval(ScriptExecutionContext context) { }

	[Address(RVA = "0x31BF80", Offset = "0x31B180", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000781")]
	public virtual SymbolRef FindDynamic(ScriptExecutionContext context) { }

}

