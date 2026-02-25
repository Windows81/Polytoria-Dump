namespace RLD;

[Token(Token = "0x2000017")]
public class GizmoCap2DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000052")]
	private GizmoFillMode2D _fillMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000053")]
	private GizmoCap2DType _capType; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000054")]
	private float _scale; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000055")]
	private float _circleRadius; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000056")]
	private float _quadWidth; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000057")]
	private float _quadHeight; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000058")]
	private float _arrowBaseRadius; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000059")]
	private float _arrowHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400005A")]
	private Color _color; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400005B")]
	private Color _hoveredColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400005C")]
	private Color _borderColor; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400005D")]
	private Color _hoveredBorderColor; //Field offset: 0x60

	[Token(Token = "0x1700001B")]
	public float ArrowBaseRadius
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000096")]
		 get { } //Length: 6
		[Address(RVA = "0x3B21D0", Offset = "0x3B13D0", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700001C")]
	public float ArrowHeight
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000098")]
		 get { } //Length: 6
		[Address(RVA = "0x3B21E0", Offset = "0x3B13E0", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700001F")]
	public Color BorderColor
	{
		[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		 get { } //Length: 11
		[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000016")]
	public GizmoCap2DType CapType
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public float CircleRadius
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000090")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000091")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700001D")]
	public Color Color
	{
		[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2200", Offset = "0x3B1400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000015")]
	public GizmoFillMode2D FillMode
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008A")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public Color HoveredBorderColor
	{
		[Address(RVA = "0x3B2190", Offset = "0x3B1390", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2210", Offset = "0x3B1410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001E")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009C")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001A")]
	public float QuadHeight
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000094")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2230", Offset = "0x3B1430", Length = "0xF")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000095")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000019")]
	public float QuadWidth
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000092")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000093")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000017")]
	public float Scale
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008E")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x3B20B0", Offset = "0x3B12B0", Length = "0x87")]
	[CalledBy(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	public GizmoCap2DLookAndFeel() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000096")]
	public float get_ArrowBaseRadius() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000098")]
	public float get_ArrowHeight() { }

	[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009E")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public GizmoCap2DType get_CapType() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000090")]
	public float get_CircleRadius() { }

	[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009A")]
	public Color get_Color() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008A")]
	public GizmoFillMode2D get_FillMode() { }

	[Address(RVA = "0x3B2190", Offset = "0x3B1390", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A0")]
	public Color get_HoveredBorderColor() { }

	[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009C")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000094")]
	public float get_QuadHeight() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000092")]
	public float get_QuadWidth() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008E")]
	public float get_Scale() { }

	[Address(RVA = "0x3B21D0", Offset = "0x3B13D0", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	public void set_ArrowBaseRadius(float value) { }

	[Address(RVA = "0x3B21E0", Offset = "0x3B13E0", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000099")]
	public void set_ArrowHeight(float value) { }

	[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009F")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public void set_CapType(GizmoCap2DType value) { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	public void set_CircleRadius(float value) { }

	[Address(RVA = "0x3B2200", Offset = "0x3B1400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009B")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	public void set_FillMode(GizmoFillMode2D value) { }

	[Address(RVA = "0x3B2210", Offset = "0x3B1410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public void set_HoveredBorderColor(Color value) { }

	[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009D")]
	public void set_HoveredColor(Color value) { }

	[Address(RVA = "0x3B2230", Offset = "0x3B1430", Length = "0xF")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000095")]
	public void set_QuadHeight(float value) { }

	[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000093")]
	public void set_QuadWidth(float value) { }

	[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	public void set_Scale(float value) { }

}

