namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
[Token(Token = "0x2000075")]
public sealed class GotoExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000120")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000121")]
	private readonly Expression <Value>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000122")]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000123")]
	private readonly GotoExpressionKind <Kind>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000066")]
	public GotoExpressionKind Kind
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000332")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000063")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x15A2980", Offset = "0x15A1B80", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600032F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000065")]
	public LabelTarget Target
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000331")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000062")]
	public virtual Type Type
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000064")]
	public Expression Value
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000330")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15A28D0", Offset = "0x15A1AD0", Length = "0xA3")]
	[CalledBy(Type = typeof(Expression), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600032D")]
	internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[Address(RVA = "0x15A27E0", Offset = "0x15A19E0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000333")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000332")]
	public GotoExpressionKind get_Kind() { }

	[Address(RVA = "0x15A2980", Offset = "0x15A1B80", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032F")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000331")]
	public LabelTarget get_Target() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032E")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000330")]
	public Expression get_Value() { }

	[Address(RVA = "0x15A2810", Offset = "0x15A1A10", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000334")]
	public GotoExpression Update(LabelTarget target, Expression value) { }

}

