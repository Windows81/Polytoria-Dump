namespace Discord;

[Token(Token = "0x20001DF")]
public struct Entitlement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000700")]
	public long Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000701")]
	public EntitlementType Type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000702")]
	public long SkuId; //Field offset: 0x10

}

