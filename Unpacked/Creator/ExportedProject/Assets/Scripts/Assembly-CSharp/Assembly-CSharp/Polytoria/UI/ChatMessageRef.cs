namespace Polytoria.UI;

[Token(Token = "0x20002E4")]
public class ChatMessageRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B2F")]
	public TMP_Text txt; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B30")]
	public bool faded; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B0E")]
	public ChatMessageRef() { }

}

