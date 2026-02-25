namespace RLD;

[Token(Token = "0x2000236")]
public class ObjectLayerGrabSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40008AA")]
	private int _layer; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40008AB")]
	private bool _isActive; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	[Token(Token = "0x40008AC")]
	private bool _alignAxis; //Field offset: 0x15
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40008AD")]
	private TransformAxis _alignmentAxis; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40008AE")]
	private float _defaultOffsetFromSurface; //Field offset: 0x1C

	[Token(Token = "0x170006BF")]
	public bool AlignAxis
	{
		[Address(RVA = "0x59AFF0", Offset = "0x59A1F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001539")]
		 get { } //Length: 5
		[Address(RVA = "0x59B010", Offset = "0x59A210", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600153A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006C0")]
	public TransformAxis AlignmentAxis
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600153B")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600153C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006C1")]
	public float DefaultOffsetFromSurface
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600153D")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600153E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170006BE")]
	public bool IsActive
	{
		[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001537")]
		 get { } //Length: 5
		[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001538")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006BD")]
	public int Layer
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001536")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x59AFC0", Offset = "0x59A1C0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600153F")]
	public ObjectLayerGrabSettings(int layer) { }

	[Address(RVA = "0x59AFF0", Offset = "0x59A1F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001539")]
	public bool get_AlignAxis() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600153B")]
	public TransformAxis get_AlignmentAxis() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600153D")]
	public float get_DefaultOffsetFromSurface() { }

	[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001537")]
	public bool get_IsActive() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001536")]
	public int get_Layer() { }

	[Address(RVA = "0x59B010", Offset = "0x59A210", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600153A")]
	public void set_AlignAxis(bool value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600153C")]
	public void set_AlignmentAxis(TransformAxis value) { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600153E")]
	public void set_DefaultOffsetFromSurface(float value) { }

	[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001538")]
	public void set_IsActive(bool value) { }

}

