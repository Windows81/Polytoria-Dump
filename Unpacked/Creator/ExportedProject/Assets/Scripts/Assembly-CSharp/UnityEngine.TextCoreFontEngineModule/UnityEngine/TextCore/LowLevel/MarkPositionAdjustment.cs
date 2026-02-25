namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000015")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkPositionAdjustment
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("xCoordinate")]
	[SerializeField]
	[Token(Token = "0x400008F")]
	private float m_XPositionAdjustment; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("yCoordinate")]
	[SerializeField]
	[Token(Token = "0x4000090")]
	private float m_YPositionAdjustment; //Field offset: 0x4

	[Token(Token = "0x1700002F")]
	public float xPositionAdjustment
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		 get { } //Length: 7
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000030")]
	public float yPositionAdjustment
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 8
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A7")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A4")]
	public float get_xPositionAdjustment() { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A6")]
	public float get_yPositionAdjustment() { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A5")]
	public void set_xPositionAdjustment(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	public void set_yPositionAdjustment(float value) { }

}

