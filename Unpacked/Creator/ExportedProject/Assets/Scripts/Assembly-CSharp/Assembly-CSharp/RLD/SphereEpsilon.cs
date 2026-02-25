namespace RLD;

[Token(Token = "0x200019E")]
public struct SphereEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006CC")]
	private float _radiusEps; //Field offset: 0x0

	[Token(Token = "0x17000594")]
	public float RadiusEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600117C")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x600117D")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600117C")]
	public float get_RadiusEps() { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x600117D")]
	public void set_RadiusEps(float value) { }

}

