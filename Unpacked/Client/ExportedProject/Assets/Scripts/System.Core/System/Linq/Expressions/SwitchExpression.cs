namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
[Token(Token = "0x20000AC")]
public sealed class SwitchExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000170")]
	private readonly Expression <SwitchValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000171")]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000172")]
	private readonly Expression <DefaultBody>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000173")]
	private readonly MethodInfo <Comparison>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170000F4")]
	public ReadOnlyCollection<SwitchCase> Cases
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000479")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F6")]
	public MethodInfo Comparison
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F5")]
	public Expression DefaultBody
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F3")]
	public Expression SwitchValue
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000478")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000479")]
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047B")]
	public MethodInfo get_Comparison() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047A")]
	public Expression get_DefaultBody() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000478")]
	public Expression get_SwitchValue() { }

}

