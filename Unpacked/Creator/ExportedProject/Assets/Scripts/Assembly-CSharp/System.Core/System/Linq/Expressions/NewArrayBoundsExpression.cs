namespace System.Linq.Expressions;

[Token(Token = "0x20000A1")]
internal sealed class NewArrayBoundsExpression : NewArrayExpression
{

	[Token(Token = "0x170000B4")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x3CE2F0", Offset = "0x3CD4F0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15A6EC0", Offset = "0x15A60C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewArrayExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F4")]
	internal NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x3CE2F0", Offset = "0x3CD4F0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F5")]
	public virtual ExpressionType get_NodeType() { }

}

