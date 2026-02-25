namespace Mirror;

[Token(Token = "0x2000030")]
public struct ObjectHideMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000071")]
	public uint netId; //Field offset: 0x0

}

