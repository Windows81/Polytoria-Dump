namespace RLD;

[Token(Token = "0x20001A7")]
public struct PolygonEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DC")]
	private float _areaEps; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006DD")]
	private float _extrudeEps; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006DE")]
	private float _wireEps; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006DF")]
	private float _thickWireEps; //Field offset: 0xC

	[Token(Token = "0x170005A7")]
	public float AreaEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A2")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A3")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170005A8")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A4")]
		 get { } //Length: 6
		[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005AA")]
	public float ThickWireEps
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A8")]
		 get { } //Length: 6
		[Address(RVA = "0x564BA0", Offset = "0x563DA0", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A9")]
	public float WireEps
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A6")]
		 get { } //Length: 6
		[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A7")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A2")]
	public float get_AreaEps() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A4")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A8")]
	public float get_ThickWireEps() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A6")]
	public float get_WireEps() { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A3")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A5")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x564BA0", Offset = "0x563DA0", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A9")]
	public void set_ThickWireEps(float value) { }

	[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A7")]
	public void set_WireEps(float value) { }

}

