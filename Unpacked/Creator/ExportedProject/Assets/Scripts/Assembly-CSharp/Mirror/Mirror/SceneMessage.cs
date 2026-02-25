namespace Mirror;

[Token(Token = "0x2000026")]
public struct SceneMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000053")]
	public string sceneName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000054")]
	public SceneOperation sceneOperation; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000055")]
	public bool customHandling; //Field offset: 0x9

}

