namespace RLD;

[Token(Token = "0x2000119")]
public class UniversalGizmoLookAndFeel3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000502")]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000503")]
	private GizmoCap2DLookAndFeel _mvVertSnapCapLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000504")]
	private Boolean[] _mvSglSliderVis; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000505")]
	private Boolean[] _mvSglSliderCapVis; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000506")]
	private Boolean[] _mvDblSliderVis; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000507")]
	private GizmoLineSlider3DLookAndFeel[] _mvSglSlidersLookAndFeel; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000508")]
	private GizmoPlaneSlider3DLookAndFeel[] _mvDblSlidersLookAndFeel; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000509")]
	private bool _isRtMidCapVisible; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400050A")]
	private GizmoCap3DLookAndFeel _rtMidCapLookAndFeel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400050B")]
	private Boolean[] _rtAxesVis; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400050C")]
	private GizmoPlaneSlider3DLookAndFeel[] _rtAxesLookAndFeel; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400050D")]
	private bool _isRtCamLookSliderVisible; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x400050E")]
	private float _rtCamLookSliderRadiusOffset; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x400050F")]
	private GizmoPlaneSlider2DLookAndFeel _rtCamLookSliderLookAndFeel; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000510")]
	private GizmoCap3DLookAndFeel _scMidCapLookAndFeel; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000511")]
	private Boolean[] _scSglSliderVis; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000512")]
	private Boolean[] _scSglSliderCapVis; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000513")]
	private Boolean[] _scDblSliderVis; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000514")]
	private bool _isScMidCapVisible; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000515")]
	private GizmoScaleGuideLookAndFeel _scScaleGuideLookAndFeel; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000516")]
	private bool _isScScaleGuideVisible; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000517")]
	private GizmoLineSlider3DLookAndFeel[] _scSglSlidersLookAndFeel; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000518")]
	private GizmoPlaneSlider3DLookAndFeel[] _scDblSlidersLookAndFeel; //Field offset: 0xD0

	[Token(Token = "0x1700047B")]
	public UniversalGizmoSettingsCategory DisplayCategory
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC0")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CC1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700044E")]
	public bool IsRtCamLookSliderVisible
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C93")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000448")]
	public bool IsRtMidCapBorderVisible
	{
		[Address(RVA = "0x5323E0", Offset = "0x5315E0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C8D")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000447")]
	public bool IsRtMidCapVisible
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C8C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000444")]
	public bool IsRtRotationArcVisible
	{
		[Address(RVA = "0x532400", Offset = "0x531600", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C89")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000476")]
	public bool IsScMidCapVisible
	{
		[Address(RVA = "0x532440", Offset = "0x531640", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CBB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000479")]
	public bool IsScScaleGuideVisible
	{
		[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CBE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000407")]
	public float MvBoxSliderDepth
	{
		[Address(RVA = "0x532460", Offset = "0x531660", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C4C")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000406")]
	public float MvBoxSliderHeight
	{
		[Address(RVA = "0x5324A0", Offset = "0x5316A0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C4B")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000408")]
	public float MvCylinderSliderRadius
	{
		[Address(RVA = "0x5324E0", Offset = "0x5316E0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C4D")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000423")]
	public float MvDblSliderBorderBoxDepth
	{
		[Address(RVA = "0x532520", Offset = "0x531720", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C68")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000422")]
	public float MvDblSliderBorderBoxHeight
	{
		[Address(RVA = "0x518B10", Offset = "0x517D10", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C67")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000427")]
	public GizmoFillMode3D MvDblSliderBorderFillMode
	{
		[Address(RVA = "0x532560", Offset = "0x531760", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C6C")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000425")]
	public GizmoShadeMode MvDblSliderBorderShadeMode
	{
		[Address(RVA = "0x5325A0", Offset = "0x5317A0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C6A")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000426")]
	public GizmoQuad3DBorderType MvDblSliderBorderType
	{
		[Address(RVA = "0x5325E0", Offset = "0x5317E0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C6B")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000424")]
	public float MvDblSliderFillAlpha
	{
		[Address(RVA = "0x532620", Offset = "0x531820", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C69")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000421")]
	public float MvDblSliderSize
	{
		[Address(RVA = "0x5190B0", Offset = "0x5182B0", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C66")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000431")]
	public Color MvHoveredColor
	{
		[Address(RVA = "0x532660", Offset = "0x531860", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C76")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700041C")]
	public Color MvNXColor
	{
		[Address(RVA = "0x5326A0", Offset = "0x5318A0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C61")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700041E")]
	public Color MvNYColor
	{
		[Address(RVA = "0x5326E0", Offset = "0x5318E0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C63")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000420")]
	public Color MvNZColor
	{
		[Address(RVA = "0x532720", Offset = "0x531920", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C65")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700041B")]
	public Color MvPXColor
	{
		[Address(RVA = "0x532760", Offset = "0x531960", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C60")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700041D")]
	public Color MvPYColor
	{
		[Address(RVA = "0x5327A0", Offset = "0x5319A0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C62")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700041F")]
	public Color MvPZColor
	{
		[Address(RVA = "0x5327E0", Offset = "0x5319E0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C64")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000403")]
	public float MvScale
	{
		[Address(RVA = "0x532820", Offset = "0x531A20", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C48")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700040B")]
	public float MvSliderBoxCapDepth
	{
		[Address(RVA = "0x532860", Offset = "0x531A60", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C50")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700040A")]
	public float MvSliderBoxCapHeight
	{
		[Address(RVA = "0x5328A0", Offset = "0x531AA0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C4F")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000409")]
	public float MvSliderBoxCapWidth
	{
		[Address(RVA = "0x5328E0", Offset = "0x531AE0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C4E")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000416")]
	public GizmoFillMode3D MvSliderCapFillMode
	{
		[Address(RVA = "0x532920", Offset = "0x531B20", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C5B")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000419")]
	public GizmoShadeMode MvSliderCapShadeMode
	{
		[Address(RVA = "0x532960", Offset = "0x531B60", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C5E")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000417")]
	public GizmoCap3DType MvSliderCapType
	{
		[Address(RVA = "0x5329A0", Offset = "0x531BA0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C5C")]
		 get { } //Length: 56
	}

	[Token(Token = "0x1700040D")]
	public float MvSliderConeCapBaseRadius
	{
		[Address(RVA = "0x5329E0", Offset = "0x531BE0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C52")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700040C")]
	public float MvSliderConeCapHeight
	{
		[Address(RVA = "0x532A20", Offset = "0x531C20", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C51")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000415")]
	public GizmoFillMode3D MvSliderFillMode
	{
		[Address(RVA = "0x532A60", Offset = "0x531C60", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C5A")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000405")]
	public float MvSliderLength
	{
		[Address(RVA = "0x532A90", Offset = "0x531C90", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C4A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700041A")]
	public GizmoLine3DType MvSliderLineType
	{
		[Address(RVA = "0x532AD0", Offset = "0x531CD0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C5F")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000410")]
	public float MvSliderPyramidCapDepth
	{
		[Address(RVA = "0x532B00", Offset = "0x531D00", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C55")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700040F")]
	public float MvSliderPyramidCapHeight
	{
		[Address(RVA = "0x532B40", Offset = "0x531D40", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C54")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700040E")]
	public float MvSliderPyramidCapWidth
	{
		[Address(RVA = "0x532B80", Offset = "0x531D80", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C53")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000418")]
	public GizmoShadeMode MvSliderShadeMode
	{
		[Address(RVA = "0x532BC0", Offset = "0x531DC0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C5D")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000414")]
	public float MvSliderSphereCapRadius
	{
		[Address(RVA = "0x532BF0", Offset = "0x531DF0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C59")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000413")]
	public float MvSliderTriPrismCapDepth
	{
		[Address(RVA = "0x532C30", Offset = "0x531E30", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C58")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000412")]
	public float MvSliderTriPrismCapHeight
	{
		[Address(RVA = "0x532C70", Offset = "0x531E70", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C57")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000411")]
	public float MvSliderTriPrismCapWidth
	{
		[Address(RVA = "0x532CB0", Offset = "0x531EB0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C56")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000404")]
	public bool MvUseZoomFactor
	{
		[Address(RVA = "0x532CF0", Offset = "0x531EF0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C49")]
		 get { } //Length: 48
	}

	[Token(Token = "0x1700042C")]
	public Color MvVertSnapCapBorderColor
	{
		[Address(RVA = "0x532D30", Offset = "0x531F30", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C71")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700042A")]
	public float MvVertSnapCapCircleRadius
	{
		[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C6F")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700042B")]
	public Color MvVertSnapCapColor
	{
		[Address(RVA = "0x532D60", Offset = "0x531F60", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C70")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700042F")]
	public GizmoFillMode2D MvVertSnapCapFillMode
	{
		[Address(RVA = "0x518E40", Offset = "0x518040", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C74")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700042E")]
	public Color MvVertSnapCapHoveredBorderColor
	{
		[Address(RVA = "0x532D90", Offset = "0x531F90", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C73")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700042D")]
	public Color MvVertSnapCapHoveredColor
	{
		[Address(RVA = "0x532DC0", Offset = "0x531FC0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C72")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000429")]
	public float MvVertSnapCapQuadHeight
	{
		[Address(RVA = "0x52A530", Offset = "0x529730", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C6E")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000428")]
	public float MvVertSnapCapQuadWidth
	{
		[Address(RVA = "0x52A5E0", Offset = "0x5297E0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C6D")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000430")]
	public GizmoCap2DType MvVertSnapCapType
	{
		[Address(RVA = "0x518DE0", Offset = "0x517FE0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C75")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700043F")]
	public GizmoFillMode3D RtAxisBorderFillMode
	{
		[Address(RVA = "0x532DF0", Offset = "0x531FF0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C84")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700043E")]
	public GizmoCircle3DBorderType RtAxisBorderType
	{
		[Address(RVA = "0x532E30", Offset = "0x532030", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C83")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700043C")]
	public float RtAxisCullAlphaScale
	{
		[Address(RVA = "0x532E70", Offset = "0x532070", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C81")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700043B")]
	public float RtAxisCylTorusHeight
	{
		[Address(RVA = "0x532EB0", Offset = "0x5320B0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C80")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700043A")]
	public float RtAxisCylTorusWidth
	{
		[Address(RVA = "0x532EF0", Offset = "0x5320F0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C7F")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000439")]
	public float RtAxisTorusThickness
	{
		[Address(RVA = "0x532F30", Offset = "0x532130", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C7E")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700044A")]
	public Color RtCamLookSliderBorderColor
	{
		[Address(RVA = "0x532F70", Offset = "0x532170", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C8F")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700044B")]
	public Color RtCamLookSliderHoveredBorderColor
	{
		[Address(RVA = "0x532FA0", Offset = "0x5321A0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C90")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700044D")]
	public float RtCamLookSliderPolyBorderThickness
	{
		[Address(RVA = "0x532FD0", Offset = "0x5321D0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C92")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700044C")]
	public GizmoPolygon2DBorderType RtCamLookSliderPolyBorderType
	{
		[Address(RVA = "0x533000", Offset = "0x532200", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C91")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000449")]
	public float RtCamLookSliderRadiusOffset
	{
		[Address(RVA = "0x504710", Offset = "0x503910", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C8E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000438")]
	public Color RtHoveredColor
	{
		[Address(RVA = "0x533030", Offset = "0x532230", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C7D")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000446")]
	public Color RtHoveredMidCapColor
	{
		[Address(RVA = "0x533070", Offset = "0x532270", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C8B")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000445")]
	public Color RtMidCapColor
	{
		[Address(RVA = "0x5330A0", Offset = "0x5322A0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C8A")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000440")]
	public int RtNumAxisTorusWireAxialSlices
	{
		[Address(RVA = "0x5330D0", Offset = "0x5322D0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C85")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000433")]
	public float RtRadius
	{
		[Address(RVA = "0x533100", Offset = "0x532300", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C78")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000442")]
	public Color RtRotationArcBorderColor
	{
		[Address(RVA = "0x533120", Offset = "0x532320", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C87")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000441")]
	public Color RtRotationArcColor
	{
		[Address(RVA = "0x533170", Offset = "0x532370", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C86")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000432")]
	public float RtScale
	{
		[Address(RVA = "0x5331C0", Offset = "0x5323C0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C77")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700043D")]
	public GizmoShadeMode RtShadeMode
	{
		[Address(RVA = "0x5331E0", Offset = "0x5323E0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C82")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000443")]
	public bool RtUseShortestRotationArc
	{
		[Address(RVA = "0x533200", Offset = "0x532400", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C88")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000434")]
	public bool RtUseZoomFactor
	{
		[Address(RVA = "0x533240", Offset = "0x532440", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C79")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000435")]
	public Color RtXBorderColor
	{
		[Address(RVA = "0x533260", Offset = "0x532460", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C7A")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000436")]
	public Color RtYBorderColor
	{
		[Address(RVA = "0x5332A0", Offset = "0x5324A0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C7B")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000437")]
	public Color RtZBorderColor
	{
		[Address(RVA = "0x5332E0", Offset = "0x5324E0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C7C")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000453")]
	public float ScBoxSliderDepth
	{
		[Address(RVA = "0x533320", Offset = "0x532520", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C98")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000452")]
	public float ScBoxSliderHeight
	{
		[Address(RVA = "0x533360", Offset = "0x532560", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000454")]
	public float ScCylinderSliderRadius
	{
		[Address(RVA = "0x5333A0", Offset = "0x5325A0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C99")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700046E")]
	public float ScDblSliderFillAlpha
	{
		[Address(RVA = "0x5333E0", Offset = "0x5325E0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CB3")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700046D")]
	public float ScDblSliderSize
	{
		[Address(RVA = "0x533420", Offset = "0x532620", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CB2")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000478")]
	public Color ScHoveredColor
	{
		[Address(RVA = "0x533460", Offset = "0x532660", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CBD")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000471")]
	public float ScMidCapBoxDepth
	{
		[Address(RVA = "0x5334A0", Offset = "0x5326A0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CB6")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000470")]
	public float ScMidCapBoxHeight
	{
		[Address(RVA = "0x5334C0", Offset = "0x5326C0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CB5")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700046F")]
	public float ScMidCapBoxWidth
	{
		[Address(RVA = "0x5334E0", Offset = "0x5326E0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CB4")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000477")]
	public Color ScMidCapColor
	{
		[Address(RVA = "0x533500", Offset = "0x532700", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CBC")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000475")]
	public GizmoFillMode3D ScMidCapFillMode
	{
		[Address(RVA = "0x533530", Offset = "0x532730", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CBA")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000474")]
	public GizmoShadeMode ScMidCapShadeMode
	{
		[Address(RVA = "0x533550", Offset = "0x532750", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CB9")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000472")]
	public float ScMidCapSphereRadius
	{
		[Address(RVA = "0x533570", Offset = "0x532770", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CB7")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000473")]
	public GizmoCap3DType ScMidCapType
	{
		[Address(RVA = "0x533590", Offset = "0x532790", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CB8")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000468")]
	public Color ScNXColor
	{
		[Address(RVA = "0x5335B0", Offset = "0x5327B0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CAD")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700046A")]
	public Color ScNYColor
	{
		[Address(RVA = "0x5335F0", Offset = "0x5327F0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CAF")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700046C")]
	public Color ScNZColor
	{
		[Address(RVA = "0x533630", Offset = "0x532830", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CB1")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000467")]
	public Color ScPXColor
	{
		[Address(RVA = "0x533670", Offset = "0x532870", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CAC")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000469")]
	public Color ScPYColor
	{
		[Address(RVA = "0x5336B0", Offset = "0x5328B0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CAE")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700046B")]
	public Color ScPZColor
	{
		[Address(RVA = "0x5336F0", Offset = "0x5328F0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CB0")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700044F")]
	public float ScScale
	{
		[Address(RVA = "0x533750", Offset = "0x532950", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C94")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700047A")]
	public float ScScaleGuideAxisLength
	{
		[Address(RVA = "0x533730", Offset = "0x532930", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CBF")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000457")]
	public float ScSliderBoxCapDepth
	{
		[Address(RVA = "0x533770", Offset = "0x532970", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C9C")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000456")]
	public float ScSliderBoxCapHeight
	{
		[Address(RVA = "0x5337B0", Offset = "0x5329B0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C9B")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000455")]
	public float ScSliderBoxCapWidth
	{
		[Address(RVA = "0x5337F0", Offset = "0x5329F0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C9A")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000462")]
	public GizmoFillMode3D ScSliderCapFillMode
	{
		[Address(RVA = "0x533830", Offset = "0x532A30", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA7")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000465")]
	public GizmoShadeMode ScSliderCapShadeMode
	{
		[Address(RVA = "0x533870", Offset = "0x532A70", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CAA")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000463")]
	public GizmoCap3DType ScSliderCapType
	{
		[Address(RVA = "0x5338B0", Offset = "0x532AB0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA8")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000459")]
	public float ScSliderConeCapBaseRadius
	{
		[Address(RVA = "0x5338F0", Offset = "0x532AF0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C9E")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000458")]
	public float ScSliderConeCapHeight
	{
		[Address(RVA = "0x533930", Offset = "0x532B30", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C9D")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000461")]
	public GizmoFillMode3D ScSliderFillMode
	{
		[Address(RVA = "0x533970", Offset = "0x532B70", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA6")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000451")]
	public float ScSliderLength
	{
		[Address(RVA = "0x5339B0", Offset = "0x532BB0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C96")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000466")]
	public GizmoLine3DType ScSliderLineType
	{
		[Address(RVA = "0x5339F0", Offset = "0x532BF0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CAB")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700045C")]
	public float ScSliderPyramidCapDepth
	{
		[Address(RVA = "0x533A30", Offset = "0x532C30", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA1")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700045B")]
	public float ScSliderPyramidCapHeight
	{
		[Address(RVA = "0x533A70", Offset = "0x532C70", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA0")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700045A")]
	public float ScSliderPyramidCapWidth
	{
		[Address(RVA = "0x533AB0", Offset = "0x532CB0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C9F")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000464")]
	public GizmoShadeMode ScSliderShadeMode
	{
		[Address(RVA = "0x533AF0", Offset = "0x532CF0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA9")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000460")]
	public float ScSliderSphereCapRadius
	{
		[Address(RVA = "0x533B30", Offset = "0x532D30", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA5")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700045F")]
	public float ScSliderTriPrismCapDepth
	{
		[Address(RVA = "0x533B70", Offset = "0x532D70", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700045E")]
	public float ScSliderTriPrismCapHeight
	{
		[Address(RVA = "0x533BB0", Offset = "0x532DB0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA3")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700045D")]
	public float ScSliderTriPrismCapWidth
	{
		[Address(RVA = "0x533BF0", Offset = "0x532DF0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000CA2")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000450")]
	public bool ScUseZoomFactor
	{
		[Address(RVA = "0x533C30", Offset = "0x532E30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C95")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x531060", Offset = "0x530260", Length = "0x1370")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvHoveredColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_AxisAlpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvDblSliderFillAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_NumBorderTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_CenterAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScDblSliderFillAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScHoveredColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Token(Token = "0x6000CC2")]
	public UniversalGizmoLookAndFeel3D() { }

	[Address(RVA = "0x52A9B0", Offset = "0x529BB0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CFE")]
	public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	[Address(RVA = "0x52AA00", Offset = "0x529C00", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CFD")]
	public void ConnectMvSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x52AA60", Offset = "0x529C60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFF")]
	public void ConnectMvVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap) { }

	[Address(RVA = "0x52AA90", Offset = "0x529C90", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D23")]
	public void ConnectRtCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x52AAC0", Offset = "0x529CC0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D22")]
	public void ConnectRtMidCapLookAndFeel(GizmoCap3D cap) { }

	[Address(RVA = "0x52AAF0", Offset = "0x529CF0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D21")]
	public void ConnectRtSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex) { }

	[Address(RVA = "0x52AB40", Offset = "0x529D40", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D5E")]
	public void ConnectScDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId) { }

	[Address(RVA = "0x52AB90", Offset = "0x529D90", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D5F")]
	public void ConnectScGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide) { }

	[Address(RVA = "0x52ABC0", Offset = "0x529DC0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D5D")]
	public void ConnectScMidCapLookAndFeel(GizmoCap3D cap) { }

	[Address(RVA = "0x52ABF0", Offset = "0x529DF0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D5C")]
	public void ConnectScSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC0")]
	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C93")]
	public bool get_IsRtCamLookSliderVisible() { }

	[Address(RVA = "0x5323E0", Offset = "0x5315E0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C8D")]
	public bool get_IsRtMidCapBorderVisible() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C8C")]
	public bool get_IsRtMidCapVisible() { }

	[Address(RVA = "0x532400", Offset = "0x531600", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C89")]
	public bool get_IsRtRotationArcVisible() { }

	[Address(RVA = "0x532440", Offset = "0x531640", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBB")]
	public bool get_IsScMidCapVisible() { }

	[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CBE")]
	public bool get_IsScScaleGuideVisible() { }

	[Address(RVA = "0x532460", Offset = "0x531660", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C4C")]
	public float get_MvBoxSliderDepth() { }

	[Address(RVA = "0x5324A0", Offset = "0x5316A0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C4B")]
	public float get_MvBoxSliderHeight() { }

	[Address(RVA = "0x5324E0", Offset = "0x5316E0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C4D")]
	public float get_MvCylinderSliderRadius() { }

	[Address(RVA = "0x532520", Offset = "0x531720", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C68")]
	public float get_MvDblSliderBorderBoxDepth() { }

	[Address(RVA = "0x518B10", Offset = "0x517D10", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C67")]
	public float get_MvDblSliderBorderBoxHeight() { }

	[Address(RVA = "0x532560", Offset = "0x531760", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C6C")]
	public GizmoFillMode3D get_MvDblSliderBorderFillMode() { }

	[Address(RVA = "0x5325A0", Offset = "0x5317A0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C6A")]
	public GizmoShadeMode get_MvDblSliderBorderShadeMode() { }

	[Address(RVA = "0x5325E0", Offset = "0x5317E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C6B")]
	public GizmoQuad3DBorderType get_MvDblSliderBorderType() { }

	[Address(RVA = "0x532620", Offset = "0x531820", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C69")]
	public float get_MvDblSliderFillAlpha() { }

	[Address(RVA = "0x5190B0", Offset = "0x5182B0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C66")]
	public float get_MvDblSliderSize() { }

	[Address(RVA = "0x532660", Offset = "0x531860", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C76")]
	public Color get_MvHoveredColor() { }

	[Address(RVA = "0x5326A0", Offset = "0x5318A0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C61")]
	public Color get_MvNXColor() { }

	[Address(RVA = "0x5326E0", Offset = "0x5318E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C63")]
	public Color get_MvNYColor() { }

	[Address(RVA = "0x532720", Offset = "0x531920", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C65")]
	public Color get_MvNZColor() { }

	[Address(RVA = "0x532760", Offset = "0x531960", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C60")]
	public Color get_MvPXColor() { }

	[Address(RVA = "0x5327A0", Offset = "0x5319A0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C62")]
	public Color get_MvPYColor() { }

	[Address(RVA = "0x5327E0", Offset = "0x5319E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C64")]
	public Color get_MvPZColor() { }

	[Address(RVA = "0x532820", Offset = "0x531A20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C48")]
	public float get_MvScale() { }

	[Address(RVA = "0x532860", Offset = "0x531A60", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C50")]
	public float get_MvSliderBoxCapDepth() { }

	[Address(RVA = "0x5328A0", Offset = "0x531AA0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C4F")]
	public float get_MvSliderBoxCapHeight() { }

	[Address(RVA = "0x5328E0", Offset = "0x531AE0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C4E")]
	public float get_MvSliderBoxCapWidth() { }

	[Address(RVA = "0x532920", Offset = "0x531B20", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5B")]
	public GizmoFillMode3D get_MvSliderCapFillMode() { }

	[Address(RVA = "0x532960", Offset = "0x531B60", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5E")]
	public GizmoShadeMode get_MvSliderCapShadeMode() { }

	[Address(RVA = "0x5329A0", Offset = "0x531BA0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5C")]
	public GizmoCap3DType get_MvSliderCapType() { }

	[Address(RVA = "0x5329E0", Offset = "0x531BE0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C52")]
	public float get_MvSliderConeCapBaseRadius() { }

	[Address(RVA = "0x532A20", Offset = "0x531C20", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C51")]
	public float get_MvSliderConeCapHeight() { }

	[Address(RVA = "0x532A60", Offset = "0x531C60", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5A")]
	public GizmoFillMode3D get_MvSliderFillMode() { }

	[Address(RVA = "0x532A90", Offset = "0x531C90", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C4A")]
	public float get_MvSliderLength() { }

	[Address(RVA = "0x532AD0", Offset = "0x531CD0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5F")]
	public GizmoLine3DType get_MvSliderLineType() { }

	[Address(RVA = "0x532B00", Offset = "0x531D00", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C55")]
	public float get_MvSliderPyramidCapDepth() { }

	[Address(RVA = "0x532B40", Offset = "0x531D40", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C54")]
	public float get_MvSliderPyramidCapHeight() { }

	[Address(RVA = "0x532B80", Offset = "0x531D80", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C53")]
	public float get_MvSliderPyramidCapWidth() { }

	[Address(RVA = "0x532BC0", Offset = "0x531DC0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C5D")]
	public GizmoShadeMode get_MvSliderShadeMode() { }

	[Address(RVA = "0x532BF0", Offset = "0x531DF0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C59")]
	public float get_MvSliderSphereCapRadius() { }

	[Address(RVA = "0x532C30", Offset = "0x531E30", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C58")]
	public float get_MvSliderTriPrismCapDepth() { }

	[Address(RVA = "0x532C70", Offset = "0x531E70", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C57")]
	public float get_MvSliderTriPrismCapHeight() { }

	[Address(RVA = "0x532CB0", Offset = "0x531EB0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C56")]
	public float get_MvSliderTriPrismCapWidth() { }

	[Address(RVA = "0x532CF0", Offset = "0x531EF0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C49")]
	public bool get_MvUseZoomFactor() { }

	[Address(RVA = "0x532D30", Offset = "0x531F30", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C71")]
	public Color get_MvVertSnapCapBorderColor() { }

	[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6F")]
	public float get_MvVertSnapCapCircleRadius() { }

	[Address(RVA = "0x532D60", Offset = "0x531F60", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C70")]
	public Color get_MvVertSnapCapColor() { }

	[Address(RVA = "0x518E40", Offset = "0x518040", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C74")]
	public GizmoFillMode2D get_MvVertSnapCapFillMode() { }

	[Address(RVA = "0x532D90", Offset = "0x531F90", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C73")]
	public Color get_MvVertSnapCapHoveredBorderColor() { }

	[Address(RVA = "0x532DC0", Offset = "0x531FC0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C72")]
	public Color get_MvVertSnapCapHoveredColor() { }

	[Address(RVA = "0x52A530", Offset = "0x529730", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6E")]
	public float get_MvVertSnapCapQuadHeight() { }

	[Address(RVA = "0x52A5E0", Offset = "0x5297E0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6D")]
	public float get_MvVertSnapCapQuadWidth() { }

	[Address(RVA = "0x518DE0", Offset = "0x517FE0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C75")]
	public GizmoCap2DType get_MvVertSnapCapType() { }

	[Address(RVA = "0x532DF0", Offset = "0x531FF0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C84")]
	public GizmoFillMode3D get_RtAxisBorderFillMode() { }

	[Address(RVA = "0x532E30", Offset = "0x532030", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C83")]
	public GizmoCircle3DBorderType get_RtAxisBorderType() { }

	[Address(RVA = "0x532E70", Offset = "0x532070", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C81")]
	public float get_RtAxisCullAlphaScale() { }

	[Address(RVA = "0x532EB0", Offset = "0x5320B0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C80")]
	public float get_RtAxisCylTorusHeight() { }

	[Address(RVA = "0x532EF0", Offset = "0x5320F0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7F")]
	public float get_RtAxisCylTorusWidth() { }

	[Address(RVA = "0x532F30", Offset = "0x532130", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7E")]
	public float get_RtAxisTorusThickness() { }

	[Address(RVA = "0x532F70", Offset = "0x532170", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C8F")]
	public Color get_RtCamLookSliderBorderColor() { }

	[Address(RVA = "0x532FA0", Offset = "0x5321A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C90")]
	public Color get_RtCamLookSliderHoveredBorderColor() { }

	[Address(RVA = "0x532FD0", Offset = "0x5321D0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C92")]
	public float get_RtCamLookSliderPolyBorderThickness() { }

	[Address(RVA = "0x533000", Offset = "0x532200", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C91")]
	public GizmoPolygon2DBorderType get_RtCamLookSliderPolyBorderType() { }

	[Address(RVA = "0x504710", Offset = "0x503910", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C8E")]
	public float get_RtCamLookSliderRadiusOffset() { }

	[Address(RVA = "0x533030", Offset = "0x532230", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7D")]
	public Color get_RtHoveredColor() { }

	[Address(RVA = "0x533070", Offset = "0x532270", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C8B")]
	public Color get_RtHoveredMidCapColor() { }

	[Address(RVA = "0x5330A0", Offset = "0x5322A0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C8A")]
	public Color get_RtMidCapColor() { }

	[Address(RVA = "0x5330D0", Offset = "0x5322D0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C85")]
	public int get_RtNumAxisTorusWireAxialSlices() { }

	[Address(RVA = "0x533100", Offset = "0x532300", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C78")]
	public float get_RtRadius() { }

	[Address(RVA = "0x533120", Offset = "0x532320", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C87")]
	public Color get_RtRotationArcBorderColor() { }

	[Address(RVA = "0x533170", Offset = "0x532370", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C86")]
	public Color get_RtRotationArcColor() { }

	[Address(RVA = "0x5331C0", Offset = "0x5323C0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C77")]
	public float get_RtScale() { }

	[Address(RVA = "0x5331E0", Offset = "0x5323E0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C82")]
	public GizmoShadeMode get_RtShadeMode() { }

	[Address(RVA = "0x533200", Offset = "0x532400", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C88")]
	public bool get_RtUseShortestRotationArc() { }

	[Address(RVA = "0x533240", Offset = "0x532440", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C79")]
	public bool get_RtUseZoomFactor() { }

	[Address(RVA = "0x533260", Offset = "0x532460", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7A")]
	public Color get_RtXBorderColor() { }

	[Address(RVA = "0x5332A0", Offset = "0x5324A0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7B")]
	public Color get_RtYBorderColor() { }

	[Address(RVA = "0x5332E0", Offset = "0x5324E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C7C")]
	public Color get_RtZBorderColor() { }

	[Address(RVA = "0x533320", Offset = "0x532520", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C98")]
	public float get_ScBoxSliderDepth() { }

	[Address(RVA = "0x533360", Offset = "0x532560", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C97")]
	public float get_ScBoxSliderHeight() { }

	[Address(RVA = "0x5333A0", Offset = "0x5325A0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C99")]
	public float get_ScCylinderSliderRadius() { }

	[Address(RVA = "0x5333E0", Offset = "0x5325E0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB3")]
	public float get_ScDblSliderFillAlpha() { }

	[Address(RVA = "0x533420", Offset = "0x532620", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB2")]
	public float get_ScDblSliderSize() { }

	[Address(RVA = "0x533460", Offset = "0x532660", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CBD")]
	public Color get_ScHoveredColor() { }

	[Address(RVA = "0x5334A0", Offset = "0x5326A0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB6")]
	public float get_ScMidCapBoxDepth() { }

	[Address(RVA = "0x5334C0", Offset = "0x5326C0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB5")]
	public float get_ScMidCapBoxHeight() { }

	[Address(RVA = "0x5334E0", Offset = "0x5326E0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB4")]
	public float get_ScMidCapBoxWidth() { }

	[Address(RVA = "0x533500", Offset = "0x532700", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBC")]
	public Color get_ScMidCapColor() { }

	[Address(RVA = "0x533530", Offset = "0x532730", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBA")]
	public GizmoFillMode3D get_ScMidCapFillMode() { }

	[Address(RVA = "0x533550", Offset = "0x532750", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB9")]
	public GizmoShadeMode get_ScMidCapShadeMode() { }

	[Address(RVA = "0x533570", Offset = "0x532770", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB7")]
	public float get_ScMidCapSphereRadius() { }

	[Address(RVA = "0x533590", Offset = "0x532790", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CB8")]
	public GizmoCap3DType get_ScMidCapType() { }

	[Address(RVA = "0x5335B0", Offset = "0x5327B0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAD")]
	public Color get_ScNXColor() { }

	[Address(RVA = "0x5335F0", Offset = "0x5327F0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAF")]
	public Color get_ScNYColor() { }

	[Address(RVA = "0x533630", Offset = "0x532830", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB1")]
	public Color get_ScNZColor() { }

	[Address(RVA = "0x533670", Offset = "0x532870", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAC")]
	public Color get_ScPXColor() { }

	[Address(RVA = "0x5336B0", Offset = "0x5328B0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAE")]
	public Color get_ScPYColor() { }

	[Address(RVA = "0x5336F0", Offset = "0x5328F0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB0")]
	public Color get_ScPZColor() { }

	[Address(RVA = "0x533750", Offset = "0x532950", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C94")]
	public float get_ScScale() { }

	[Address(RVA = "0x533730", Offset = "0x532930", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBF")]
	public float get_ScScaleGuideAxisLength() { }

	[Address(RVA = "0x533770", Offset = "0x532970", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C9C")]
	public float get_ScSliderBoxCapDepth() { }

	[Address(RVA = "0x5337B0", Offset = "0x5329B0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C9B")]
	public float get_ScSliderBoxCapHeight() { }

	[Address(RVA = "0x5337F0", Offset = "0x5329F0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C9A")]
	public float get_ScSliderBoxCapWidth() { }

	[Address(RVA = "0x533830", Offset = "0x532A30", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA7")]
	public GizmoFillMode3D get_ScSliderCapFillMode() { }

	[Address(RVA = "0x533870", Offset = "0x532A70", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAA")]
	public GizmoShadeMode get_ScSliderCapShadeMode() { }

	[Address(RVA = "0x5338B0", Offset = "0x532AB0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA8")]
	public GizmoCap3DType get_ScSliderCapType() { }

	[Address(RVA = "0x5338F0", Offset = "0x532AF0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C9E")]
	public float get_ScSliderConeCapBaseRadius() { }

	[Address(RVA = "0x533930", Offset = "0x532B30", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C9D")]
	public float get_ScSliderConeCapHeight() { }

	[Address(RVA = "0x533970", Offset = "0x532B70", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA6")]
	public GizmoFillMode3D get_ScSliderFillMode() { }

	[Address(RVA = "0x5339B0", Offset = "0x532BB0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C96")]
	public float get_ScSliderLength() { }

	[Address(RVA = "0x5339F0", Offset = "0x532BF0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAB")]
	public GizmoLine3DType get_ScSliderLineType() { }

	[Address(RVA = "0x533A30", Offset = "0x532C30", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA1")]
	public float get_ScSliderPyramidCapDepth() { }

	[Address(RVA = "0x533A70", Offset = "0x532C70", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA0")]
	public float get_ScSliderPyramidCapHeight() { }

	[Address(RVA = "0x533AB0", Offset = "0x532CB0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C9F")]
	public float get_ScSliderPyramidCapWidth() { }

	[Address(RVA = "0x533AF0", Offset = "0x532CF0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA9")]
	public GizmoShadeMode get_ScSliderShadeMode() { }

	[Address(RVA = "0x533B30", Offset = "0x532D30", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA5")]
	public float get_ScSliderSphereCapRadius() { }

	[Address(RVA = "0x533B70", Offset = "0x532D70", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA4")]
	public float get_ScSliderTriPrismCapDepth() { }

	[Address(RVA = "0x533BB0", Offset = "0x532DB0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA3")]
	public float get_ScSliderTriPrismCapHeight() { }

	[Address(RVA = "0x533BF0", Offset = "0x532DF0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CA2")]
	public float get_ScSliderTriPrismCapWidth() { }

	[Address(RVA = "0x533C30", Offset = "0x532E30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C95")]
	public bool get_ScUseZoomFactor() { }

	[Address(RVA = "0x52AC50", Offset = "0x529E50", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CC4")]
	public List<Enum> GetAllowedMvVertSnapCapTypes() { }

	[Address(RVA = "0x52ADD0", Offset = "0x529FD0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D47")]
	public List<Enum> GetAllowedScMidCapTypes() { }

	[Address(RVA = "0x52AF50", Offset = "0x52A150", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D02")]
	private GizmoPlaneSlider3DLookAndFeel GetMvDblSliderLookAndFeel(PlaneId planeId) { }

	[Address(RVA = "0x52AF80", Offset = "0x52A180", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D01")]
	private GizmoLineSlider3DLookAndFeel GetMvSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x52AFD0", Offset = "0x52A1D0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D62")]
	private GizmoPlaneSlider3DLookAndFeel GetScDblSliderLookAndFeel(PlaneId planeId) { }

	[Address(RVA = "0x52B000", Offset = "0x52A200", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D61")]
	private GizmoLineSlider3DLookAndFeel GetScSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x52B050", Offset = "0x52A250", Length = "0x1074")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapCircleRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapFillMode", ReturnType = typeof(GizmoFillMode2D))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapHoveredBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapHoveredColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapQuadWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "IsSliderCapVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_DblSliderBorderBoxDepth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_DblSliderBorderBoxHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_DblSliderBorderFillMode", ReturnType = typeof(GizmoFillMode3D))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_DblSliderBorderShadeMode", ReturnType = typeof(GizmoShadeMode))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_VertSnapCapType", ReturnType = typeof(GizmoCap2DType))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_DblSliderBorderType", ReturnType = typeof(GizmoQuad3DBorderType))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "get_DblSliderSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvDblSliderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvHoveredColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvDblSliderFillAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 49)]
	[Token(Token = "0x6000D00")]
	public void Inherit(MoveGizmoLookAndFeel3D lookAndFeel) { }

	[Address(RVA = "0x52D460", Offset = "0x52C660", Length = "0xA5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderCircleCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtNumAxisTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D24")]
	public void Inherit(RotationGizmoLookAndFeel3D lookAndFeel) { }

	[Address(RVA = "0x52C0D0", Offset = "0x52B2D0", Length = "0x1380")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScHoveredColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScDblSliderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScDblSliderFillAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D60")]
	public void Inherit(ScaleGizmoLookAndFeel3D lookAndFeel) { }

	[Address(RVA = "0x514F30", Offset = "0x514130", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCF")]
	public bool IsMvDblSliderVisible(PlaneId planeId) { }

	[Address(RVA = "0x516B50", Offset = "0x515D50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD4")]
	public bool IsMvNegativeSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x524880", Offset = "0x523A80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD3")]
	public bool IsMvNegativeSliderVisible(int axisIndex) { }

	[Address(RVA = "0x514F60", Offset = "0x514160", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD2")]
	public bool IsMvPositiveSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x522D20", Offset = "0x521F20", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD1")]
	public bool IsMvPositiveSliderVisible(int axisIndex) { }

	[Address(RVA = "0x3D7530", Offset = "0x3D6730", Length = "0x54")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD0")]
	public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x524930", Offset = "0x523B30", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CCE")]
	public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x4F9BF0", Offset = "0x4F8DF0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC3")]
	public bool IsMvVertSnapCapTypeAllowed(GizmoCap2DType capType) { }

	[Address(RVA = "0x52DEC0", Offset = "0x52D0C0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D03")]
	public bool IsRtAxisVisible(int axisIndex) { }

	[Address(RVA = "0x52DEF0", Offset = "0x52D0F0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D26")]
	public bool IsScDblSliderVisible(PlaneId planeId) { }

	[Address(RVA = "0x3E2E40", Offset = "0x3E2040", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D46")]
	public bool IsScMidCapTypeAllowed(GizmoCap3DType capType) { }

	[Address(RVA = "0x52DF30", Offset = "0x52D130", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D2D")]
	public bool IsScNegativeSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x52DF70", Offset = "0x52D170", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D2C")]
	public bool IsScNegativeSliderVisible(int axisIndex) { }

	[Address(RVA = "0x52DFB0", Offset = "0x52D1B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D2B")]
	public bool IsScPositiveSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x52DFF0", Offset = "0x52D1F0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D2A")]
	public bool IsScPositiveSliderVisible(int axisIndex) { }

	[Address(RVA = "0x52E030", Offset = "0x52D230", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D29")]
	public bool IsScSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x52E090", Offset = "0x52D290", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D28")]
	public bool IsScSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC1")]
	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	[Address(RVA = "0x52E0F0", Offset = "0x52D2F0", Length = "0x174")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CE7")]
	public void SetMvAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x52E270", Offset = "0x52D470", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CE2")]
	public void SetMvBoxSliderDepth(float depth) { }

	[Address(RVA = "0x52E2E0", Offset = "0x52D4E0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CE1")]
	public void SetMvBoxSliderHeight(float height) { }

	[Address(RVA = "0x52E350", Offset = "0x52D550", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CE3")]
	public void SetMvCylinderSliderRadius(float radius) { }

	[Address(RVA = "0x52E3C0", Offset = "0x52D5C0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CE0")]
	public void SetMvDblSliderBorderBoxDepth(float depth) { }

	[Address(RVA = "0x516E50", Offset = "0x516050", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDF")]
	public void SetMvDblSliderBorderBoxHeight(float height) { }

	[Address(RVA = "0x52E430", Offset = "0x52D630", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF0")]
	public void SetMvDblSliderBorderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x52E490", Offset = "0x52D690", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CEC")]
	public void SetMvDblSliderBorderShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x52E4F0", Offset = "0x52D6F0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CDE")]
	public void SetMvDblSliderBorderType(GizmoQuad3DBorderType borderType) { }

	[Address(RVA = "0x52E550", Offset = "0x52D750", Length = "0xDE")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000CE8")]
	public void SetMvDblSliderFillAlpha(float alpha) { }

	[Address(RVA = "0x52E630", Offset = "0x52D830", Length = "0x8E")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000CE4")]
	public void SetMvDblSliderSize(float size) { }

	[Address(RVA = "0x5174D0", Offset = "0x5166D0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD6")]
	public void SetMvDblSliderVisible(PlaneId planeId, bool isVisible) { }

	[Address(RVA = "0x52E6C0", Offset = "0x52D8C0", Length = "0xF4")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CE9")]
	public void SetMvHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x5174A0", Offset = "0x5166A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDB")]
	public void SetMvNegativeSliderCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x524DB0", Offset = "0x523FB0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDA")]
	public void SetMvNegativeSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x517500", Offset = "0x516700", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD9")]
	public void SetMvPositiveSliderCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x523010", Offset = "0x522210", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD8")]
	public void SetMvPositiveSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x52E7C0", Offset = "0x52D9C0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000CE5")]
	public void SetMvScale(float scale) { }

	[Address(RVA = "0x52E8B0", Offset = "0x52DAB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF3")]
	public void SetMvSliderBoxCapDepth(float depth) { }

	[Address(RVA = "0x52E930", Offset = "0x52DB30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF2")]
	public void SetMvSliderBoxCapHeight(float height) { }

	[Address(RVA = "0x52E9B0", Offset = "0x52DBB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF1")]
	public void SetMvSliderBoxCapWidth(float width) { }

	[Address(RVA = "0x52EA30", Offset = "0x52DC30", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CEF")]
	public void SetMvSliderCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x52EA90", Offset = "0x52DC90", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CEB")]
	public void SetMvSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x52EAF0", Offset = "0x52DCF0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CED")]
	public void SetMvSliderCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x3D7660", Offset = "0x3D6860", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD7")]
	public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x52EB50", Offset = "0x52DD50", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF5")]
	public void SetMvSliderConeCapBaseRadius(float radius) { }

	[Address(RVA = "0x52EBD0", Offset = "0x52DDD0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF4")]
	public void SetMvSliderConeCapHeight(float height) { }

	[Address(RVA = "0x52EC50", Offset = "0x52DE50", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CEE")]
	public void SetMvSliderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x52ECB0", Offset = "0x52DEB0", Length = "0x6F")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CDC")]
	public void SetMvSliderLength(float axisLength) { }

	[Address(RVA = "0x52ED20", Offset = "0x52DF20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CDD")]
	public void SetMvSliderLineType(GizmoLine3DType lineType) { }

	[Address(RVA = "0x52ED80", Offset = "0x52DF80", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF8")]
	public void SetMvSliderPyramidCapDepth(float depth) { }

	[Address(RVA = "0x52EE00", Offset = "0x52E000", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF7")]
	public void SetMvSliderPyramidCapHeight(float height) { }

	[Address(RVA = "0x52EE80", Offset = "0x52E080", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF6")]
	public void SetMvSliderPyramidCapWidth(float width) { }

	[Address(RVA = "0x52EF00", Offset = "0x52E100", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CEA")]
	public void SetMvSliderShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x52EF60", Offset = "0x52E160", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFC")]
	public void SetMvSliderSphereCapRadius(float radius) { }

	[Address(RVA = "0x52EFE0", Offset = "0x52E1E0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFB")]
	public void SetMvSliderTriPrismCapDepth(float depth) { }

	[Address(RVA = "0x52F060", Offset = "0x52E260", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFA")]
	public void SetMvSliderTriPrismCapHeight(float height) { }

	[Address(RVA = "0x52F0E0", Offset = "0x52E2E0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CF9")]
	public void SetMvSliderTriPrismCapWidth(float width) { }

	[Address(RVA = "0x524F60", Offset = "0x524160", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CD5")]
	public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x52F160", Offset = "0x52E360", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CE6")]
	public void SetMvUseZoomFactor(bool useZoomFactor) { }

	[Address(RVA = "0x52F200", Offset = "0x52E400", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CCB")]
	public void SetMvVertSnapCapBorderColor(Color color) { }

	[Address(RVA = "0x52F220", Offset = "0x52E420", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CC8")]
	public void SetMvVertSnapCapCircleRadius(float radius) { }

	[Address(RVA = "0x52F240", Offset = "0x52E440", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CCA")]
	public void SetMvVertSnapCapColor(Color color) { }

	[Address(RVA = "0x529700", Offset = "0x528900", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC9")]
	public void SetMvVertSnapCapFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x52F260", Offset = "0x52E460", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CCD")]
	public void SetMvVertSnapCapHoveredBorderColor(Color color) { }

	[Address(RVA = "0x52F280", Offset = "0x52E480", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CCC")]
	public void SetMvVertSnapCapHoveredColor(Color color) { }

	[Address(RVA = "0x5296C0", Offset = "0x5288C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC7")]
	public void SetMvVertSnapCapQuadHeight(float height) { }

	[Address(RVA = "0x529760", Offset = "0x528960", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC6")]
	public void SetMvVertSnapCapQuadWidth(float width) { }

	[Address(RVA = "0x52F2A0", Offset = "0x52E4A0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CC5")]
	public void SetMvVertSnapCapType(GizmoCap2DType capType) { }

	[Address(RVA = "0x52F2D0", Offset = "0x52E4D0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D15")]
	public void SetRtAxisBorderColor(int axisIndex, Color color) { }

	[Address(RVA = "0x52F310", Offset = "0x52E510", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderCircleCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D0B")]
	public void SetRtAxisBorderCullAlphaScale(float scale) { }

	[Address(RVA = "0x52F380", Offset = "0x52E580", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D06")]
	public void SetRtAxisBorderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x52F3E0", Offset = "0x52E5E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D0C")]
	public void SetRtAxisBorderType(GizmoCircle3DBorderType borderType) { }

	[Address(RVA = "0x52F440", Offset = "0x52E640", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D0F")]
	public void SetRtAxisCylTorusHeight(float height) { }

	[Address(RVA = "0x52F4B0", Offset = "0x52E6B0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D0E")]
	public void SetRtAxisCylTorusWidth(float width) { }

	[Address(RVA = "0x52F520", Offset = "0x52E720", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D0D")]
	public void SetRtAxisTorusThickness(float thickness) { }

	[Address(RVA = "0x52F590", Offset = "0x52E790", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D04")]
	public void SetRtAxisVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x52F5C0", Offset = "0x52E7C0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D1C")]
	public void SetRtCamLookSliderBorderColor(Color color) { }

	[Address(RVA = "0x52F5F0", Offset = "0x52E7F0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D1D")]
	public void SetRtCamLookSliderHoveredBorderColor(Color color) { }

	[Address(RVA = "0x52F620", Offset = "0x52E820", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D20")]
	public void SetRtCamLookSliderPolyBorderThickness(float thickness) { }

	[Address(RVA = "0x52F650", Offset = "0x52E850", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D1F")]
	public void SetRtCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType) { }

	[Address(RVA = "0x504730", Offset = "0x503930", Length = "0x12")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1B")]
	public void SetRtCamLookSliderRadiusOffset(float offset) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1E")]
	public void SetRtCamLookSliderVisible(bool isVisible) { }

	[Address(RVA = "0x52F690", Offset = "0x52E890", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D16")]
	public void SetRtHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x52F6E0", Offset = "0x52E8E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D12")]
	public void SetRtHoveredMidCapColor(Color color) { }

	[Address(RVA = "0x52F700", Offset = "0x52E900", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D14")]
	public void SetRtMidCapBorderColor(Color color) { }

	[Address(RVA = "0x52F720", Offset = "0x52E920", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D13")]
	public void SetRtMidCapBorderVisible(bool isVisible) { }

	[Address(RVA = "0x52F740", Offset = "0x52E940", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D11")]
	public void SetRtMidCapColor(Color color) { }

	[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D10")]
	public void SetRtMidCapVisible(bool isVisible) { }

	[Address(RVA = "0x52F760", Offset = "0x52E960", Length = "0x6D")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_NumBorderTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D07")]
	public void SetRtNumAxisTorusWireAxialSlices(int numSlices) { }

	[Address(RVA = "0x52F7D0", Offset = "0x52E9D0", Length = "0x8F")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D0A")]
	public void SetRtRadius(float radius) { }

	[Address(RVA = "0x52F860", Offset = "0x52EA60", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D18")]
	public void SetRtRotationArcBorderColor(Color color) { }

	[Address(RVA = "0x52F8F0", Offset = "0x52EAF0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D17")]
	public void SetRtRotationArcColor(Color color) { }

	[Address(RVA = "0x52F980", Offset = "0x52EB80", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D1A")]
	public void SetRtRotationArcVisible(bool isVisible) { }

	[Address(RVA = "0x52F9F0", Offset = "0x52EBF0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D09")]
	public void SetRtScale(float scale) { }

	[Address(RVA = "0x52FA80", Offset = "0x52EC80", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D05")]
	public void SetRtShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x52FAF0", Offset = "0x52ECF0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D19")]
	public void SetRtUseShortestRotationArc(bool useShortest) { }

	[Address(RVA = "0x52FB70", Offset = "0x52ED70", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D08")]
	public void SetRtUseZoomFactor(bool useZoomFactor) { }

	[Address(RVA = "0x52FBD0", Offset = "0x52EDD0", Length = "0x1C9")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D3C")]
	public void SetScAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x52FDA0", Offset = "0x52EFA0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D37")]
	public void SetScBoxSliderDepth(float depth) { }

	[Address(RVA = "0x52FE20", Offset = "0x52F020", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D36")]
	public void SetScBoxSliderHeight(float height) { }

	[Address(RVA = "0x52FEA0", Offset = "0x52F0A0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D38")]
	public void SetScCylinderSliderRadius(float radius) { }

	[Address(RVA = "0x52FF20", Offset = "0x52F120", Length = "0xDF")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D3D")]
	public void SetScDblSliderFillAlpha(float alpha) { }

	[Address(RVA = "0x530000", Offset = "0x52F200", Length = "0x8F")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D5B")]
	public void SetScDblSliderSize(float size) { }

	[Address(RVA = "0x530090", Offset = "0x52F290", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D27")]
	public void SetScDblSliderVisible(PlaneId planeId, bool isVisible) { }

	[Address(RVA = "0x5300C0", Offset = "0x52F2C0", Length = "0x105")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D40")]
	public void SetScHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x5301D0", Offset = "0x52F3D0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D59")]
	public void SetScMidCapBoxDepth(float depth) { }

	[Address(RVA = "0x530200", Offset = "0x52F400", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D58")]
	public void SetScMidCapBoxHeight(float height) { }

	[Address(RVA = "0x530230", Offset = "0x52F430", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D57")]
	public void SetScMidCapBoxWidth(float width) { }

	[Address(RVA = "0x530260", Offset = "0x52F460", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D3E")]
	public void SetScMidCapColor(Color color) { }

	[Address(RVA = "0x530290", Offset = "0x52F490", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D4A")]
	public void SetScMidCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x5302B0", Offset = "0x52F4B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D43")]
	public void SetScMidCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x5302D0", Offset = "0x52F4D0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D5A")]
	public void SetScMidCapSphereRadius(float radius) { }

	[Address(RVA = "0x530300", Offset = "0x52F500", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D45")]
	public void SetScMidCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x530330", Offset = "0x52F530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D3F")]
	public void SetScMidCapVisible(bool visible) { }

	[Address(RVA = "0x530340", Offset = "0x52F540", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D33")]
	public void SetScNegativeSliderCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x530380", Offset = "0x52F580", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D32")]
	public void SetScNegativeSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x5303C0", Offset = "0x52F5C0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D31")]
	public void SetScPositiveSliderCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x5303F0", Offset = "0x52F5F0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D30")]
	public void SetScPositiveSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x530460", Offset = "0x52F660", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000D39")]
	public void SetScScale(float scale) { }

	[Address(RVA = "0x530420", Offset = "0x52F620", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D3B")]
	public void SetScScaleGuideAxisLength(float length) { }

	[Address(RVA = "0x530450", Offset = "0x52F650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D25")]
	public void SetScScaleGuideVisible(bool isVisible) { }

	[Address(RVA = "0x530570", Offset = "0x52F770", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D4D")]
	public void SetScSliderBoxCapDepth(float depth) { }

	[Address(RVA = "0x530600", Offset = "0x52F800", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D4C")]
	public void SetScSliderBoxCapHeight(float height) { }

	[Address(RVA = "0x530690", Offset = "0x52F890", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D4B")]
	public void SetScSliderBoxCapWidth(float width) { }

	[Address(RVA = "0x530720", Offset = "0x52F920", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D49")]
	public void SetScSliderCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x530780", Offset = "0x52F980", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D42")]
	public void SetScSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x5307E0", Offset = "0x52F9E0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D44")]
	public void SetScSliderCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x530840", Offset = "0x52FA40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D2F")]
	public void SetScSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x530890", Offset = "0x52FA90", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D4F")]
	public void SetScSliderConeCapBaseRadius(float radius) { }

	[Address(RVA = "0x530920", Offset = "0x52FB20", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D4E")]
	public void SetScSliderConeCapHeight(float height) { }

	[Address(RVA = "0x5309B0", Offset = "0x52FBB0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D48")]
	public void SetScSliderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x530A10", Offset = "0x52FC10", Length = "0x77")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D34")]
	public void SetScSliderLength(float axisLength) { }

	[Address(RVA = "0x530A90", Offset = "0x52FC90", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D35")]
	public void SetScSliderLineType(GizmoLine3DType lineType) { }

	[Address(RVA = "0x530AF0", Offset = "0x52FCF0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D52")]
	public void SetScSliderPyramidCapDepth(float depth) { }

	[Address(RVA = "0x530B80", Offset = "0x52FD80", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D51")]
	public void SetScSliderPyramidCapHeight(float height) { }

	[Address(RVA = "0x530C10", Offset = "0x52FE10", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D50")]
	public void SetScSliderPyramidCapWidth(float width) { }

	[Address(RVA = "0x530CA0", Offset = "0x52FEA0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D41")]
	public void SetScSliderShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x530D00", Offset = "0x52FF00", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D56")]
	public void SetScSliderSphereCapRadius(float radius) { }

	[Address(RVA = "0x530D90", Offset = "0x52FF90", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D55")]
	public void SetScSliderTriPrismCapDepth(float depth) { }

	[Address(RVA = "0x530E20", Offset = "0x530020", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D54")]
	public void SetScSliderTriPrismCapHeight(float height) { }

	[Address(RVA = "0x530EB0", Offset = "0x5300B0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D53")]
	public void SetScSliderTriPrismCapWidth(float width) { }

	[Address(RVA = "0x530F40", Offset = "0x530140", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D2E")]
	public void SetScSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x530F90", Offset = "0x530190", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3A")]
	public void SetScUseZoomFactor(bool useZoomFactor) { }

}

