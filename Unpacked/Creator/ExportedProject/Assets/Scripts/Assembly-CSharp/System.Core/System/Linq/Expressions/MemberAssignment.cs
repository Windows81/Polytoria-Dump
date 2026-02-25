namespace System.Linq.Expressions;

[Token(Token = "0x2000088")]
public sealed class MemberAssignment : MemberBinding
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400013D")]
	private readonly Expression _expression; //Field offset: 0x20

	[Token(Token = "0x17000093")]
	public Expression Expression
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600038C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038C")]
	public Expression get_Expression() { }

}

