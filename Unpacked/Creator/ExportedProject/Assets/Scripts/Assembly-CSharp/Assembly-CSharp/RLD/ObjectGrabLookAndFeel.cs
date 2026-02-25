namespace RLD;

[Token(Token = "0x2000226")]
public class ObjectGrabLookAndFeel : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000851")]
	private bool _drawAnchorLines; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000852")]
	private Color _anchorLineColor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000853")]
	private bool _drawObjectPosTicks; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	[Token(Token = "0x4000854")]
	private bool _drawAnchorPosTick; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000855")]
	private Color _objectPosTickColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000856")]
	private Color _anchorPosTickColor; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000857")]
	private float _objectPosTickSize; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000858")]
	private float _anchorPosTickSize; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000859")]
	private bool _drawObjectBoxes; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x400085A")]
	private Color _objectBoxWireColor; //Field offset: 0x6C

	[Token(Token = "0x17000697")]
	public Color AnchorLineColor
	{
		[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B5")]
		 get { } //Length: 11
		[Address(RVA = "0x599170", Offset = "0x598370", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B6")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700069C")]
	public Color AnchorPosTickColor
	{
		[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014BF")]
		 get { } //Length: 11
		[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C0")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700069D")]
	public float AnchorPosTickSize
	{
		[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C1")]
		 get { } //Length: 6
		[Address(RVA = "0x599180", Offset = "0x598380", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014C2")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000696")]
	public bool DrawAnchorLines
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B3")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000699")]
	public bool DrawAnchorPosTick
	{
		[Address(RVA = "0x599150", Offset = "0x598350", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014B9")]
		 get { } //Length: 5
		[Address(RVA = "0x5991A0", Offset = "0x5983A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014BA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700069E")]
	public bool DrawObjectBoxes
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C3")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000698")]
	public bool DrawObjectPosTicks
	{
		[Address(RVA = "0x599160", Offset = "0x598360", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B7")]
		 get { } //Length: 5
		[Address(RVA = "0x5991B0", Offset = "0x5983B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700069F")]
	public Color ObjectBoxWireColor
	{
		[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C5")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4460", Offset = "0x3B3660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014C6")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700069A")]
	public Color ObjectPosTickColor
	{
		[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014BB")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014BC")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700069B")]
	public float ObjectPosTickSize
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014BD")]
		 get { } //Length: 6
		[Address(RVA = "0x5991C0", Offset = "0x5983C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014BE")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x599090", Offset = "0x598290", Length = "0xA1")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014C7")]
	public ObjectGrabLookAndFeel() { }

	[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B5")]
	public Color get_AnchorLineColor() { }

	[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014BF")]
	public Color get_AnchorPosTickColor() { }

	[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C1")]
	public float get_AnchorPosTickSize() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B3")]
	public bool get_DrawAnchorLines() { }

	[Address(RVA = "0x599150", Offset = "0x598350", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014B9")]
	public bool get_DrawAnchorPosTick() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C3")]
	public bool get_DrawObjectBoxes() { }

	[Address(RVA = "0x599160", Offset = "0x598360", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B7")]
	public bool get_DrawObjectPosTicks() { }

	[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C5")]
	public Color get_ObjectBoxWireColor() { }

	[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014BB")]
	public Color get_ObjectPosTickColor() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014BD")]
	public float get_ObjectPosTickSize() { }

	[Address(RVA = "0x599170", Offset = "0x598370", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B6")]
	public void set_AnchorLineColor(Color value) { }

	[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C0")]
	public void set_AnchorPosTickColor(Color value) { }

	[Address(RVA = "0x599180", Offset = "0x598380", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014C2")]
	public void set_AnchorPosTickSize(float value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B4")]
	public void set_DrawAnchorLines(bool value) { }

	[Address(RVA = "0x5991A0", Offset = "0x5983A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014BA")]
	public void set_DrawAnchorPosTick(bool value) { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C4")]
	public void set_DrawObjectBoxes(bool value) { }

	[Address(RVA = "0x5991B0", Offset = "0x5983B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B8")]
	public void set_DrawObjectPosTicks(bool value) { }

	[Address(RVA = "0x3B4460", Offset = "0x3B3660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014C6")]
	public void set_ObjectBoxWireColor(Color value) { }

	[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014BC")]
	public void set_ObjectPosTickColor(Color value) { }

	[Address(RVA = "0x5991C0", Offset = "0x5983C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014BE")]
	public void set_ObjectPosTickSize(float value) { }

}

