namespace RLD;

[Token(Token = "0x2000192")]
public struct BoxFaceAreaDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B3")]
	public BoxFaceAreaType AreaType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006B4")]
	public float Area; //Field offset: 0x4

	[Address(RVA = "0x5574A0", Offset = "0x5566A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600114F")]
	public BoxFaceAreaDesc(BoxFaceAreaType areaType, float area) { }

	[Address(RVA = "0x557490", Offset = "0x556690", Length = "0xF")]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001150")]
	public static BoxFaceAreaDesc GetInvalid() { }

}

