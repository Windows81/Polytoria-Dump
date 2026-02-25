namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
[Token(Token = "0x2000087")]
public sealed class LoopExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013A")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400013B")]
	private readonly LabelTarget <BreakLabel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400013C")]
	private readonly LabelTarget <ContinueLabel>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000090")]
	public Expression Body
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000389")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000091")]
	public LabelTarget BreakLabel
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600038A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000092")]
	public LabelTarget ContinueLabel
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600038B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000389")]
	public Expression get_Body() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600038A")]
	public LabelTarget get_BreakLabel() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600038B")]
	public LabelTarget get_ContinueLabel() { }

}

