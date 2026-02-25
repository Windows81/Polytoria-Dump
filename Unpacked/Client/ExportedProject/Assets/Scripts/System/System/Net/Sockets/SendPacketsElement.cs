namespace System.Net.Sockets;

[Token(Token = "0x20002F5")]
public class SendPacketsElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D5D")]
	internal string m_FilePath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D5E")]
	internal Byte[] m_Buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D5F")]
	internal int m_Offset; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000D60")]
	internal int m_Count; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D61")]
	private bool m_endOfPacket; //Field offset: 0x28

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001337")]
	private SendPacketsElement() { }

}

