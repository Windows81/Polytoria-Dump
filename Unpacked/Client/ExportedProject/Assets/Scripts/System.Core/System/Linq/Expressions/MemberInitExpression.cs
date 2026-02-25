namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
[Token(Token = "0x200008E")]
public sealed class MemberInitExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000147")]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000148")]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700009C")]
	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600039F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009B")]
	public NewExpression NewExpression
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600039E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600039F")]
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600039E")]
	public NewExpression get_NewExpression() { }

}

