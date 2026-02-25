namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x200030B")]
public struct PointLight
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009B4")]
	public int instanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009B5")]
	public bool shadow; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40009B6")]
	public LightMode mode; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009B7")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009B8")]
	public Quaternion orientation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009B9")]
	public LinearColor color; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009BA")]
	public LinearColor indirectColor; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40009BB")]
	public float range; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009BC")]
	public float sphereRadius; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40009BD")]
	public FalloffType falloff; //Field offset: 0x4C

}

