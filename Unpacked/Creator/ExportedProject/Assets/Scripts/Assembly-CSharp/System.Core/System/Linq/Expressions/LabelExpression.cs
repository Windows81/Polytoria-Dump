namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
[Token(Token = "0x200007B")]
public sealed class LabelExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012A")]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400012B")]
	private readonly Expression <DefaultValue>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000076")]
	public Expression DefaultValue
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000352")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000074")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x7C8180", Offset = "0x7C7380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000350")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000075")]
	public LabelTarget Target
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000351")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000073")]
	public virtual Type Type
	{
		[Address(RVA = "0x1377450", Offset = "0x1376650", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600034F")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x15A4E70", Offset = "0x15A4070", Length = "0x82")]
	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600034E")]
	internal LabelExpression(LabelTarget label, Expression defaultValue) { }

	[Address(RVA = "0x15A4DB0", Offset = "0x15A3FB0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000353")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000352")]
	public Expression get_DefaultValue() { }

	[Address(RVA = "0x7C8180", Offset = "0x7C7380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000350")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000351")]
	public LabelTarget get_Target() { }

	[Address(RVA = "0x1377450", Offset = "0x1376650", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600034F")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x15A4DE0", Offset = "0x15A3FE0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[Token(Token = "0x6000354")]
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }

}

