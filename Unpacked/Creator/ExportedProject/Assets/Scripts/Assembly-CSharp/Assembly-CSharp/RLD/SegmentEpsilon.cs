namespace RLD;

[Token(Token = "0x20001A2")]
public struct SegmentEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D2")]
	private float _raycastEps; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006D3")]
	private float _ptOnSegmentEps; //Field offset: 0x4

	[Token(Token = "0x1700059E")]
	public float PtOnSegmentEps
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001190")]
		 get { } //Length: 6
		[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001191")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700059D")]
	public float RaycastEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600118E")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x600118F")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001190")]
	public float get_PtOnSegmentEps() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600118E")]
	public float get_RaycastEps() { }

	[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001191")]
	public void set_PtOnSegmentEps(float value) { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x600118F")]
	public void set_RaycastEps(float value) { }

}

