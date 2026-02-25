namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x200030C")]
public struct SpotLight
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009BE")]
	public int instanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009BF")]
	public bool shadow; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40009C0")]
	public LightMode mode; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009C1")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009C2")]
	public Quaternion orientation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009C3")]
	public LinearColor color; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009C4")]
	public LinearColor indirectColor; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40009C5")]
	public float range; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009C6")]
	public float sphereRadius; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40009C7")]
	public float coneAngle; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009C8")]
	public float innerConeAngle; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40009C9")]
	public FalloffType falloff; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40009CA")]
	public AngularFalloffType angularFalloff; //Field offset: 0x55

}

