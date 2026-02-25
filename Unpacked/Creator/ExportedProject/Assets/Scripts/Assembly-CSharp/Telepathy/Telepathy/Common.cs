namespace Telepathy;

[Token(Token = "0x2000008")]
public abstract class Common
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	public bool NoDelay; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000014")]
	public readonly int MaxMessageSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000015")]
	public int SendTimeout; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000016")]
	public int ReceiveTimeout; //Field offset: 0x1C

	[Address(RVA = "0x18025E0", Offset = "0x18017E0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	protected Common(int MaxMessageSize) { }

}

