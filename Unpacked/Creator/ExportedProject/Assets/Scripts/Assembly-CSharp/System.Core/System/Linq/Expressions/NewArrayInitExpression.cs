namespace System.Linq.Expressions;

[Token(Token = "0x20000A0")]
internal sealed class NewArrayInitExpression : NewArrayExpression
{

	[Token(Token = "0x170000B3")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F3")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15A6EC0", Offset = "0x15A60C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewArrayExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F2")]
	internal NewArrayInitExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F3")]
	public virtual ExpressionType get_NodeType() { }

}

