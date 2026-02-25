namespace System.Net.NetworkInformation;

[Token(Token = "0x20002C8")]
public enum NetBiosNodeType
{
	Unknown = 0,
	Broadcast = 1,
	Peer2Peer = 2,
	Mixed = 4,
	Hybrid = 8,
}

