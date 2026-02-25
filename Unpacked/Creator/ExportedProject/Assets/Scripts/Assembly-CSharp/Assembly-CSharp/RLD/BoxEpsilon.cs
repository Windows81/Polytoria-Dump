namespace RLD;

[Token(Token = "0x20001A0")]
public struct BoxEpsilon
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006CF")]
	private Vector3 _sizeEps; //Field offset: 0x0

	[Token(Token = "0x1700059A")]
	public float DepthEps
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001188")]
		 get { } //Length: 6
		[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001189")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000599")]
	public float HeightEps
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001186")]
		 get { } //Length: 6
		[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001187")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000597")]
	public Vector3 SizeEps
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001182")]
		 get { } //Length: 18
		[Address(RVA = "0x557450", Offset = "0x556650", Length = "0x37")]
		[CalledBy(Type = typeof(BoxShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6001183")]
		 set { } //Length: 55
	}

	[Token(Token = "0x17000598")]
	public float WidthEps
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001184")]
		 get { } //Length: 5
		[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001185")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001188")]
	public float get_DepthEps() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001186")]
	public float get_HeightEps() { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001182")]
	public Vector3 get_SizeEps() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001184")]
	public float get_WidthEps() { }

	[Address(RVA = "0x553B10", Offset = "0x552D10", Length = "0xD")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001189")]
	public void set_DepthEps(float value) { }

	[Address(RVA = "0x553B00", Offset = "0x552D00", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001187")]
	public void set_HeightEps(float value) { }

	[Address(RVA = "0x557450", Offset = "0x556650", Length = "0x37")]
	[CalledBy(Type = typeof(BoxShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001183")]
	public void set_SizeEps(Vector3 value) { }

	[Address(RVA = "0x553AF0", Offset = "0x552CF0", Length = "0xC")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001185")]
	public void set_WidthEps(float value) { }

}

