namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
[Token(Token = "0x2000079")]
public class InvocationExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000127")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000128")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000071")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x15A4D70", Offset = "0x15A3F70", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000347")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000070")]
	public Expression Expression
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000345")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006F")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x15A4DA0", Offset = "0x15A3FA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000344")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700006E")]
	public virtual Type Type
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000343")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15A4CE0", Offset = "0x15A3EE0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000342")]
	internal InvocationExpression(Expression expression, Type returnType) { }

	[Address(RVA = "0x15A4C50", Offset = "0x15A3E50", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000348")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x15A4D70", Offset = "0x15A3F70", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000347")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000345")]
	public Expression get_Expression() { }

	[Address(RVA = "0x15A4DA0", Offset = "0x15A3FA0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000344")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000343")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15A4C80", Offset = "0x15A3E80", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000346")]
	public override Expression GetArgument(int index) { }

	[Address(RVA = "0x15A4CB0", Offset = "0x15A3EB0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000349")]
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

