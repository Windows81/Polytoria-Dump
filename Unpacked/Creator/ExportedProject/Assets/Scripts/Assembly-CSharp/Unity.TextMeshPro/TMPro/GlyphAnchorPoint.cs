namespace TMPro;

[Token(Token = "0x2000009")]
public struct GlyphAnchorPoint
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private float m_XCoordinate; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private float m_YCoordinate; //Field offset: 0x4

	[Token(Token = "0x17000001")]
	public float xCoordinate
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000013")]
		 get { } //Length: 5
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public float yCoordinate
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000015")]
		 get { } //Length: 6
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000016")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public float get_xCoordinate() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public float get_yCoordinate() { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public void set_xCoordinate(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public void set_yCoordinate(float value) { }

}

