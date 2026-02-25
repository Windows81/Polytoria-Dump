namespace RLD;

[Token(Token = "0x20001A3")]
public struct PrismEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D4")]
	private float _ptContainEps; //Field offset: 0x0

	[Token(Token = "0x1700059F")]
	public float PtContainEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001192")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001193")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001192")]
	public float get_PtContainEps() { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001193")]
	public void set_PtContainEps(float value) { }

}

