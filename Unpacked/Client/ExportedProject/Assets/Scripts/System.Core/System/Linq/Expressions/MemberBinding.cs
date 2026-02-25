namespace System.Linq.Expressions;

[Token(Token = "0x200008A")]
public abstract class MemberBinding
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000142")]
	private readonly MemberBindingType <BindingType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000143")]
	private readonly MemberInfo <Member>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000094")]
	public MemberBindingType BindingType
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600038D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000095")]
	public MemberInfo Member
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600038E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600038D")]
	public MemberBindingType get_BindingType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600038E")]
	public MemberInfo get_Member() { }

}

