namespace MoonSharp.Interpreter.Tree.Expressions;

[Token(Token = "0x200009E")]
internal class AdjustmentExpression : Expression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000321")]
	private Expression expression; //Field offset: 0x20

	[Address(RVA = "0x316850", Offset = "0x315A50", Length = "0x32")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000768")]
	public AdjustmentExpression(ScriptLoadingContext lcontext, Expression exp) { }

	[Address(RVA = "0x3167D0", Offset = "0x3159D0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Scalar", ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000769")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x316810", Offset = "0x315A10", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600076A")]
	public virtual DynValue Eval(ScriptExecutionContext context) { }

}

