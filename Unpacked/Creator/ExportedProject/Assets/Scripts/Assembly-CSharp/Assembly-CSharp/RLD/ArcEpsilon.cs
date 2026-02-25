namespace RLD;

[Token(Token = "0x20001A5")]
public struct ArcEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D6")]
	private float _areaEps; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006D7")]
	private float _extrudeEps; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006D8")]
	private float _wireEps; //Field offset: 0x8

	[Token(Token = "0x170005A1")]
	public float AreaEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001196")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001197")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170005A2")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001198")]
		 get { } //Length: 6
		[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001199")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A3")]
	public float WireEps
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600119A")]
		 get { } //Length: 6
		[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600119B")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001196")]
	public float get_AreaEps() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001198")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600119A")]
	public float get_WireEps() { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001197")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001199")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600119B")]
	public void set_WireEps(float value) { }

}

