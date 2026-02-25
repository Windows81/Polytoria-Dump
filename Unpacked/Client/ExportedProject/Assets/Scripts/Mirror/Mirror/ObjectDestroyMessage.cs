namespace Mirror;

[Token(Token = "0x200002F")]
public struct ObjectDestroyMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000070")]
	public uint netId; //Field offset: 0x0

}

