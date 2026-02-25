namespace RLD;

[Token(Token = "0x2000087")]
public class ObjectExtrudeGizmoLookAndFeel3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001DB")]
	private Color _boxWireColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001DC")]
	private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001DD")]
	private Boolean[] _extrudeSliderVis; //Field offset: 0x40

	[Token(Token = "0x17000167")]
	public Color BoxWireColor
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B5")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700016E")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3D8390", Offset = "0x3D7590", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BC")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000171")]
	public float SliderBoxCapDepth
	{
		[Address(RVA = "0x3D83D0", Offset = "0x3D75D0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004BF")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000170")]
	public float SliderBoxCapHeight
	{
		[Address(RVA = "0x3D8410", Offset = "0x3D7610", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004BE")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700016F")]
	public float SliderBoxCapWidth
	{
		[Address(RVA = "0x3D8450", Offset = "0x3D7650", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004BD")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700016A")]
	public GizmoFillMode3D SliderCapFillMode
	{
		[Address(RVA = "0x3D8490", Offset = "0x3D7690", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004B8")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000169")]
	public GizmoShadeMode SliderCapShadeMode
	{
		[Address(RVA = "0x3D84D0", Offset = "0x3D76D0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000168")]
	public GizmoCap3DType SliderCapType
	{
		[Address(RVA = "0x3D8510", Offset = "0x3D7710", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004B6")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000173")]
	public float SliderConeCapBaseRadius
	{
		[Address(RVA = "0x3D8550", Offset = "0x3D7750", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C1")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000172")]
	public float SliderConeCapHeight
	{
		[Address(RVA = "0x3D8590", Offset = "0x3D7790", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C0")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000176")]
	public float SliderPyramidCapDepth
	{
		[Address(RVA = "0x3D85D0", Offset = "0x3D77D0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C4")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000175")]
	public float SliderPyramidCapHeight
	{
		[Address(RVA = "0x3D8610", Offset = "0x3D7810", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C3")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000174")]
	public float SliderPyramidCapWidth
	{
		[Address(RVA = "0x3D8650", Offset = "0x3D7850", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C2")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700017A")]
	public float SliderSphereCapRadius
	{
		[Address(RVA = "0x3D8690", Offset = "0x3D7890", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C8")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000179")]
	public float SliderTriPrismCapDepth
	{
		[Address(RVA = "0x3D86D0", Offset = "0x3D78D0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000178")]
	public float SliderTriPrismCapHeight
	{
		[Address(RVA = "0x3D8710", Offset = "0x3D7910", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C6")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000177")]
	public float SliderTriPrismCapWidth
	{
		[Address(RVA = "0x3D8750", Offset = "0x3D7950", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004C5")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000166")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x3D8790", Offset = "0x3D7990", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004B4")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700016B")]
	public Color XColor
	{
		[Address(RVA = "0x3D87D0", Offset = "0x3D79D0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B9")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700016C")]
	public Color YColor
	{
		[Address(RVA = "0x3D8810", Offset = "0x3D7A10", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004BA")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700016D")]
	public Color ZColor
	{
		[Address(RVA = "0x3D8850", Offset = "0x3D7A50", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60004BB")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x3D7E90", Offset = "0x3D7090", Length = "0x4F8")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_AxisAlpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004C9")]
	public ObjectExtrudeGizmoLookAndFeel3D() { }

	[Address(RVA = "0x3D7480", Offset = "0x3D6680", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004DF")]
	public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B5")]
	public Color get_BoxWireColor() { }

	[Address(RVA = "0x3D8390", Offset = "0x3D7590", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BC")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x3D83D0", Offset = "0x3D75D0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004BF")]
	public float get_SliderBoxCapDepth() { }

	[Address(RVA = "0x3D8410", Offset = "0x3D7610", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004BE")]
	public float get_SliderBoxCapHeight() { }

	[Address(RVA = "0x3D8450", Offset = "0x3D7650", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004BD")]
	public float get_SliderBoxCapWidth() { }

	[Address(RVA = "0x3D8490", Offset = "0x3D7690", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004B8")]
	public GizmoFillMode3D get_SliderCapFillMode() { }

	[Address(RVA = "0x3D84D0", Offset = "0x3D76D0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004B7")]
	public GizmoShadeMode get_SliderCapShadeMode() { }

	[Address(RVA = "0x3D8510", Offset = "0x3D7710", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004B6")]
	public GizmoCap3DType get_SliderCapType() { }

	[Address(RVA = "0x3D8550", Offset = "0x3D7750", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C1")]
	public float get_SliderConeCapBaseRadius() { }

	[Address(RVA = "0x3D8590", Offset = "0x3D7790", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C0")]
	public float get_SliderConeCapHeight() { }

	[Address(RVA = "0x3D85D0", Offset = "0x3D77D0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C4")]
	public float get_SliderPyramidCapDepth() { }

	[Address(RVA = "0x3D8610", Offset = "0x3D7810", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C3")]
	public float get_SliderPyramidCapHeight() { }

	[Address(RVA = "0x3D8650", Offset = "0x3D7850", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C2")]
	public float get_SliderPyramidCapWidth() { }

	[Address(RVA = "0x3D8690", Offset = "0x3D7890", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C8")]
	public float get_SliderSphereCapRadius() { }

	[Address(RVA = "0x3D86D0", Offset = "0x3D78D0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C7")]
	public float get_SliderTriPrismCapDepth() { }

	[Address(RVA = "0x3D8710", Offset = "0x3D7910", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C6")]
	public float get_SliderTriPrismCapHeight() { }

	[Address(RVA = "0x3D8750", Offset = "0x3D7950", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C5")]
	public float get_SliderTriPrismCapWidth() { }

	[Address(RVA = "0x3D8790", Offset = "0x3D7990", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004B4")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x3D87D0", Offset = "0x3D79D0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B9")]
	public Color get_XColor() { }

	[Address(RVA = "0x3D8810", Offset = "0x3D7A10", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004BA")]
	public Color get_YColor() { }

	[Address(RVA = "0x3D8850", Offset = "0x3D7A50", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004BB")]
	public Color get_ZColor() { }

	[Address(RVA = "0x3D74E0", Offset = "0x3D66E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E0")]
	private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3D7530", Offset = "0x3D6730", Length = "0x54")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CA")]
	public bool IsExtrudeSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3D7590", Offset = "0x3D6790", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004DD")]
	public void SetAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CC")]
	public void SetBoxWireColor(Color color) { }

	[Address(RVA = "0x3D7660", Offset = "0x3D6860", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CB")]
	public void SetExtrudeSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x3D76B0", Offset = "0x3D68B0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DE")]
	public void SetHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x3D7710", Offset = "0x3D6910", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D0")]
	public void SetSliderBoxCapDepth(float depth) { }

	[Address(RVA = "0x3D7790", Offset = "0x3D6990", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004CF")]
	public void SetSliderBoxCapHeight(float height) { }

	[Address(RVA = "0x3D7810", Offset = "0x3D6A10", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004CE")]
	public void SetSliderBoxCapWidth(float width) { }

	[Address(RVA = "0x3D7890", Offset = "0x3D6A90", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DC")]
	public void SetSliderCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x3D78F0", Offset = "0x3D6AF0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DB")]
	public void SetSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x3D7950", Offset = "0x3D6B50", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004CD")]
	public void SetSliderCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x3D79B0", Offset = "0x3D6BB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D2")]
	public void SetSliderConeCapBaseRadius(float radius) { }

	[Address(RVA = "0x3D7A30", Offset = "0x3D6C30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D1")]
	public void SetSliderConeCapHeight(float height) { }

	[Address(RVA = "0x3D7AB0", Offset = "0x3D6CB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D5")]
	public void SetSliderPyramidCapDepth(float depth) { }

	[Address(RVA = "0x3D7B30", Offset = "0x3D6D30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D4")]
	public void SetSliderPyramidCapHeight(float height) { }

	[Address(RVA = "0x3D7BB0", Offset = "0x3D6DB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D3")]
	public void SetSliderPyramidCapWidth(float width) { }

	[Address(RVA = "0x3D7C30", Offset = "0x3D6E30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D9")]
	public void SetSliderSphereCapRadius(float radius) { }

	[Address(RVA = "0x3D7CB0", Offset = "0x3D6EB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D8")]
	public void SetSliderTriPrismCapDepth(float depth) { }

	[Address(RVA = "0x3D7D30", Offset = "0x3D6F30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D7")]
	public void SetSliderTriPrismCapHeight(float height) { }

	[Address(RVA = "0x3D7DB0", Offset = "0x3D6FB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D6")]
	public void SetSliderTriPrismCapWidth(float width) { }

	[Address(RVA = "0x3D7E30", Offset = "0x3D7030", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DA")]
	public void SetUseZoomFactor(bool useZoomFactor) { }

}

