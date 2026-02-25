namespace UnityEngine.Networking.PlayerConnection;

[Token(Token = "0x2000285")]
public class MessageEventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AF")]
	public int playerId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006B0")]
	public Byte[] data; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CEF")]
	public MessageEventArgs() { }

}

