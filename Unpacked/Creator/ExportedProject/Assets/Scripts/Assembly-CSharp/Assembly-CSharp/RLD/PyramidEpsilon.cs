namespace RLD;

[Token(Token = "0x20001A4")]
public struct PyramidEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D5")]
	private float _ptContainEps; //Field offset: 0x0

	[Token(Token = "0x170005A0")]
	public float PtContainEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001194")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001195")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001194")]
	public float get_PtContainEps() { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001195")]
	public void set_PtContainEps(float value) { }

}

