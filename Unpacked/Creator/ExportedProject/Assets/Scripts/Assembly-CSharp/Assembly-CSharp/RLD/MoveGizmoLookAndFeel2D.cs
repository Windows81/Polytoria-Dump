namespace RLD;

[Token(Token = "0x2000104")]
public class MoveGizmoLookAndFeel2D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000456")]
	private GizmoPlaneSlider2DLookAndFeel _dblSliderLookAndFeel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000457")]
	private GizmoLineSlider2DLookAndFeel[] _sglSliderLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000458")]
	private bool _isDblSliderVisible; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000459")]
	private Boolean[] _sglSliderVis; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400045A")]
	private Boolean[] _sglSliderCapVis; //Field offset: 0x48

	[Token(Token = "0x170002FB")]
	public float BoxSliderThickness
	{
		[Address(RVA = "0x5160E0", Offset = "0x5152E0", Length = "0x31")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000974")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000309")]
	public Color DblSliderBorderColor
	{
		[Address(RVA = "0x516120", Offset = "0x515320", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000982")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000303")]
	public float DblSliderCircleRadius
	{
		[Address(RVA = "0x516150", Offset = "0x515350", Length = "0x1C")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600097C")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000308")]
	public Color DblSliderColor
	{
		[Address(RVA = "0x516170", Offset = "0x515370", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000981")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000311")]
	public GizmoFillMode2D DblSliderFillMode
	{
		[Address(RVA = "0x3E3C60", Offset = "0x3E2E60", Length = "0x1A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600098A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700030B")]
	public Color DblSliderHoveredBorderColor
	{
		[Address(RVA = "0x5161A0", Offset = "0x5153A0", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000984")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700030A")]
	public Color DblSliderHoveredColor
	{
		[Address(RVA = "0x5161D0", Offset = "0x5153D0", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000983")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000314")]
	public GizmoPlane2DType DblSliderPlaneType
	{
		[Address(RVA = "0x516200", Offset = "0x515400", Length = "0x1A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600098D")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000302")]
	public float DblSliderQuadHeight
	{
		[Address(RVA = "0x516220", Offset = "0x515420", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600097B")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000301")]
	public float DblSliderQuadWidth
	{
		[Address(RVA = "0x516240", Offset = "0x515440", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600097A")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700030C")]
	public bool IsDblSliderVisible
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000985")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002F9")]
	public float Scale
	{
		[Address(RVA = "0x516260", Offset = "0x515460", Length = "0x31")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000972")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170002FD")]
	public float SliderArrowCapBaseRadius
	{
		[Address(RVA = "0x5162A0", Offset = "0x5154A0", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000976")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170002FC")]
	public float SliderArrowCapHeight
	{
		[Address(RVA = "0x5162E0", Offset = "0x5154E0", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000975")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000310")]
	public GizmoFillMode2D SliderCapFillMode
	{
		[Address(RVA = "0x516320", Offset = "0x515520", Length = "0x38")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000989")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000312")]
	public GizmoCap2DType SliderCapType
	{
		[Address(RVA = "0x516360", Offset = "0x515560", Length = "0x38")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600098B")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000300")]
	public float SliderCircleCapRadius
	{
		[Address(RVA = "0x5163A0", Offset = "0x5155A0", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000979")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700030F")]
	public GizmoFillMode2D SliderFillMode
	{
		[Address(RVA = "0x5163E0", Offset = "0x5155E0", Length = "0x2F")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000988")]
		 get { } //Length: 47
	}

	[Token(Token = "0x1700030E")]
	public Color SliderHoveredBorderColor
	{
		[Address(RVA = "0x516410", Offset = "0x515610", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000987")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700030D")]
	public Color SliderHoveredColor
	{
		[Address(RVA = "0x516450", Offset = "0x515650", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000986")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170002FA")]
	public float SliderLength
	{
		[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000973")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000313")]
	public GizmoLine2DType SliderLineType
	{
		[Address(RVA = "0x3E36D0", Offset = "0x3E28D0", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600098C")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170002FF")]
	public float SliderQuadCapHeight
	{
		[Address(RVA = "0x5164D0", Offset = "0x5156D0", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000978")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170002FE")]
	public float SliderQuadCapWidth
	{
		[Address(RVA = "0x516510", Offset = "0x515710", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000977")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000306")]
	public Color XBorderColor
	{
		[Address(RVA = "0x516550", Offset = "0x515750", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600097F")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000304")]
	public Color XColor
	{
		[Address(RVA = "0x516590", Offset = "0x515790", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600097D")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000307")]
	public Color YBorderColor
	{
		[Address(RVA = "0x5165D0", Offset = "0x5157D0", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000980")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000305")]
	public Color YColor
	{
		[Address(RVA = "0x516610", Offset = "0x515810", Length = "0x3A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600097E")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x515910", Offset = "0x514B10", Length = "0x7C6")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_AxisAlpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoPlaneSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLineSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600098E")]
	public MoveGizmoLookAndFeel2D() { }

	[Address(RVA = "0x514C50", Offset = "0x513E50", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009B4")]
	public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x514C80", Offset = "0x513E80", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009B3")]
	public void ConnectSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x5160E0", Offset = "0x5152E0", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000974")]
	public float get_BoxSliderThickness() { }

	[Address(RVA = "0x516120", Offset = "0x515320", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000982")]
	public Color get_DblSliderBorderColor() { }

	[Address(RVA = "0x516150", Offset = "0x515350", Length = "0x1C")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600097C")]
	public float get_DblSliderCircleRadius() { }

	[Address(RVA = "0x516170", Offset = "0x515370", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000981")]
	public Color get_DblSliderColor() { }

	[Address(RVA = "0x3E3C60", Offset = "0x3E2E60", Length = "0x1A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600098A")]
	public GizmoFillMode2D get_DblSliderFillMode() { }

	[Address(RVA = "0x5161A0", Offset = "0x5153A0", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000984")]
	public Color get_DblSliderHoveredBorderColor() { }

	[Address(RVA = "0x5161D0", Offset = "0x5153D0", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000983")]
	public Color get_DblSliderHoveredColor() { }

	[Address(RVA = "0x516200", Offset = "0x515400", Length = "0x1A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600098D")]
	public GizmoPlane2DType get_DblSliderPlaneType() { }

	[Address(RVA = "0x516220", Offset = "0x515420", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600097B")]
	public float get_DblSliderQuadHeight() { }

	[Address(RVA = "0x516240", Offset = "0x515440", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600097A")]
	public float get_DblSliderQuadWidth() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000985")]
	public bool get_IsDblSliderVisible() { }

	[Address(RVA = "0x516260", Offset = "0x515460", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000972")]
	public float get_Scale() { }

	[Address(RVA = "0x5162A0", Offset = "0x5154A0", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000976")]
	public float get_SliderArrowCapBaseRadius() { }

	[Address(RVA = "0x5162E0", Offset = "0x5154E0", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000975")]
	public float get_SliderArrowCapHeight() { }

	[Address(RVA = "0x516320", Offset = "0x515520", Length = "0x38")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000989")]
	public GizmoFillMode2D get_SliderCapFillMode() { }

	[Address(RVA = "0x516360", Offset = "0x515560", Length = "0x38")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600098B")]
	public GizmoCap2DType get_SliderCapType() { }

	[Address(RVA = "0x5163A0", Offset = "0x5155A0", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000979")]
	public float get_SliderCircleCapRadius() { }

	[Address(RVA = "0x5163E0", Offset = "0x5155E0", Length = "0x2F")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000988")]
	public GizmoFillMode2D get_SliderFillMode() { }

	[Address(RVA = "0x516410", Offset = "0x515610", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000987")]
	public Color get_SliderHoveredBorderColor() { }

	[Address(RVA = "0x516450", Offset = "0x515650", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000986")]
	public Color get_SliderHoveredColor() { }

	[Address(RVA = "0x516490", Offset = "0x515690", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000973")]
	public float get_SliderLength() { }

	[Address(RVA = "0x3E36D0", Offset = "0x3E28D0", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600098C")]
	public GizmoLine2DType get_SliderLineType() { }

	[Address(RVA = "0x5164D0", Offset = "0x5156D0", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000978")]
	public float get_SliderQuadCapHeight() { }

	[Address(RVA = "0x516510", Offset = "0x515710", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000977")]
	public float get_SliderQuadCapWidth() { }

	[Address(RVA = "0x516550", Offset = "0x515750", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600097F")]
	public Color get_XBorderColor() { }

	[Address(RVA = "0x516590", Offset = "0x515790", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600097D")]
	public Color get_XColor() { }

	[Address(RVA = "0x5165D0", Offset = "0x5157D0", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000980")]
	public Color get_YBorderColor() { }

	[Address(RVA = "0x516610", Offset = "0x515810", Length = "0x3A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600097E")]
	public Color get_YColor() { }

	[Address(RVA = "0x514CE0", Offset = "0x513EE0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000990")]
	public List<Enum> GetAllowedDblSliderPlaneTypes() { }

	[Address(RVA = "0x514E60", Offset = "0x514060", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B5")]
	private GizmoLineSlider2DLookAndFeel GetSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x4F9BF0", Offset = "0x4F8DF0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600098F")]
	public bool IsDblSliderPlaneTypeAllowed(GizmoPlane2DType planeType) { }

	[Address(RVA = "0x514EB0", Offset = "0x5140B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000998")]
	public bool IsNegativeSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x514EF0", Offset = "0x5140F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000994")]
	public bool IsNegativeSliderVisible(int axisIndex) { }

	[Address(RVA = "0x514F30", Offset = "0x514130", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000997")]
	public bool IsPositiveSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x514F60", Offset = "0x514160", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000993")]
	public bool IsPositiveSliderVisible(int axisIndex) { }

	[Address(RVA = "0x514F90", Offset = "0x514190", Length = "0x54")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000996")]
	public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x514FF0", Offset = "0x5141F0", Length = "0x54")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000992")]
	public bool IsSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x515050", Offset = "0x514250", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600099B")]
	public void SetAxisBorderColor(int axisIndex, Color color) { }

	[Address(RVA = "0x515120", Offset = "0x514320", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600099A")]
	public void SetAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x5151F0", Offset = "0x5143F0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A2")]
	public void SetBoxSliderThickness(float thickness) { }

	[Address(RVA = "0x515260", Offset = "0x514460", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009AF")]
	public void SetDblSliderBorderColor(Color color) { }

	[Address(RVA = "0x515280", Offset = "0x514480", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009AD")]
	public void SetDblSliderCircleRadius(float radius) { }

	[Address(RVA = "0x5152A0", Offset = "0x5144A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009AE")]
	public void SetDblSliderColor(Color color) { }

	[Address(RVA = "0x5152C0", Offset = "0x5144C0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600099F")]
	public void SetDblSliderFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x5152E0", Offset = "0x5144E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009B1")]
	public void SetDblSliderHoveredBorderColor(Color color) { }

	[Address(RVA = "0x515300", Offset = "0x514500", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009B0")]
	public void SetDblSliderHoveredColor(Color color) { }

	[Address(RVA = "0x3E3260", Offset = "0x3E2460", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AA")]
	public void SetDblSliderPlaneType(GizmoPlane2DType sliderType) { }

	[Address(RVA = "0x515320", Offset = "0x514520", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009AC")]
	public void SetDblSliderQuadHeight(float height) { }

	[Address(RVA = "0x515340", Offset = "0x514540", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009AB")]
	public void SetDblSliderQuadWidth(float width) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000991")]
	public void SetDblSliderVisible(bool isVisible) { }

	[Address(RVA = "0x515360", Offset = "0x514560", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60009B2")]
	public void SetScale(float scale) { }

	[Address(RVA = "0x515420", Offset = "0x514620", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009A5")]
	public void SetSliderArrowCapBaseRadius(float radius) { }

	[Address(RVA = "0x5154A0", Offset = "0x5146A0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009A6")]
	public void SetSliderArrowCapHeight(float height) { }

	[Address(RVA = "0x515520", Offset = "0x514720", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009A0")]
	public void SetSliderCapFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x515580", Offset = "0x514780", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009A4")]
	public void SetSliderCapType(GizmoCap2DType capType) { }

	[Address(RVA = "0x5155E0", Offset = "0x5147E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000999")]
	public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x515630", Offset = "0x514830", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009A9")]
	public void SetSliderCircleCapRadius(float radius) { }

	[Address(RVA = "0x3E30B0", Offset = "0x3E22B0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600099E")]
	public void SetSliderFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x515690", Offset = "0x514890", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600099D")]
	public void SetSliderHoveredBorderColor(Color color) { }

	[Address(RVA = "0x5156F0", Offset = "0x5148F0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600099C")]
	public void SetSliderHoveredFillColor(Color color) { }

	[Address(RVA = "0x515750", Offset = "0x514950", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A3")]
	public void SetSliderLength(float length) { }

	[Address(RVA = "0x3E3170", Offset = "0x3E2370", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A1")]
	public void SetSliderLineType(GizmoLine2DType lineType) { }

	[Address(RVA = "0x5157C0", Offset = "0x5149C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009A8")]
	public void SetSliderQuadCapHeight(float height) { }

	[Address(RVA = "0x515840", Offset = "0x514A40", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009A7")]
	public void SetSliderQuadCapWidth(float width) { }

	[Address(RVA = "0x5158C0", Offset = "0x514AC0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000995")]
	public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

}

