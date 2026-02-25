namespace RLD;

[Token(Token = "0x2000113")]
public class ScaleGizmoLookAndFeel3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004BC")]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004BD")]
	private Boolean[] _sglSliderVis; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004BE")]
	private Boolean[] _sglSliderCapVis; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40004BF")]
	private Boolean[] _dblSliderVis; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40004C0")]
	private GizmoScaleGuideLookAndFeel _scaleGuideLookAndFeel; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40004C1")]
	private bool _isScaleGuideVisible; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40004C2")]
	private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40004C3")]
	private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel; //Field offset: 0x60

	[Token(Token = "0x170003A7")]
	public float BoxSliderDepth
	{
		[Address(RVA = "0x518A90", Offset = "0x517C90", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B42")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003A6")]
	public float BoxSliderHeight
	{
		[Address(RVA = "0x518AD0", Offset = "0x517CD0", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B41")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003A8")]
	public float CylinderSliderRadius
	{
		[Address(RVA = "0x518B10", Offset = "0x517D10", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B43")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003BF")]
	public float DblSliderFillAlpha
	{
		[Address(RVA = "0x518C90", Offset = "0x517E90", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5A")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003BE")]
	public float DblSliderSize
	{
		[Address(RVA = "0x525AA0", Offset = "0x524CA0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000B59")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003C8")]
	public Color HoveredColor
	{
		[Address(RVA = "0x518D10", Offset = "0x517F10", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B63")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003C9")]
	public bool IsScaleGuideVisible
	{
		[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B64")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C2")]
	public float MidCapBoxDepth
	{
		[Address(RVA = "0x525AE0", Offset = "0x524CE0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B5D")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003C1")]
	public float MidCapBoxHeight
	{
		[Address(RVA = "0x525B00", Offset = "0x524D00", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B5C")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003C0")]
	public float MidCapBoxWidth
	{
		[Address(RVA = "0x519A10", Offset = "0x518C10", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5B")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003C7")]
	public Color MidCapColor
	{
		[Address(RVA = "0x525B20", Offset = "0x524D20", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B62")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170003C6")]
	public GizmoFillMode3D MidCapFillMode
	{
		[Address(RVA = "0x516200", Offset = "0x515400", Length = "0x1A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B61")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003C5")]
	public GizmoShadeMode MidCapShadeMode
	{
		[Address(RVA = "0x525B50", Offset = "0x524D50", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B60")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003C3")]
	public float MidCapSphereRadius
	{
		[Address(RVA = "0x525B70", Offset = "0x524D70", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B5E")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003C4")]
	public GizmoCap3DType MidCapType
	{
		[Address(RVA = "0x3E3C60", Offset = "0x3E2E60", Length = "0x1A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5F")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003A3")]
	public float Scale
	{
		[Address(RVA = "0x516240", Offset = "0x515440", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B3E")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003CA")]
	public float ScaleGuideAxisLength
	{
		[Address(RVA = "0x525B90", Offset = "0x524D90", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B65")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003AB")]
	public float SliderBoxCapDepth
	{
		[Address(RVA = "0x518E80", Offset = "0x518080", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B46")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003AA")]
	public float SliderBoxCapHeight
	{
		[Address(RVA = "0x518EC0", Offset = "0x5180C0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B45")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003A9")]
	public float SliderBoxCapWidth
	{
		[Address(RVA = "0x518F00", Offset = "0x518100", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B44")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003B6")]
	public GizmoFillMode3D SliderCapFillMode
	{
		[Address(RVA = "0x518F40", Offset = "0x518140", Length = "0x38")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B51")]
		 get { } //Length: 56
	}

	[Token(Token = "0x170003B9")]
	public GizmoShadeMode SliderCapShadeMode
	{
		[Address(RVA = "0x518F80", Offset = "0x518180", Length = "0x38")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B54")]
		 get { } //Length: 56
	}

	[Token(Token = "0x170003B7")]
	public GizmoCap3DType SliderCapType
	{
		[Address(RVA = "0x518FC0", Offset = "0x5181C0", Length = "0x38")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B52")]
		 get { } //Length: 56
	}

	[Token(Token = "0x170003AD")]
	public float SliderConeCapBaseRadius
	{
		[Address(RVA = "0x519000", Offset = "0x518200", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B48")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003AC")]
	public float SliderConeCapHeight
	{
		[Address(RVA = "0x519040", Offset = "0x518240", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B47")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003B5")]
	public GizmoFillMode3D SliderFillMode
	{
		[Address(RVA = "0x519080", Offset = "0x518280", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B50")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170003A5")]
	public float SliderLength
	{
		[Address(RVA = "0x5190B0", Offset = "0x5182B0", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B40")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003BA")]
	public GizmoLine3DType SliderLineType
	{
		[Address(RVA = "0x5190F0", Offset = "0x5182F0", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B55")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170003B0")]
	public float SliderPyramidCapDepth
	{
		[Address(RVA = "0x519120", Offset = "0x518320", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4B")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003AF")]
	public float SliderPyramidCapHeight
	{
		[Address(RVA = "0x519160", Offset = "0x518360", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4A")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003AE")]
	public float SliderPyramidCapWidth
	{
		[Address(RVA = "0x5191A0", Offset = "0x5183A0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B49")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003B8")]
	public GizmoShadeMode SliderShadeMode
	{
		[Address(RVA = "0x5191E0", Offset = "0x5183E0", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B53")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170003B4")]
	public float SliderSphereCapRadius
	{
		[Address(RVA = "0x519210", Offset = "0x518410", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4F")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003B3")]
	public float SliderTriPrismCapDepth
	{
		[Address(RVA = "0x519250", Offset = "0x518450", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4E")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003B2")]
	public float SliderTriPrismCapHeight
	{
		[Address(RVA = "0x519290", Offset = "0x518490", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4D")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003B1")]
	public float SliderTriPrismCapWidth
	{
		[Address(RVA = "0x5192D0", Offset = "0x5184D0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4C")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003A4")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x525BB0", Offset = "0x524DB0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B3F")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170003BB")]
	public Color XColor
	{
		[Address(RVA = "0x519490", Offset = "0x518690", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B56")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003BC")]
	public Color YColor
	{
		[Address(RVA = "0x5194D0", Offset = "0x5186D0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B57")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003BD")]
	public Color ZColor
	{
		[Address(RVA = "0x519510", Offset = "0x518710", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B58")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x5250C0", Offset = "0x5242C0", Length = "0x9D5")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_AxisAlpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_CenterAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoScaleGuideLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000B66")]
	public ScaleGizmoLookAndFeel3D() { }

	[Address(RVA = "0x516650", Offset = "0x515850", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9F")]
	public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId) { }

	[Address(RVA = "0x5246D0", Offset = "0x5238D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BA0")]
	public void ConnectGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide) { }

	[Address(RVA = "0x3E29B0", Offset = "0x3E1BB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9E")]
	public void ConnectMidCapLookAndFeel(GizmoCap3D cap) { }

	[Address(RVA = "0x5166D0", Offset = "0x5158D0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9D")]
	public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x518A90", Offset = "0x517C90", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B42")]
	public float get_BoxSliderDepth() { }

	[Address(RVA = "0x518AD0", Offset = "0x517CD0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B41")]
	public float get_BoxSliderHeight() { }

	[Address(RVA = "0x518B10", Offset = "0x517D10", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B43")]
	public float get_CylinderSliderRadius() { }

	[Address(RVA = "0x518C90", Offset = "0x517E90", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B5A")]
	public float get_DblSliderFillAlpha() { }

	[Address(RVA = "0x525AA0", Offset = "0x524CA0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B59")]
	public float get_DblSliderSize() { }

	[Address(RVA = "0x518D10", Offset = "0x517F10", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B63")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B64")]
	public bool get_IsScaleGuideVisible() { }

	[Address(RVA = "0x525AE0", Offset = "0x524CE0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B5D")]
	public float get_MidCapBoxDepth() { }

	[Address(RVA = "0x525B00", Offset = "0x524D00", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B5C")]
	public float get_MidCapBoxHeight() { }

	[Address(RVA = "0x519A10", Offset = "0x518C10", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B5B")]
	public float get_MidCapBoxWidth() { }

	[Address(RVA = "0x525B20", Offset = "0x524D20", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B62")]
	public Color get_MidCapColor() { }

	[Address(RVA = "0x516200", Offset = "0x515400", Length = "0x1A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B61")]
	public GizmoFillMode3D get_MidCapFillMode() { }

	[Address(RVA = "0x525B50", Offset = "0x524D50", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B60")]
	public GizmoShadeMode get_MidCapShadeMode() { }

	[Address(RVA = "0x525B70", Offset = "0x524D70", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B5E")]
	public float get_MidCapSphereRadius() { }

	[Address(RVA = "0x3E3C60", Offset = "0x3E2E60", Length = "0x1A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B5F")]
	public GizmoCap3DType get_MidCapType() { }

	[Address(RVA = "0x516240", Offset = "0x515440", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3E")]
	public float get_Scale() { }

	[Address(RVA = "0x525B90", Offset = "0x524D90", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B65")]
	public float get_ScaleGuideAxisLength() { }

	[Address(RVA = "0x518E80", Offset = "0x518080", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B46")]
	public float get_SliderBoxCapDepth() { }

	[Address(RVA = "0x518EC0", Offset = "0x5180C0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B45")]
	public float get_SliderBoxCapHeight() { }

	[Address(RVA = "0x518F00", Offset = "0x518100", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B44")]
	public float get_SliderBoxCapWidth() { }

	[Address(RVA = "0x518F40", Offset = "0x518140", Length = "0x38")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B51")]
	public GizmoFillMode3D get_SliderCapFillMode() { }

	[Address(RVA = "0x518F80", Offset = "0x518180", Length = "0x38")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B54")]
	public GizmoShadeMode get_SliderCapShadeMode() { }

	[Address(RVA = "0x518FC0", Offset = "0x5181C0", Length = "0x38")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B52")]
	public GizmoCap3DType get_SliderCapType() { }

	[Address(RVA = "0x519000", Offset = "0x518200", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B48")]
	public float get_SliderConeCapBaseRadius() { }

	[Address(RVA = "0x519040", Offset = "0x518240", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B47")]
	public float get_SliderConeCapHeight() { }

	[Address(RVA = "0x519080", Offset = "0x518280", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B50")]
	public GizmoFillMode3D get_SliderFillMode() { }

	[Address(RVA = "0x5190B0", Offset = "0x5182B0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B40")]
	public float get_SliderLength() { }

	[Address(RVA = "0x5190F0", Offset = "0x5182F0", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B55")]
	public GizmoLine3DType get_SliderLineType() { }

	[Address(RVA = "0x519120", Offset = "0x518320", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4B")]
	public float get_SliderPyramidCapDepth() { }

	[Address(RVA = "0x519160", Offset = "0x518360", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4A")]
	public float get_SliderPyramidCapHeight() { }

	[Address(RVA = "0x5191A0", Offset = "0x5183A0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B49")]
	public float get_SliderPyramidCapWidth() { }

	[Address(RVA = "0x5191E0", Offset = "0x5183E0", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B53")]
	public GizmoShadeMode get_SliderShadeMode() { }

	[Address(RVA = "0x519210", Offset = "0x518410", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4F")]
	public float get_SliderSphereCapRadius() { }

	[Address(RVA = "0x519250", Offset = "0x518450", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4E")]
	public float get_SliderTriPrismCapDepth() { }

	[Address(RVA = "0x519290", Offset = "0x518490", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4D")]
	public float get_SliderTriPrismCapHeight() { }

	[Address(RVA = "0x5192D0", Offset = "0x5184D0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4C")]
	public float get_SliderTriPrismCapWidth() { }

	[Address(RVA = "0x525BB0", Offset = "0x524DB0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3F")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x519490", Offset = "0x518690", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B56")]
	public Color get_XColor() { }

	[Address(RVA = "0x5194D0", Offset = "0x5186D0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B57")]
	public Color get_YColor() { }

	[Address(RVA = "0x519510", Offset = "0x518710", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B58")]
	public Color get_ZColor() { }

	[Address(RVA = "0x524700", Offset = "0x523900", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B88")]
	public List<Enum> GetAllowedMidCapTypes() { }

	[Address(RVA = "0x516A60", Offset = "0x515C60", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA2")]
	private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId) { }

	[Address(RVA = "0x516A90", Offset = "0x515C90", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA1")]
	private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x514F60", Offset = "0x514160", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B68")]
	public bool IsDblSliderVisible(PlaneId planeId) { }

	[Address(RVA = "0x3E2E40", Offset = "0x3E2040", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B87")]
	public bool IsMidCapTypeAllowed(GizmoCap3DType capType) { }

	[Address(RVA = "0x524880", Offset = "0x523A80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6F")]
	public bool IsNegativeSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x5248C0", Offset = "0x523AC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B6E")]
	public bool IsNegativeSliderVisible(int axisIndex) { }

	[Address(RVA = "0x522D20", Offset = "0x521F20", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6D")]
	public bool IsPositiveSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x524900", Offset = "0x523B00", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B6C")]
	public bool IsPositiveSliderVisible(int axisIndex) { }

	[Address(RVA = "0x524930", Offset = "0x523B30", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6B")]
	public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x524990", Offset = "0x523B90", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B6A")]
	public bool IsSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5249F0", Offset = "0x523BF0", Length = "0x1AB")]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B7E")]
	public void SetAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x516D70", Offset = "0x515F70", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B79")]
	public void SetBoxSliderDepth(float depth) { }

	[Address(RVA = "0x516DE0", Offset = "0x515FE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B78")]
	public void SetBoxSliderHeight(float height) { }

	[Address(RVA = "0x516E50", Offset = "0x516050", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7A")]
	public void SetCylinderSliderRadius(float radius) { }

	[Address(RVA = "0x5170C0", Offset = "0x5162C0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7F")]
	public void SetDblSliderFillAlpha(float alpha) { }

	[Address(RVA = "0x524BA0", Offset = "0x523DA0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B9C")]
	public void SetDblSliderSize(float size) { }

	[Address(RVA = "0x517500", Offset = "0x516700", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B69")]
	public void SetDblSliderVisible(PlaneId planeId, bool isVisible) { }

	[Address(RVA = "0x524C30", Offset = "0x523E30", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B81")]
	public void SetHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x524D30", Offset = "0x523F30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B9A")]
	public void SetMidCapBoxDepth(float depth) { }

	[Address(RVA = "0x524D50", Offset = "0x523F50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B99")]
	public void SetMidCapBoxHeight(float height) { }

	[Address(RVA = "0x524D70", Offset = "0x523F70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B98")]
	public void SetMidCapBoxWidth(float width) { }

	[Address(RVA = "0x3E3240", Offset = "0x3E2440", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B80")]
	public void SetMidCapColor(Color color) { }

	[Address(RVA = "0x3E3260", Offset = "0x3E2460", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8B")]
	public void SetMidCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x3E3280", Offset = "0x3E2480", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B84")]
	public void SetMidCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x524D90", Offset = "0x523F90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B9B")]
	public void SetMidCapSphereRadius(float radius) { }

	[Address(RVA = "0x3E32A0", Offset = "0x3E24A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B86")]
	public void SetMidCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x524DB0", Offset = "0x523FB0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B75")]
	public void SetNegativeCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x524DE0", Offset = "0x523FE0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B74")]
	public void SetNegativeSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x523010", Offset = "0x522210", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B73")]
	public void SetPositiveCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x524E10", Offset = "0x524010", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B72")]
	public void SetPositiveSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x524E60", Offset = "0x524060", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000B7B")]
	public void SetScale(float scale) { }

	[Address(RVA = "0x524E40", Offset = "0x524040", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B7D")]
	public void SetScaleGuideAxisLength(float length) { }

	[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B67")]
	public void SetScaleGuideVisible(bool isVisible) { }

	[Address(RVA = "0x517630", Offset = "0x516830", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8E")]
	public void SetSliderBoxCapDepth(float depth) { }

	[Address(RVA = "0x5176B0", Offset = "0x5168B0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8D")]
	public void SetSliderBoxCapHeight(float height) { }

	[Address(RVA = "0x517730", Offset = "0x516930", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8C")]
	public void SetSliderBoxCapWidth(float width) { }

	[Address(RVA = "0x5177B0", Offset = "0x5169B0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8A")]
	public void SetSliderCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x517810", Offset = "0x516A10", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B83")]
	public void SetSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x517870", Offset = "0x516A70", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B85")]
	public void SetSliderCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x524F60", Offset = "0x524160", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B71")]
	public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x517920", Offset = "0x516B20", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B90")]
	public void SetSliderConeCapBaseRadius(float radius) { }

	[Address(RVA = "0x5179A0", Offset = "0x516BA0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8F")]
	public void SetSliderConeCapHeight(float height) { }

	[Address(RVA = "0x517A20", Offset = "0x516C20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B89")]
	public void SetSliderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x517A80", Offset = "0x516C80", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B76")]
	public void SetSliderLength(float axisLength) { }

	[Address(RVA = "0x517AF0", Offset = "0x516CF0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B77")]
	public void SetSliderLineType(GizmoLine3DType lineType) { }

	[Address(RVA = "0x517B50", Offset = "0x516D50", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B93")]
	public void SetSliderPyramidCapDepth(float depth) { }

	[Address(RVA = "0x517BD0", Offset = "0x516DD0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B92")]
	public void SetSliderPyramidCapHeight(float height) { }

	[Address(RVA = "0x517C50", Offset = "0x516E50", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B91")]
	public void SetSliderPyramidCapWidth(float width) { }

	[Address(RVA = "0x517CD0", Offset = "0x516ED0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B82")]
	public void SetSliderShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x517D30", Offset = "0x516F30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B97")]
	public void SetSliderSphereCapRadius(float radius) { }

	[Address(RVA = "0x517DB0", Offset = "0x516FB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B96")]
	public void SetSliderTriPrismCapDepth(float depth) { }

	[Address(RVA = "0x517E30", Offset = "0x517030", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B95")]
	public void SetSliderTriPrismCapHeight(float height) { }

	[Address(RVA = "0x517EB0", Offset = "0x5170B0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B94")]
	public void SetSliderTriPrismCapWidth(float width) { }

	[Address(RVA = "0x524FB0", Offset = "0x5241B0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B70")]
	public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x525000", Offset = "0x524200", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B7C")]
	public void SetUseZoomFactor(bool useZoomFactor) { }

}

