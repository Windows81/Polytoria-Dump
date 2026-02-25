namespace System.Linq.Expressions;

[Token(Token = "0x200008F")]
public sealed class MemberListBinding : MemberBinding
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000149")]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700009D")]
	public ReadOnlyCollection<ElementInit> Initializers
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A0")]
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

}

