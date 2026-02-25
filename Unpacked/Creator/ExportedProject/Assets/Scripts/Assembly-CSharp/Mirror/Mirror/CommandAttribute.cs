namespace Mirror;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000008")]
public class CommandAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002B")]
	public int channel; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400002C")]
	public bool requiresAuthority; //Field offset: 0x14

	[Address(RVA = "0x124D480", Offset = "0x124C680", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	public CommandAttribute() { }

}

