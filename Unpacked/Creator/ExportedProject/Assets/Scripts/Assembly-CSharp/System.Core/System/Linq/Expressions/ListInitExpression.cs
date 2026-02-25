namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
[Token(Token = "0x2000086")]
public sealed class ListInitExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000138")]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000139")]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700008F")]
	public ReadOnlyCollection<ElementInit> Initializers
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000388")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008E")]
	public NewExpression NewExpression
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000387")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000388")]
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000387")]
	public NewExpression get_NewExpression() { }

}

