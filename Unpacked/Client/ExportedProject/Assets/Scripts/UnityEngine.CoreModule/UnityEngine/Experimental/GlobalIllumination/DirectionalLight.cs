namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x200030A")]
public struct DirectionalLight
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009AB")]
	public int instanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009AC")]
	public bool shadow; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40009AD")]
	public LightMode mode; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009AE")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009AF")]
	public Quaternion orientation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009B0")]
	public LinearColor color; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009B1")]
	public LinearColor indirectColor; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40009B2")]
	public float penumbraWidthRadian; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
	[Token(Token = "0x40009B3")]
	public Vector3 direction; //Field offset: 0x48

}

