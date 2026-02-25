namespace RLD;

[Token(Token = "0x20000B1")]
public class GizmoPlaneSlider2DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40002B3")]
	private GizmoFillMode2D _fillMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40002B4")]
	private GizmoPlane2DType _planeType; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40002B5")]
	private float _scale; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40002B6")]
	private float _quadWidth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40002B7")]
	private float _quadHeight; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40002B8")]
	private float _circleRadius; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40002B9")]
	private bool _isRotationArcVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40002BA")]
	private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40002BB")]
	private Color _color; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40002BC")]
	private Color _hoveredColor; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40002BD")]
	private Color _borderColor; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40002BE")]
	private Color _hoveredBorderColor; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40002BF")]
	private GizmoQuad2DBorderType _quadBorderType; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40002C0")]
	private GizmoCircle2DBorderType _circleBorderType; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40002C1")]
	private GizmoPolygon2DBorderType _polygonBorderType; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x40002C2")]
	private float _borderPolyThickness; //Field offset: 0x84

	[Token(Token = "0x1700022F")]
	public Color BorderColor
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C9")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CA")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000234")]
	public float BorderPolyThickness
	{
		[Address(RVA = "0x504710", Offset = "0x503910", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D3")]
		 get { } //Length: 9
		[Address(RVA = "0x504730", Offset = "0x503930", Length = "0x12")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D4")]
		 set { } //Length: 18
	}

	[Token(Token = "0x17000232")]
	public GizmoCircle2DBorderType CircleBorderType
	{
		[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CF")]
		 get { } //Length: 4
		[Address(RVA = "0x504750", Offset = "0x503950", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700022A")]
	public float CircleRadius
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C0")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2230", Offset = "0x3B1430", Length = "0xF")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C1")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700022D")]
	public Color Color
	{
		[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C5")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C6")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000225")]
	public GizmoFillMode2D FillMode
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B6")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000230")]
	public Color HoveredBorderColor
	{
		[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CB")]
		 get { } //Length: 11
		[Address(RVA = "0x504760", Offset = "0x503960", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CC")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700022E")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C7")]
		 get { } //Length: 11
		[Address(RVA = "0x3E3CA0", Offset = "0x3E2EA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C8")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700022B")]
	public bool IsRotationArcVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000226")]
	public GizmoPlane2DType PlaneType
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000233")]
	public GizmoPolygon2DBorderType PolygonBorderType
	{
		[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D1")]
		 get { } //Length: 7
		[Address(RVA = "0x504770", Offset = "0x503970", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006D2")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000231")]
	public GizmoQuad2DBorderType QuadBorderType
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CD")]
		 get { } //Length: 4
		[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000229")]
	public float QuadHeight
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BE")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BF")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000228")]
	public float QuadWidth
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BD")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700022C")]
	public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C4")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000227")]
	public float Scale
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BA")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BB")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x504630", Offset = "0x503830", Length = "0xD5")]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006D5")]
	public GizmoPlaneSlider2DLookAndFeel() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C9")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x504710", Offset = "0x503910", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D3")]
	public float get_BorderPolyThickness() { }

	[Address(RVA = "0x3B8650", Offset = "0x3B7850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CF")]
	public GizmoCircle2DBorderType get_CircleBorderType() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C0")]
	public float get_CircleRadius() { }

	[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C5")]
	public Color get_Color() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B6")]
	public GizmoFillMode2D get_FillMode() { }

	[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CB")]
	public Color get_HoveredBorderColor() { }

	[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C7")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C2")]
	public bool get_IsRotationArcVisible() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B8")]
	public GizmoPlane2DType get_PlaneType() { }

	[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D1")]
	public GizmoPolygon2DBorderType get_PolygonBorderType() { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CD")]
	public GizmoQuad2DBorderType get_QuadBorderType() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BE")]
	public float get_QuadHeight() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BC")]
	public float get_QuadWidth() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C4")]
	public GizmoRotationArc2DLookAndFeel get_RotationArcLookAndFeel() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BA")]
	public float get_Scale() { }

	[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CA")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x504730", Offset = "0x503930", Length = "0x12")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D4")]
	public void set_BorderPolyThickness(float value) { }

	[Address(RVA = "0x504750", Offset = "0x503950", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D0")]
	public void set_CircleBorderType(GizmoCircle2DBorderType value) { }

	[Address(RVA = "0x3B2230", Offset = "0x3B1430", Length = "0xF")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C1")]
	public void set_CircleRadius(float value) { }

	[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C6")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B7")]
	public void set_FillMode(GizmoFillMode2D value) { }

	[Address(RVA = "0x504760", Offset = "0x503960", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CC")]
	public void set_HoveredBorderColor(Color value) { }

	[Address(RVA = "0x3E3CA0", Offset = "0x3E2EA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C8")]
	public void set_HoveredColor(Color value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C3")]
	public void set_IsRotationArcVisible(bool value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B9")]
	public void set_PlaneType(GizmoPlane2DType value) { }

	[Address(RVA = "0x504770", Offset = "0x503970", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006D2")]
	public void set_PolygonBorderType(GizmoPolygon2DBorderType value) { }

	[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CE")]
	public void set_QuadBorderType(GizmoQuad2DBorderType value) { }

	[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BF")]
	public void set_QuadHeight(float value) { }

	[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BD")]
	public void set_QuadWidth(float value) { }

	[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BB")]
	public void set_Scale(float value) { }

}

