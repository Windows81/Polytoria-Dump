namespace RLD;

[Token(Token = "0x2000231")]
public class ObjectGridSnapLookAndFeel : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000895")]
	private PivotPointShapeType _pivotShapeType; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000896")]
	private Color _pivotPointFillColor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000897")]
	private Color _pivotPointBorderColor; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000898")]
	private float _pivotCircleRadius; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000899")]
	private float _pivotSquareSideLength; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400089A")]
	private bool _drawPivotBorder; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400089B")]
	private Color _boxLineColor; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400089C")]
	private bool _drawBoxes; //Field offset: 0x68

	[Token(Token = "0x170006B8")]
	public Color BoxLineColor
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001516")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001517")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170006B9")]
	public bool DrawBoxes
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001518")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001519")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006B7")]
	public bool DrawPivotBorder
	{
		[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001514")]
		 get { } //Length: 5
		[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001515")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006B5")]
	public float PivotCircleRadius
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001510")]
		 get { } //Length: 6
		[Address(RVA = "0x599540", Offset = "0x598740", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001511")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170006B4")]
	public Color PivotPointBorderColor
	{
		[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600150E")]
		 get { } //Length: 11
		[Address(RVA = "0x599560", Offset = "0x598760", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600150F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170006B3")]
	public Color PivotPointFillColor
	{
		[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600150C")]
		 get { } //Length: 11
		[Address(RVA = "0x599170", Offset = "0x598370", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600150D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170006B2")]
	public PivotPointShapeType PivotShapeType
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600150A")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600150B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006B6")]
	public float PivotSquareSideLength
	{
		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001512")]
		 get { } //Length: 6
		[Address(RVA = "0x599570", Offset = "0x598770", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001513")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x5994E0", Offset = "0x5986E0", Length = "0x48")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600151A")]
	public ObjectGridSnapLookAndFeel() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001516")]
	public Color get_BoxLineColor() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001518")]
	public bool get_DrawBoxes() { }

	[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001514")]
	public bool get_DrawPivotBorder() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001510")]
	public float get_PivotCircleRadius() { }

	[Address(RVA = "0x599530", Offset = "0x598730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150E")]
	public Color get_PivotPointBorderColor() { }

	[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150C")]
	public Color get_PivotPointFillColor() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150A")]
	public PivotPointShapeType get_PivotShapeType() { }

	[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001512")]
	public float get_PivotSquareSideLength() { }

	[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001517")]
	public void set_BoxLineColor(Color value) { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001519")]
	public void set_DrawBoxes(bool value) { }

	[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001515")]
	public void set_DrawPivotBorder(bool value) { }

	[Address(RVA = "0x599540", Offset = "0x598740", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001511")]
	public void set_PivotCircleRadius(float value) { }

	[Address(RVA = "0x599560", Offset = "0x598760", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150F")]
	public void set_PivotPointBorderColor(Color value) { }

	[Address(RVA = "0x599170", Offset = "0x598370", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150D")]
	public void set_PivotPointFillColor(Color value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150B")]
	public void set_PivotShapeType(PivotPointShapeType value) { }

	[Address(RVA = "0x599570", Offset = "0x598770", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001513")]
	public void set_PivotSquareSideLength(float value) { }

}

