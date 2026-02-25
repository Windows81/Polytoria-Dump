namespace RLD;

[Token(Token = "0x20001A6")]
public struct CircleEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D9")]
	private float _radiusEps; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006DA")]
	private float _extrudeEps; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006DB")]
	private float _wireEps; //Field offset: 0x8

	[Token(Token = "0x170005A5")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600119E")]
		 get { } //Length: 6
		[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x600119F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A4")]
	public float RadiusEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600119C")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x600119D")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170005A6")]
	public float WireEps
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A0")]
		 get { } //Length: 6
		[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A1")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600119E")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600119C")]
	public float get_RadiusEps() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A0")]
	public float get_WireEps() { }

	[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x600119F")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x600119D")]
	public void set_RadiusEps(float value) { }

	[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A1")]
	public void set_WireEps(float value) { }

}

