namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DefaultExpressionProxy))]
[Token(Token = "0x200006E")]
public sealed class DefaultExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C0")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700005E")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x15959F0", Offset = "0x1594BF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000273")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700005D")]
	public virtual Type Type
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000272")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1595980", Offset = "0x1594B80", Length = "0x65")]
	[CalledBy(Type = typeof(Expression), Member = "Empty", ReturnType = typeof(DefaultExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DefaultExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000271")]
	internal DefaultExpression(Type type) { }

	[Address(RVA = "0x1595950", Offset = "0x1594B50", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000274")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x15959F0", Offset = "0x1594BF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000273")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000272")]
	public virtual Type get_Type() { }

}

