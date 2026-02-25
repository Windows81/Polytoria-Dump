namespace RLD;

[Token(Token = "0x2000105")]
public class MoveGizmoLookAndFeel3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400045B")]
	private bool _isMidCapVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400045C")]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400045D")]
	private GizmoCap2DLookAndFeel _vertSnapCapLookAndFeel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400045E")]
	private Boolean[] _sglSliderVis; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400045F")]
	private Boolean[] _sglSliderCapVis; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000460")]
	private Boolean[] _dblSliderVis; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000461")]
	private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000462")]
	private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel; //Field offset: 0x60

	[Token(Token = "0x17000319")]
	public float BoxSliderDepth
	{
		[Address(RVA = "0x518A90", Offset = "0x517C90", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BA")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000318")]
	public float BoxSliderHeight
	{
		[Address(RVA = "0x518AD0", Offset = "0x517CD0", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B9")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700031A")]
	public float CylinderSliderRadius
	{
		[Address(RVA = "0x518B10", Offset = "0x517D10", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BB")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000332")]
	public float DblSliderBorderBoxDepth
	{
		[Address(RVA = "0x518B50", Offset = "0x517D50", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60009D3")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000331")]
	public float DblSliderBorderBoxHeight
	{
		[Address(RVA = "0x518B90", Offset = "0x517D90", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60009D2")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000336")]
	public GizmoFillMode3D DblSliderBorderFillMode
	{
		[Address(RVA = "0x518BD0", Offset = "0x517DD0", Length = "0x32")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60009D7")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000334")]
	public GizmoShadeMode DblSliderBorderShadeMode
	{
		[Address(RVA = "0x518C10", Offset = "0x517E10", Length = "0x32")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60009D5")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000335")]
	public GizmoQuad3DBorderType DblSliderBorderType
	{
		[Address(RVA = "0x518C50", Offset = "0x517E50", Length = "0x32")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60009D6")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000333")]
	public float DblSliderFillAlpha
	{
		[Address(RVA = "0x518C90", Offset = "0x517E90", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D4")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000330")]
	public float DblSliderSize
	{
		[Address(RVA = "0x518CD0", Offset = "0x517ED0", Length = "0x31")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60009D1")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000349")]
	public Color HoveredColor
	{
		[Address(RVA = "0x518D10", Offset = "0x517F10", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009EB")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000340")]
	public bool IsMidCapVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E1")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000343")]
	public float MidCapBoxDepth
	{
		[Address(RVA = "0x518D50", Offset = "0x517F50", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009E5")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000342")]
	public float MidCapBoxHeight
	{
		[Address(RVA = "0x518D70", Offset = "0x517F70", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009E4")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000341")]
	public float MidCapBoxWidth
	{
		[Address(RVA = "0x518D90", Offset = "0x517F90", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E3")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000345")]
	public Color MidCapColor
	{
		[Address(RVA = "0x518DB0", Offset = "0x517FB0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E7")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000346")]
	public GizmoFillMode3D MidCapFillMode
	{
		[Address(RVA = "0x518DE0", Offset = "0x517FE0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E8")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000347")]
	public GizmoShadeMode MidCapShadeMode
	{
		[Address(RVA = "0x518E00", Offset = "0x518000", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E9")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000344")]
	public float MidCapSphereRadius
	{
		[Address(RVA = "0x518E20", Offset = "0x518020", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E6")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000348")]
	public GizmoCap3DType MidCapType
	{
		[Address(RVA = "0x518E40", Offset = "0x518040", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009EA")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000315")]
	public float Scale
	{
		[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B6")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700031D")]
	public float SliderBoxCapDepth
	{
		[Address(RVA = "0x518E80", Offset = "0x518080", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BE")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700031C")]
	public float SliderBoxCapHeight
	{
		[Address(RVA = "0x518EC0", Offset = "0x5180C0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BD")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700031B")]
	public float SliderBoxCapWidth
	{
		[Address(RVA = "0x518F00", Offset = "0x518100", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BC")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000328")]
	public GizmoFillMode3D SliderCapFillMode
	{
		[Address(RVA = "0x518F40", Offset = "0x518140", Length = "0x38")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C9")]
		 get { } //Length: 56
	}

	[Token(Token = "0x1700032B")]
	public GizmoShadeMode SliderCapShadeMode
	{
		[Address(RVA = "0x518F80", Offset = "0x518180", Length = "0x38")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CC")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000329")]
	public GizmoCap3DType SliderCapType
	{
		[Address(RVA = "0x518FC0", Offset = "0x5181C0", Length = "0x38")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 56
	}

	[Token(Token = "0x1700031F")]
	public float SliderConeCapBaseRadius
	{
		[Address(RVA = "0x519000", Offset = "0x518200", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C0")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700031E")]
	public float SliderConeCapHeight
	{
		[Address(RVA = "0x519040", Offset = "0x518240", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BF")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000327")]
	public GizmoFillMode3D SliderFillMode
	{
		[Address(RVA = "0x519080", Offset = "0x518280", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C8")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000317")]
	public float SliderLength
	{
		[Address(RVA = "0x5190B0", Offset = "0x5182B0", Length = "0x31")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B8")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700032C")]
	public GizmoLine3DType SliderLineType
	{
		[Address(RVA = "0x5190F0", Offset = "0x5182F0", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CD")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000322")]
	public float SliderPyramidCapDepth
	{
		[Address(RVA = "0x519120", Offset = "0x518320", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C3")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000321")]
	public float SliderPyramidCapHeight
	{
		[Address(RVA = "0x519160", Offset = "0x518360", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C2")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000320")]
	public float SliderPyramidCapWidth
	{
		[Address(RVA = "0x5191A0", Offset = "0x5183A0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C1")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700032A")]
	public GizmoShadeMode SliderShadeMode
	{
		[Address(RVA = "0x5191E0", Offset = "0x5183E0", Length = "0x2F")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CB")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000326")]
	public float SliderSphereCapRadius
	{
		[Address(RVA = "0x519210", Offset = "0x518410", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C7")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000325")]
	public float SliderTriPrismCapDepth
	{
		[Address(RVA = "0x519250", Offset = "0x518450", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C6")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000324")]
	public float SliderTriPrismCapHeight
	{
		[Address(RVA = "0x519290", Offset = "0x518490", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C5")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000323")]
	public float SliderTriPrismCapWidth
	{
		[Address(RVA = "0x5192D0", Offset = "0x5184D0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C4")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000316")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x519310", Offset = "0x518510", Length = "0x1B")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B7")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700033B")]
	public Color VertSnapCapBorderColor
	{
		[Address(RVA = "0x519330", Offset = "0x518530", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009DC")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000339")]
	public float VertSnapCapCircleRadius
	{
		[Address(RVA = "0x519360", Offset = "0x518560", Length = "0x1C")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009DA")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700033A")]
	public Color VertSnapCapColor
	{
		[Address(RVA = "0x519380", Offset = "0x518580", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009DB")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700033E")]
	public GizmoFillMode2D VertSnapCapFillMode
	{
		[Address(RVA = "0x5193B0", Offset = "0x5185B0", Length = "0x1A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009DF")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700033D")]
	public Color VertSnapCapHoveredBorderColor
	{
		[Address(RVA = "0x5193D0", Offset = "0x5185D0", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009DE")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700033C")]
	public Color VertSnapCapHoveredColor
	{
		[Address(RVA = "0x519400", Offset = "0x518600", Length = "0x21")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009DD")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000338")]
	public float VertSnapCapQuadHeight
	{
		[Address(RVA = "0x519430", Offset = "0x518630", Length = "0x1C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D9")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000337")]
	public float VertSnapCapQuadWidth
	{
		[Address(RVA = "0x519450", Offset = "0x518650", Length = "0x1C")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009D8")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700033F")]
	public GizmoCap2DType VertSnapCapType
	{
		[Address(RVA = "0x519470", Offset = "0x518670", Length = "0x1A")]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009E0")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700032D")]
	public Color XColor
	{
		[Address(RVA = "0x519490", Offset = "0x518690", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CE")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700032E")]
	public Color YColor
	{
		[Address(RVA = "0x5194D0", Offset = "0x5186D0", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CF")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700032F")]
	public Color ZColor
	{
		[Address(RVA = "0x519510", Offset = "0x518710", Length = "0x3A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D0")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x518100", Offset = "0x517300", Length = "0x98B")]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_CenterAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_AxisAlpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GizmoCap2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x60009EC")]
	public MoveGizmoLookAndFeel3D() { }

	[Address(RVA = "0x516650", Offset = "0x515850", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A32")]
	public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId) { }

	[Address(RVA = "0x5166A0", Offset = "0x5158A0", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A33")]
	public void ConnectMidCapLookAndFeel(GizmoCap3D midCap) { }

	[Address(RVA = "0x5166D0", Offset = "0x5158D0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A31")]
	public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x516730", Offset = "0x515930", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A34")]
	public void ConnectVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap) { }

	[Address(RVA = "0x518A90", Offset = "0x517C90", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BA")]
	public float get_BoxSliderDepth() { }

	[Address(RVA = "0x518AD0", Offset = "0x517CD0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B9")]
	public float get_BoxSliderHeight() { }

	[Address(RVA = "0x518B10", Offset = "0x517D10", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BB")]
	public float get_CylinderSliderRadius() { }

	[Address(RVA = "0x518B50", Offset = "0x517D50", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D3")]
	public float get_DblSliderBorderBoxDepth() { }

	[Address(RVA = "0x518B90", Offset = "0x517D90", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D2")]
	public float get_DblSliderBorderBoxHeight() { }

	[Address(RVA = "0x518BD0", Offset = "0x517DD0", Length = "0x32")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D7")]
	public GizmoFillMode3D get_DblSliderBorderFillMode() { }

	[Address(RVA = "0x518C10", Offset = "0x517E10", Length = "0x32")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D5")]
	public GizmoShadeMode get_DblSliderBorderShadeMode() { }

	[Address(RVA = "0x518C50", Offset = "0x517E50", Length = "0x32")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D6")]
	public GizmoQuad3DBorderType get_DblSliderBorderType() { }

	[Address(RVA = "0x518C90", Offset = "0x517E90", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D4")]
	public float get_DblSliderFillAlpha() { }

	[Address(RVA = "0x518CD0", Offset = "0x517ED0", Length = "0x31")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009D1")]
	public float get_DblSliderSize() { }

	[Address(RVA = "0x518D10", Offset = "0x517F10", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009EB")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E1")]
	public bool get_IsMidCapVisible() { }

	[Address(RVA = "0x518D50", Offset = "0x517F50", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009E5")]
	public float get_MidCapBoxDepth() { }

	[Address(RVA = "0x518D70", Offset = "0x517F70", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009E4")]
	public float get_MidCapBoxHeight() { }

	[Address(RVA = "0x518D90", Offset = "0x517F90", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E3")]
	public float get_MidCapBoxWidth() { }

	[Address(RVA = "0x518DB0", Offset = "0x517FB0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E7")]
	public Color get_MidCapColor() { }

	[Address(RVA = "0x518DE0", Offset = "0x517FE0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E8")]
	public GizmoFillMode3D get_MidCapFillMode() { }

	[Address(RVA = "0x518E00", Offset = "0x518000", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E9")]
	public GizmoShadeMode get_MidCapShadeMode() { }

	[Address(RVA = "0x518E20", Offset = "0x518020", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E6")]
	public float get_MidCapSphereRadius() { }

	[Address(RVA = "0x518E40", Offset = "0x518040", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009EA")]
	public GizmoCap3DType get_MidCapType() { }

	[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B6")]
	public float get_Scale() { }

	[Address(RVA = "0x518E80", Offset = "0x518080", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BE")]
	public float get_SliderBoxCapDepth() { }

	[Address(RVA = "0x518EC0", Offset = "0x5180C0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BD")]
	public float get_SliderBoxCapHeight() { }

	[Address(RVA = "0x518F00", Offset = "0x518100", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BC")]
	public float get_SliderBoxCapWidth() { }

	[Address(RVA = "0x518F40", Offset = "0x518140", Length = "0x38")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C9")]
	public GizmoFillMode3D get_SliderCapFillMode() { }

	[Address(RVA = "0x518F80", Offset = "0x518180", Length = "0x38")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CC")]
	public GizmoShadeMode get_SliderCapShadeMode() { }

	[Address(RVA = "0x518FC0", Offset = "0x5181C0", Length = "0x38")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CA")]
	public GizmoCap3DType get_SliderCapType() { }

	[Address(RVA = "0x519000", Offset = "0x518200", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C0")]
	public float get_SliderConeCapBaseRadius() { }

	[Address(RVA = "0x519040", Offset = "0x518240", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BF")]
	public float get_SliderConeCapHeight() { }

	[Address(RVA = "0x519080", Offset = "0x518280", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C8")]
	public GizmoFillMode3D get_SliderFillMode() { }

	[Address(RVA = "0x5190B0", Offset = "0x5182B0", Length = "0x31")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B8")]
	public float get_SliderLength() { }

	[Address(RVA = "0x5190F0", Offset = "0x5182F0", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CD")]
	public GizmoLine3DType get_SliderLineType() { }

	[Address(RVA = "0x519120", Offset = "0x518320", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C3")]
	public float get_SliderPyramidCapDepth() { }

	[Address(RVA = "0x519160", Offset = "0x518360", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C2")]
	public float get_SliderPyramidCapHeight() { }

	[Address(RVA = "0x5191A0", Offset = "0x5183A0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C1")]
	public float get_SliderPyramidCapWidth() { }

	[Address(RVA = "0x5191E0", Offset = "0x5183E0", Length = "0x2F")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CB")]
	public GizmoShadeMode get_SliderShadeMode() { }

	[Address(RVA = "0x519210", Offset = "0x518410", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C7")]
	public float get_SliderSphereCapRadius() { }

	[Address(RVA = "0x519250", Offset = "0x518450", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C6")]
	public float get_SliderTriPrismCapDepth() { }

	[Address(RVA = "0x519290", Offset = "0x518490", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C5")]
	public float get_SliderTriPrismCapHeight() { }

	[Address(RVA = "0x5192D0", Offset = "0x5184D0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C4")]
	public float get_SliderTriPrismCapWidth() { }

	[Address(RVA = "0x519310", Offset = "0x518510", Length = "0x1B")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B7")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x519330", Offset = "0x518530", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DC")]
	public Color get_VertSnapCapBorderColor() { }

	[Address(RVA = "0x519360", Offset = "0x518560", Length = "0x1C")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DA")]
	public float get_VertSnapCapCircleRadius() { }

	[Address(RVA = "0x519380", Offset = "0x518580", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DB")]
	public Color get_VertSnapCapColor() { }

	[Address(RVA = "0x5193B0", Offset = "0x5185B0", Length = "0x1A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DF")]
	public GizmoFillMode2D get_VertSnapCapFillMode() { }

	[Address(RVA = "0x5193D0", Offset = "0x5185D0", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DE")]
	public Color get_VertSnapCapHoveredBorderColor() { }

	[Address(RVA = "0x519400", Offset = "0x518600", Length = "0x21")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009DD")]
	public Color get_VertSnapCapHoveredColor() { }

	[Address(RVA = "0x519430", Offset = "0x518630", Length = "0x1C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D9")]
	public float get_VertSnapCapQuadHeight() { }

	[Address(RVA = "0x519450", Offset = "0x518650", Length = "0x1C")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009D8")]
	public float get_VertSnapCapQuadWidth() { }

	[Address(RVA = "0x519470", Offset = "0x518670", Length = "0x1A")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009E0")]
	public GizmoCap2DType get_VertSnapCapType() { }

	[Address(RVA = "0x519490", Offset = "0x518690", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CE")]
	public Color get_XColor() { }

	[Address(RVA = "0x5194D0", Offset = "0x5186D0", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CF")]
	public Color get_YColor() { }

	[Address(RVA = "0x519510", Offset = "0x518710", Length = "0x3A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D0")]
	public Color get_ZColor() { }

	[Address(RVA = "0x516760", Offset = "0x515960", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F9")]
	public List<Enum> GetAllowedMidCapTypes() { }

	[Address(RVA = "0x5168E0", Offset = "0x515AE0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009EE")]
	public List<Enum> GetAllowedVertSnapCapTypes() { }

	[Address(RVA = "0x516A60", Offset = "0x515C60", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A36")]
	private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId) { }

	[Address(RVA = "0x516A90", Offset = "0x515C90", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A35")]
	private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x516AE0", Offset = "0x515CE0", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A01")]
	public bool IsDblSliderVisible(PlaneId planeId) { }

	[Address(RVA = "0x3E2E40", Offset = "0x3E2040", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F8")]
	public bool IsMidCapTypeAllowed(GizmoCap3DType capType) { }

	[Address(RVA = "0x516B10", Offset = "0x515D10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A06")]
	public bool IsNegativeSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x516B50", Offset = "0x515D50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A05")]
	public bool IsNegativeSliderVisible(int axisIndex) { }

	[Address(RVA = "0x514F30", Offset = "0x514130", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A04")]
	public bool IsPositiveSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x514F60", Offset = "0x514160", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A03")]
	public bool IsPositiveSliderVisible(int axisIndex) { }

	[Address(RVA = "0x516B90", Offset = "0x515D90", Length = "0x54")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A02")]
	public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3D7530", Offset = "0x3D6730", Length = "0x54")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A00")]
	public bool IsSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x4F9BF0", Offset = "0x4F8DF0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60009ED")]
	public bool IsVertSnapCapTypeAllowed(GizmoCap2DType capType) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E2")]
	public void set_IsMidCapVisible(bool value) { }

	[Address(RVA = "0x516BF0", Offset = "0x515DF0", Length = "0x174")]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A19")]
	public void SetAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x516D70", Offset = "0x515F70", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A14")]
	public void SetBoxSliderDepth(float depth) { }

	[Address(RVA = "0x516DE0", Offset = "0x515FE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A13")]
	public void SetBoxSliderHeight(float height) { }

	[Address(RVA = "0x516E50", Offset = "0x516050", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A15")]
	public void SetCylinderSliderRadius(float radius) { }

	[Address(RVA = "0x516EC0", Offset = "0x5160C0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A12")]
	public void SetDblSliderBorderBoxDepth(float depth) { }

	[Address(RVA = "0x516F30", Offset = "0x516130", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A11")]
	public void SetDblSliderBorderBoxHeight(float height) { }

	[Address(RVA = "0x516FA0", Offset = "0x5161A0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A24")]
	public void SetDblSliderBorderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x517000", Offset = "0x516200", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A1F")]
	public void SetDblSliderBorderShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x517060", Offset = "0x516260", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A10")]
	public void SetDblSliderBorderType(GizmoQuad3DBorderType borderType) { }

	[Address(RVA = "0x5170C0", Offset = "0x5162C0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A1A")]
	public void SetDblSliderFillAlpha(float alpha) { }

	[Address(RVA = "0x5171A0", Offset = "0x5163A0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000A16")]
	public void SetDblSliderSize(float size) { }

	[Address(RVA = "0x517230", Offset = "0x516430", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A08")]
	public void SetDblSliderVisible(PlaneId planeId, bool isVisible) { }

	[Address(RVA = "0x517260", Offset = "0x516460", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A1B")]
	public void SetHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x517360", Offset = "0x516560", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009FD")]
	public void SetMidCapBoxDepth(float depth) { }

	[Address(RVA = "0x517380", Offset = "0x516580", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009FC")]
	public void SetMidCapBoxHeight(float height) { }

	[Address(RVA = "0x5173A0", Offset = "0x5165A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009FB")]
	public void SetMidCapBoxWidth(float width) { }

	[Address(RVA = "0x5173C0", Offset = "0x5165C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009FF")]
	public void SetMidCapColor(Color color) { }

	[Address(RVA = "0x5173E0", Offset = "0x5165E0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A23")]
	public void SetMidCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x517400", Offset = "0x516600", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A1E")]
	public void SetMidCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x517420", Offset = "0x516620", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009FE")]
	public void SetMidCapSphereRadius(float radius) { }

	[Address(RVA = "0x517440", Offset = "0x516640", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009FA")]
	public void SetMidCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x517470", Offset = "0x516670", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A0D")]
	public void SetNegativeCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x5174A0", Offset = "0x5166A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0C")]
	public void SetNegativeSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x5174D0", Offset = "0x5166D0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0B")]
	public void SetPositiveCapVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x517500", Offset = "0x516700", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0A")]
	public void SetPositiveSliderVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x517530", Offset = "0x516730", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000A17")]
	public void SetScale(float scale) { }

	[Address(RVA = "0x517630", Offset = "0x516830", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A27")]
	public void SetSliderBoxCapDepth(float depth) { }

	[Address(RVA = "0x5176B0", Offset = "0x5168B0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A26")]
	public void SetSliderBoxCapHeight(float height) { }

	[Address(RVA = "0x517730", Offset = "0x516930", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_BoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A25")]
	public void SetSliderBoxCapWidth(float width) { }

	[Address(RVA = "0x5177B0", Offset = "0x5169B0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A22")]
	public void SetSliderCapFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x517810", Offset = "0x516A10", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A1D")]
	public void SetSliderCapShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x517870", Offset = "0x516A70", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A20")]
	public void SetSliderCapType(GizmoCap3DType capType) { }

	[Address(RVA = "0x5178D0", Offset = "0x516AD0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A09")]
	public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x517920", Offset = "0x516B20", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A29")]
	public void SetSliderConeCapBaseRadius(float radius) { }

	[Address(RVA = "0x5179A0", Offset = "0x516BA0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_ConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A28")]
	public void SetSliderConeCapHeight(float height) { }

	[Address(RVA = "0x517A20", Offset = "0x516C20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A21")]
	public void SetSliderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x517A80", Offset = "0x516C80", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0E")]
	public void SetSliderLength(float axisLength) { }

	[Address(RVA = "0x517AF0", Offset = "0x516CF0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0F")]
	public void SetSliderLineType(GizmoLine3DType lineType) { }

	[Address(RVA = "0x517B50", Offset = "0x516D50", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2C")]
	public void SetSliderPyramidCapDepth(float depth) { }

	[Address(RVA = "0x517BD0", Offset = "0x516DD0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2B")]
	public void SetSliderPyramidCapHeight(float height) { }

	[Address(RVA = "0x517C50", Offset = "0x516E50", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_PyramidWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2A")]
	public void SetSliderPyramidCapWidth(float width) { }

	[Address(RVA = "0x517CD0", Offset = "0x516ED0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A1C")]
	public void SetSliderShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x517D30", Offset = "0x516F30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A30")]
	public void SetSliderSphereCapRadius(float radius) { }

	[Address(RVA = "0x517DB0", Offset = "0x516FB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2F")]
	public void SetSliderTriPrismCapDepth(float depth) { }

	[Address(RVA = "0x517E30", Offset = "0x517030", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2E")]
	public void SetSliderTriPrismCapHeight(float height) { }

	[Address(RVA = "0x517EB0", Offset = "0x5170B0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_TrPrismWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2D")]
	public void SetSliderTriPrismCapWidth(float width) { }

	[Address(RVA = "0x3D7660", Offset = "0x3D6860", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A07")]
	public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x517F30", Offset = "0x517130", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000A18")]
	public void SetUseZoomFactor(bool useZoomFactor) { }

	[Address(RVA = "0x517FD0", Offset = "0x5171D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F5")]
	public void SetVertSnapCapBorderColor(Color color) { }

	[Address(RVA = "0x517FF0", Offset = "0x5171F0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F2")]
	public void SetVertSnapCapCircleRadius(float radius) { }

	[Address(RVA = "0x518010", Offset = "0x517210", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F4")]
	public void SetVertSnapCapColor(Color color) { }

	[Address(RVA = "0x518030", Offset = "0x517230", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F3")]
	public void SetVertSnapCapFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x518050", Offset = "0x517250", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F7")]
	public void SetVertSnapCapHoveredBorderColor(Color color) { }

	[Address(RVA = "0x518070", Offset = "0x517270", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F6")]
	public void SetVertSnapCapHoveredColor(Color color) { }

	[Address(RVA = "0x518090", Offset = "0x517290", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F1")]
	public void SetVertSnapCapQuadHeight(float height) { }

	[Address(RVA = "0x5180B0", Offset = "0x5172B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F0")]
	public void SetVertSnapCapQuadWidth(float width) { }

	[Address(RVA = "0x5180D0", Offset = "0x5172D0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009EF")]
	public void SetVertSnapCapType(GizmoCap2DType capType) { }

}

