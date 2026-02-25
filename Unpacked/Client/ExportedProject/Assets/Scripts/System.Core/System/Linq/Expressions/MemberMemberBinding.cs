namespace System.Linq.Expressions;

[Token(Token = "0x2000090")]
public sealed class MemberMemberBinding : MemberBinding
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014A")]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700009E")]
	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003A1")]
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

}

