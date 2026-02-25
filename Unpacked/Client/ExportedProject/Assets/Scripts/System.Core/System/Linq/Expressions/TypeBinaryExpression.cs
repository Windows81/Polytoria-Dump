namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
[Token(Token = "0x20000AF")]
public sealed class TypeBinaryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017B")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017C")]
	private readonly Type <TypeOperand>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000FE")]
	public Expression Expression
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000487")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FF")]
	public Type TypeOperand
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000488")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000487")]
	public Expression get_Expression() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000488")]
	public Type get_TypeOperand() { }

}

