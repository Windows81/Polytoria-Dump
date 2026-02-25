namespace Polytoria.UI;

[Token(Token = "0x20002EB")]
public class SlashCommand
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B4C")]
	public int Icon; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B4D")]
	public string CommandName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B4E")]
	public String[] Args; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B4F")]
	public string Description; //Field offset: 0x28

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B36")]
	public SlashCommand() { }

}

