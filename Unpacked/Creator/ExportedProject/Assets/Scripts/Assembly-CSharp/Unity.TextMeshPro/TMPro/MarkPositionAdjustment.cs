namespace TMPro;

[Token(Token = "0x200000A")]
public struct MarkPositionAdjustment
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000015")]
	private float m_XPositionAdjustment; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000016")]
	private float m_YPositionAdjustment; //Field offset: 0x4

	[Token(Token = "0x17000003")]
	public float xPositionAdjustment
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000017")]
		 get { } //Length: 5
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000018")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public float yPositionAdjustment
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000019")]
		 get { } //Length: 6
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001A")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x40FBC0", Offset = "0x40EDC0", Length = "0xA")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	public MarkPositionAdjustment(float x, float y) { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000017")]
	public float get_xPositionAdjustment() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000019")]
	public float get_yPositionAdjustment() { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public void set_xPositionAdjustment(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	public void set_yPositionAdjustment(float value) { }

}

