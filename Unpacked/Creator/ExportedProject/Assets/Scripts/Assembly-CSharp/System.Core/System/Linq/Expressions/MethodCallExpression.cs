namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
[Token(Token = "0x2000091")]
public class MethodCallExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014B")]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x170000A4")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x15A6990", Offset = "0x15A5B90", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60003AD")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170000A3")]
	public ReadOnlyCollection<Expression> Arguments
	{
		[Address(RVA = "0x110B970", Offset = "0x110AB70", Length = "0x14")]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A8")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000A1")]
	public MethodInfo Method
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009F")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A4")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000A2")]
	public Expression Object
	{
		[Address(RVA = "0x10E6EA0", Offset = "0x10E60A0", Length = "0x14")]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A7")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000A0")]
	public virtual Type Type
	{
		[Address(RVA = "0x15A69C0", Offset = "0x15A5BC0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003A5")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x15A5A70", Offset = "0x15A4C70", Length = "0x65")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A2")]
	internal MethodCallExpression(MethodInfo method) { }

	[Address(RVA = "0x15A68D0", Offset = "0x15A5AD0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AA")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x15A6990", Offset = "0x15A5B90", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60003AD")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x110B970", Offset = "0x110AB70", Length = "0x14")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A8")]
	public ReadOnlyCollection<Expression> get_Arguments() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A6")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A4")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x10E6EA0", Offset = "0x10E60A0", Length = "0x14")]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A7")]
	public Expression get_Object() { }

	[Address(RVA = "0x15A69C0", Offset = "0x15A5BC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003A5")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15A6900", Offset = "0x15A5B00", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60003AC")]
	public override Expression GetArgument(int index) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A3")]
	internal override Expression GetInstance() { }

	[Address(RVA = "0x15A6930", Offset = "0x15A5B30", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60003A9")]
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[Address(RVA = "0x15A6960", Offset = "0x15A5B60", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60003AB")]
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

