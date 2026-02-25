namespace RLD;

[Token(Token = "0x20000C3")]
public class GizmoLineSlider3DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000300")]
	private GizmoShadeMode _shadeMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000301")]
	private GizmoLine3DType _lineType; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000302")]
	private GizmoFillMode3D _fillMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000303")]
	private float _length; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000304")]
	private float _scale; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000305")]
	private bool _useZoomFactor; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000306")]
	private float _boxHeight; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000307")]
	private float _boxDepth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000308")]
	private float _cylinderRadius; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000309")]
	private bool _isRotationArcVisible; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400030A")]
	private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400030B")]
	private Color _color; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400030C")]
	private Color _hoveredColor; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400030D")]
	private GizmoCap3DLookAndFeel _capLookAndFeel; //Field offset: 0x60

	[Token(Token = "0x17000266")]
	public float BoxDepth
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000783")]
		 get { } //Length: 6
		[Address(RVA = "0x3B21E0", Offset = "0x3B13E0", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000784")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000265")]
	public float BoxHeight
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000781")]
		 get { } //Length: 6
		[Address(RVA = "0x3B21D0", Offset = "0x3B13D0", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000782")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000264")]
	public GizmoCap3DLookAndFeel CapLookAndFeel
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000780")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000268")]
	public Color Color
	{
		[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000787")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000788")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000267")]
	public float CylinderRadius
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000785")]
		 get { } //Length: 6
		[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000786")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700025E")]
	public GizmoFillMode3D FillMode
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000775")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000776")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000269")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000789")]
		 get { } //Length: 11
		[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600078A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000262")]
	public bool IsRotationArcVisible
	{
		[Address(RVA = "0x500BB0", Offset = "0x4FFDB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077D")]
		 get { } //Length: 5
		[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025F")]
	public float Length
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000777")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000778")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700025D")]
	public GizmoLine3DType LineType
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000773")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000774")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000263")]
	public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000260")]
	public float Scale
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000779")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077A")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700025C")]
	public GizmoShadeMode ShadeMode
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000771")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000772")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000261")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077B")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600077C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x500AC0", Offset = "0x4FFCC0", Length = "0xEC")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600078B")]
	public GizmoLineSlider3DLookAndFeel() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000783")]
	public float get_BoxDepth() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000781")]
	public float get_BoxHeight() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000780")]
	public GizmoCap3DLookAndFeel get_CapLookAndFeel() { }

	[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000787")]
	public Color get_Color() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000785")]
	public float get_CylinderRadius() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000775")]
	public GizmoFillMode3D get_FillMode() { }

	[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000789")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x500BB0", Offset = "0x4FFDB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077D")]
	public bool get_IsRotationArcVisible() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000777")]
	public float get_Length() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000773")]
	public GizmoLine3DType get_LineType() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077F")]
	public GizmoRotationArc3DLookAndFeel get_RotationArcLookAndFeel() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000779")]
	public float get_Scale() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000771")]
	public GizmoShadeMode get_ShadeMode() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077B")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x3B21E0", Offset = "0x3B13E0", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000784")]
	public void set_BoxDepth(float value) { }

	[Address(RVA = "0x3B21D0", Offset = "0x3B13D0", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000782")]
	public void set_BoxHeight(float value) { }

	[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000788")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000786")]
	public void set_CylinderRadius(float value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000776")]
	public void set_FillMode(GizmoFillMode3D value) { }

	[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078A")]
	public void set_HoveredColor(Color value) { }

	[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077E")]
	public void set_IsRotationArcVisible(bool value) { }

	[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000778")]
	public void set_Length(float value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000774")]
	public void set_LineType(GizmoLine3DType value) { }

	[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077A")]
	public void set_Scale(float value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000772")]
	public void set_ShadeMode(GizmoShadeMode value) { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077C")]
	public void set_UseZoomFactor(bool value) { }

}

