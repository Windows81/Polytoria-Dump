namespace RLD;

[Token(Token = "0x20001A8")]
public struct QuadEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E0")]
	private Vector2 _sizeEps; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006E1")]
	private float _extrudeEps; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006E2")]
	private float _wireEps; //Field offset: 0xC

	[Token(Token = "0x170005AE")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B0")]
		 get { } //Length: 6
		[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005AD")]
	public float HeightEps
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011AE")]
		 get { } //Length: 6
		[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011AF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005AB")]
	public Vector2 SizeEps
	{
		[Address(RVA = "0x56A3D0", Offset = "0x5695D0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011AA")]
		 get { } //Length: 18
		[Address(RVA = "0x56A3F0", Offset = "0x5695F0", Length = "0x29")]
		[CalledBy(Type = typeof(QuadShape2D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(QuadShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60011AB")]
		 set { } //Length: 41
	}

	[Token(Token = "0x170005AC")]
	public float WidthEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011AC")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011AD")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170005AF")]
	public float WireEps
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B2")]
		 get { } //Length: 6
		[Address(RVA = "0x564BA0", Offset = "0x563DA0", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B3")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B0")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011AE")]
	public float get_HeightEps() { }

	[Address(RVA = "0x56A3D0", Offset = "0x5695D0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011AA")]
	public Vector2 get_SizeEps() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011AC")]
	public float get_WidthEps() { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B2")]
	public float get_WireEps() { }

	[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B1")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011AF")]
	public void set_HeightEps(float value) { }

	[Address(RVA = "0x56A3F0", Offset = "0x5695F0", Length = "0x29")]
	[CalledBy(Type = typeof(QuadShape2D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuadShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60011AB")]
	public void set_SizeEps(Vector2 value) { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011AD")]
	public void set_WidthEps(float value) { }

	[Address(RVA = "0x564BA0", Offset = "0x563DA0", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B3")]
	public void set_WireEps(float value) { }

}

