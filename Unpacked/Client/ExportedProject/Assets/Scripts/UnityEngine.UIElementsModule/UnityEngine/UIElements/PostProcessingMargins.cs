namespace UnityEngine.UIElements;

[Token(Token = "0x200024B")]
internal struct PostProcessingMargins
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40008E1")]
	private float m_Left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40008E2")]
	private float m_Top; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40008E3")]
	private float m_Right; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x40008E4")]
	private float m_Bottom; //Field offset: 0xC

	[Token(Token = "0x170002E2")]
	public float bottom
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBF")]
		 get { } //Length: 6
		[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FC0")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170002DF")]
	public float left
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB9")]
		 get { } //Length: 5
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBA")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002E1")]
	public float right
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBD")]
		 get { } //Length: 6
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBE")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170002E0")]
	public float top
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBB")]
		 get { } //Length: 6
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FBC")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBF")]
	public float get_bottom() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB9")]
	public float get_left() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBD")]
	public float get_right() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBB")]
	public float get_top() { }

	[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FC0")]
	public void set_bottom(float value) { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBA")]
	public void set_left(float value) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBE")]
	public void set_right(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBC")]
	public void set_top(float value) { }

}

