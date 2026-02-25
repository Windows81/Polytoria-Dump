namespace RLD;

[Token(Token = "0x20000A8")]
public class GizmoLineSlider2DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000271")]
	private GizmoLine2DType _lineType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000272")]
	private GizmoFillMode2D _fillMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000273")]
	private float _length; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000274")]
	private float _scale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000275")]
	private float _boxThickness; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000276")]
	private bool _isRotationArcVisible; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000277")]
	private Color _color; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000278")]
	private Color _hoveredColor; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000279")]
	private Color _borderColor; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400027A")]
	private Color _hoveredBorderColor; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400027B")]
	private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400027C")]
	private GizmoCap2DLookAndFeel _capLookAndFeel; //Field offset: 0x70

	[Token(Token = "0x170001FC")]
	public Color BorderColor
	{
		[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064D")]
		 get { } //Length: 11
		[Address(RVA = "0x3E3CA0", Offset = "0x3E2EA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001F8")]
	public float BoxThickness
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000645")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000646")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170001F7")]
	public GizmoCap2DLookAndFeel CapLookAndFeel
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000644")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FA")]
	public Color Color
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000649")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001F4")]
	public GizmoFillMode2D FillMode
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063E")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001FD")]
	public Color HoveredBorderColor
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064F")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000650")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001FB")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064B")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001F9")]
	public bool IsRotationArcVisible
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000647")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000648")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001F5")]
	public float Length
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000640")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000641")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170001F3")]
	public GizmoLine2DType LineType
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063C")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001FE")]
	public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000651")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001F6")]
	public float Scale
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000642")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000643")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x4FC9B0", Offset = "0x4FBBB0", Length = "0xF2")]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000652")]
	public GizmoLineSlider2DLookAndFeel() { }

	[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064D")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000645")]
	public float get_BoxThickness() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000644")]
	public GizmoCap2DLookAndFeel get_CapLookAndFeel() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000649")]
	public Color get_Color() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063E")]
	public GizmoFillMode2D get_FillMode() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064F")]
	public Color get_HoveredBorderColor() { }

	[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064B")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000647")]
	public bool get_IsRotationArcVisible() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000640")]
	public float get_Length() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063C")]
	public GizmoLine2DType get_LineType() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000651")]
	public GizmoRotationArc2DLookAndFeel get_RotationArcLookAndFeel() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000642")]
	public float get_Scale() { }

	[Address(RVA = "0x3E3CA0", Offset = "0x3E2EA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064E")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000646")]
	public void set_BoxThickness(float value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064A")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063F")]
	public void set_FillMode(GizmoFillMode2D value) { }

	[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000650")]
	public void set_HoveredBorderColor(Color value) { }

	[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064C")]
	public void set_HoveredColor(Color value) { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000648")]
	public void set_IsRotationArcVisible(bool value) { }

	[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000641")]
	public void set_Length(float value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063D")]
	public void set_LineType(GizmoLine2DType value) { }

	[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000643")]
	public void set_Scale(float value) { }

}

