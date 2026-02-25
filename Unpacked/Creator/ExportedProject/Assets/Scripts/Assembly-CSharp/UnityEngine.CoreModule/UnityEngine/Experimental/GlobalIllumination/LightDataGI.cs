namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x2000310")]
[UsedByNativeCode]
public struct LightDataGI
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E3")]
	public int instanceID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009E4")]
	public int cookieID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009E5")]
	public float cookieScale; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009E6")]
	public LinearColor color; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009E7")]
	public LinearColor indirectColor; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40009E8")]
	public Quaternion orientation; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40009E9")]
	public Vector3 position; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009EA")]
	public float range; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40009EB")]
	public float coneAngle; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009EC")]
	public float innerConeAngle; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40009ED")]
	public float shape0; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009EE")]
	public float shape1; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40009EF")]
	public LightType type; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x40009F0")]
	public LightMode mode; //Field offset: 0x5D
	[FieldOffset(Offset = "0x5E")]
	[Token(Token = "0x40009F1")]
	public byte shadow; //Field offset: 0x5E
	[FieldOffset(Offset = "0x5F")]
	[Token(Token = "0x40009F2")]
	public FalloffType falloff; //Field offset: 0x5F

	[Address(RVA = "0x19834C0", Offset = "0x19826C0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EBE")]
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	[Address(RVA = "0x1983540", Offset = "0x1982740", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EBF")]
	public void Init(ref PointLight light, ref Cookie cookie) { }

	[Address(RVA = "0x1983440", Offset = "0x1982640", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC0")]
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	[Address(RVA = "0x1983620", Offset = "0x1982820", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC1")]
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	[Address(RVA = "0x19835B0", Offset = "0x19827B0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EC2")]
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	[Address(RVA = "0x1983430", Offset = "0x1982630", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EC3")]
	public void InitNoBake(int lightInstanceID) { }

}

