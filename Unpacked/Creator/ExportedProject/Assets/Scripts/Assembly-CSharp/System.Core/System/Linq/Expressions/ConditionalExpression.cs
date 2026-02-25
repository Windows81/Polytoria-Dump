namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConditionalExpressionProxy))]
[Token(Token = "0x2000068")]
public class ConditionalExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B9")]
	private readonly Expression <Test>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BA")]
	private readonly Expression <IfTrue>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000053")]
	public Expression IfFalse
	{
		[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025E")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000052")]
	public Expression IfTrue
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600025D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004F")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000051")]
	public Expression Test
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600025C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000050")]
	public virtual Type Type
	{
		[Address(RVA = "0x1572050", Offset = "0x1571250", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025B")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1594B50", Offset = "0x1593D50", Length = "0x82")]
	[CalledBy(Type = typeof(ConditionalExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(FullConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullConditionalExpressionWithType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000258")]
	internal ConditionalExpression(Expression test, Expression ifTrue) { }

	[Address(RVA = "0x15947D0", Offset = "0x15939D0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000260")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x331320", Offset = "0x330520", Length = "0x14")]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025E")]
	public Expression get_IfFalse() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600025D")]
	public Expression get_IfTrue() { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025A")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600025C")]
	public Expression get_Test() { }

	[Address(RVA = "0x1572050", Offset = "0x1571250", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025B")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x1594800", Offset = "0x1593A00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600025F")]
	internal override Expression GetFalse() { }

	[Address(RVA = "0x1594860", Offset = "0x1593A60", Length = "0x219")]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000259")]
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[Address(RVA = "0x1594A80", Offset = "0x1593C80", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000261")]
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }

}

