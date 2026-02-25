namespace RLD;

[Token(Token = "0x2000118")]
public class UniversalGizmoLookAndFeel2D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004FC")]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004FD")]
	private GizmoPlaneSlider2DLookAndFeel _mvDblSliderLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004FE")]
	private GizmoLineSlider2DLookAndFeel[] _mvSglSliderLookAndFeel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40004FF")]
	private bool _isMvDblSliderVisible; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000500")]
	private Boolean[] _mvSglSliderVis; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000501")]
	private Boolean[] _mvSglSliderCapVis; //Field offset: 0x50

	[Token(Token = "0x17000402")]
	public UniversalGizmoSettingsCategory DisplayCategory
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C1F")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C20")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003F9")]
	public bool IsMvDblSliderVisible
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C16")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003E8")]
	public float MvBoxSliderThickness
	{
		[Address(RVA = "0x4FA470", Offset = "0x4F9670", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C05")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003F6")]
	public Color MvDblSliderBorderColor
	{
		[Address(RVA = "0x523DA0", Offset = "0x522FA0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C13")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170003F0")]
	public float MvDblSliderCircleRadius
	{
		[Address(RVA = "0x52A530", Offset = "0x529730", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0D")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003F5")]
	public Color MvDblSliderColor
	{
		[Address(RVA = "0x52A550", Offset = "0x529750", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C12")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170003FE")]
	public GizmoFillMode2D MvDblSliderFillMode
	{
		[Address(RVA = "0x518E40", Offset = "0x518040", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C1B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003F8")]
	public Color MvDblSliderHoveredBorderColor
	{
		[Address(RVA = "0x52A580", Offset = "0x529780", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C15")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170003F7")]
	public Color MvDblSliderHoveredColor
	{
		[Address(RVA = "0x52A5B0", Offset = "0x5297B0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000C14")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000401")]
	public GizmoPlane2DType MvDblSliderPlaneType
	{
		[Address(RVA = "0x518DE0", Offset = "0x517FE0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C1E")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003EF")]
	public float MvDblSliderQuadHeight
	{
		[Address(RVA = "0x52A5E0", Offset = "0x5297E0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0C")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003EE")]
	public float MvDblSliderQuadWidth
	{
		[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0B")]
		 get { } //Length: 28
	}

	[Token(Token = "0x170003E6")]
	public float MvScale
	{
		[Address(RVA = "0x4FA3B0", Offset = "0x4F95B0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C03")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170003EA")]
	public float MvSliderArrowCapBaseRadius
	{
		[Address(RVA = "0x52A600", Offset = "0x529800", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C07")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003E9")]
	public float MvSliderArrowCapHeight
	{
		[Address(RVA = "0x52A640", Offset = "0x529840", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C06")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003FD")]
	public GizmoFillMode2D MvSliderCapFillMode
	{
		[Address(RVA = "0x52A680", Offset = "0x529880", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C1A")]
		 get { } //Length: 56
	}

	[Token(Token = "0x170003FF")]
	public GizmoCap2DType MvSliderCapType
	{
		[Address(RVA = "0x52A6C0", Offset = "0x5298C0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C1C")]
		 get { } //Length: 56
	}

	[Token(Token = "0x170003ED")]
	public float MvSliderCircleCapRadius
	{
		[Address(RVA = "0x52A700", Offset = "0x529900", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C0A")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003FC")]
	public GizmoFillMode2D MvSliderFillMode
	{
		[Address(RVA = "0x4FA4B0", Offset = "0x4F96B0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C19")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170003FB")]
	public Color MvSliderHoveredBorderColor
	{
		[Address(RVA = "0x52A740", Offset = "0x529940", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C18")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003FA")]
	public Color MvSliderHoveredColor
	{
		[Address(RVA = "0x52A780", Offset = "0x529980", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C17")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003E7")]
	public float MvSliderLength
	{
		[Address(RVA = "0x52A7C0", Offset = "0x5299C0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C04")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000400")]
	public GizmoLine2DType MvSliderLineType
	{
		[Address(RVA = "0x52A800", Offset = "0x529A00", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C1D")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170003EC")]
	public float MvSliderQuadCapHeight
	{
		[Address(RVA = "0x52A830", Offset = "0x529A30", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C09")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003EB")]
	public float MvSliderQuadCapWidth
	{
		[Address(RVA = "0x52A870", Offset = "0x529A70", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C08")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003F3")]
	public Color MvXBorderColor
	{
		[Address(RVA = "0x52A8B0", Offset = "0x529AB0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C10")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003F1")]
	public Color MvXColor
	{
		[Address(RVA = "0x52A8F0", Offset = "0x529AF0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C0E")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003F4")]
	public Color MvYBorderColor
	{
		[Address(RVA = "0x52A930", Offset = "0x529B30", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C11")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003F2")]
	public Color MvYColor
	{
		[Address(RVA = "0x52A970", Offset = "0x529B70", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000C0F")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x529D60", Offset = "0x528F60", Length = "0x7C6")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
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
	[Token(Token = "0x6000C21")]
	public UniversalGizmoLookAndFeel2D() { }

	[Address(RVA = "0x528AD0", Offset = "0x527CD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C45")]
	public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x528B00", Offset = "0x527D00", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C44")]
	public void ConnectMvSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C1F")]
	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C16")]
	public bool get_IsMvDblSliderVisible() { }

	[Address(RVA = "0x4FA470", Offset = "0x4F9670", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C05")]
	public float get_MvBoxSliderThickness() { }

	[Address(RVA = "0x523DA0", Offset = "0x522FA0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C13")]
	public Color get_MvDblSliderBorderColor() { }

	[Address(RVA = "0x52A530", Offset = "0x529730", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0D")]
	public float get_MvDblSliderCircleRadius() { }

	[Address(RVA = "0x52A550", Offset = "0x529750", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C12")]
	public Color get_MvDblSliderColor() { }

	[Address(RVA = "0x518E40", Offset = "0x518040", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C1B")]
	public GizmoFillMode2D get_MvDblSliderFillMode() { }

	[Address(RVA = "0x52A580", Offset = "0x529780", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C15")]
	public Color get_MvDblSliderHoveredBorderColor() { }

	[Address(RVA = "0x52A5B0", Offset = "0x5297B0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C14")]
	public Color get_MvDblSliderHoveredColor() { }

	[Address(RVA = "0x518DE0", Offset = "0x517FE0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C1E")]
	public GizmoPlane2DType get_MvDblSliderPlaneType() { }

	[Address(RVA = "0x52A5E0", Offset = "0x5297E0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0C")]
	public float get_MvDblSliderQuadHeight() { }

	[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0B")]
	public float get_MvDblSliderQuadWidth() { }

	[Address(RVA = "0x4FA3B0", Offset = "0x4F95B0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C03")]
	public float get_MvScale() { }

	[Address(RVA = "0x52A600", Offset = "0x529800", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C07")]
	public float get_MvSliderArrowCapBaseRadius() { }

	[Address(RVA = "0x52A640", Offset = "0x529840", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C06")]
	public float get_MvSliderArrowCapHeight() { }

	[Address(RVA = "0x52A680", Offset = "0x529880", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C1A")]
	public GizmoFillMode2D get_MvSliderCapFillMode() { }

	[Address(RVA = "0x52A6C0", Offset = "0x5298C0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C1C")]
	public GizmoCap2DType get_MvSliderCapType() { }

	[Address(RVA = "0x52A700", Offset = "0x529900", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C0A")]
	public float get_MvSliderCircleCapRadius() { }

	[Address(RVA = "0x4FA4B0", Offset = "0x4F96B0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C19")]
	public GizmoFillMode2D get_MvSliderFillMode() { }

	[Address(RVA = "0x52A740", Offset = "0x529940", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C18")]
	public Color get_MvSliderHoveredBorderColor() { }

	[Address(RVA = "0x52A780", Offset = "0x529980", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C17")]
	public Color get_MvSliderHoveredColor() { }

	[Address(RVA = "0x52A7C0", Offset = "0x5299C0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C04")]
	public float get_MvSliderLength() { }

	[Address(RVA = "0x52A800", Offset = "0x529A00", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C1D")]
	public GizmoLine2DType get_MvSliderLineType() { }

	[Address(RVA = "0x52A830", Offset = "0x529A30", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C09")]
	public float get_MvSliderQuadCapHeight() { }

	[Address(RVA = "0x52A870", Offset = "0x529A70", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C08")]
	public float get_MvSliderQuadCapWidth() { }

	[Address(RVA = "0x52A8B0", Offset = "0x529AB0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C10")]
	public Color get_MvXBorderColor() { }

	[Address(RVA = "0x52A8F0", Offset = "0x529AF0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C0E")]
	public Color get_MvXColor() { }

	[Address(RVA = "0x52A930", Offset = "0x529B30", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C11")]
	public Color get_MvYBorderColor() { }

	[Address(RVA = "0x52A970", Offset = "0x529B70", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C0F")]
	public Color get_MvYColor() { }

	[Address(RVA = "0x528B60", Offset = "0x527D60", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C47")]
	private GizmoLineSlider2DLookAndFeel GetMvSliderLookAndFeel(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x528BB0", Offset = "0x527DB0", Length = "0x8C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_DblSliderHoveredColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderQuadCapWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderQuadCapHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderHoveredColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderHoveredBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderFillMode", ReturnType = typeof(GizmoFillMode2D))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderCapType", ReturnType = typeof(GizmoCap2DType))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderCapFillMode", ReturnType = typeof(GizmoFillMode2D))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderCircleCapRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderArrowCapBaseRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_SliderArrowCapHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_DblSliderHoveredBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "IsSliderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_DblSliderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_DblSliderCircleRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_DblSliderBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_YColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "SetMvAxisColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_XColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_YBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "SetMvAxisBorderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = "get_XBorderColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Token(Token = "0x6000C46")]
	public void Inherit(MoveGizmoLookAndFeel2D lookAndFeel) { }

	[Address(RVA = "0x529480", Offset = "0x528680", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C29")]
	public bool IsMvNegativeSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x514EB0", Offset = "0x5140B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C25")]
	public bool IsMvNegativeSliderVisible(int axisIndex) { }

	[Address(RVA = "0x516AE0", Offset = "0x515CE0", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C28")]
	public bool IsMvPositiveSliderCapVisible(int axisIndex) { }

	[Address(RVA = "0x514F30", Offset = "0x514130", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C24")]
	public bool IsMvPositiveSliderVisible(int axisIndex) { }

	[Address(RVA = "0x5294C0", Offset = "0x5286C0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C27")]
	public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x514F90", Offset = "0x514190", Length = "0x54")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C23")]
	public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C20")]
	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	[Address(RVA = "0x529520", Offset = "0x528720", Length = "0xC3")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C2C")]
	public void SetMvAxisBorderColor(int axisIndex, Color color) { }

	[Address(RVA = "0x5295F0", Offset = "0x5287F0", Length = "0xC3")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C2B")]
	public void SetMvAxisColor(int axisIndex, Color color) { }

	[Address(RVA = "0x4F9E10", Offset = "0x4F9010", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C33")]
	public void SetMvBoxSliderThickness(float thickness) { }

	[Address(RVA = "0x523140", Offset = "0x522340", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C40")]
	public void SetMvDblSliderBorderColor(Color color) { }

	[Address(RVA = "0x5296C0", Offset = "0x5288C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C3E")]
	public void SetMvDblSliderCircleRadius(float radius) { }

	[Address(RVA = "0x5296E0", Offset = "0x5288E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C3F")]
	public void SetMvDblSliderColor(Color color) { }

	[Address(RVA = "0x529700", Offset = "0x528900", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C30")]
	public void SetMvDblSliderFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x529720", Offset = "0x528920", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C42")]
	public void SetMvDblSliderHoveredBorderColor(Color color) { }

	[Address(RVA = "0x529740", Offset = "0x528940", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C41")]
	public void SetMvDblSliderHoveredColor(Color color) { }

	[Address(RVA = "0x5173E0", Offset = "0x5165E0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C3B")]
	public void SetMvDblSliderPlaneType(GizmoPlane2DType sliderType) { }

	[Address(RVA = "0x529760", Offset = "0x528960", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C3D")]
	public void SetMvDblSliderQuadHeight(float height) { }

	[Address(RVA = "0x529780", Offset = "0x528980", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C3C")]
	public void SetMvDblSliderQuadWidth(float width) { }

	[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C22")]
	public void SetMvDblSliderVisible(bool isVisible) { }

	[Address(RVA = "0x5297A0", Offset = "0x5289A0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000C43")]
	public void SetMvScale(float scale) { }

	[Address(RVA = "0x529860", Offset = "0x528A60", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C36")]
	public void SetMvSliderArrowCapBaseRadius(float radius) { }

	[Address(RVA = "0x5298E0", Offset = "0x528AE0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C37")]
	public void SetMvSliderArrowCapHeight(float height) { }

	[Address(RVA = "0x529960", Offset = "0x528B60", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C31")]
	public void SetMvSliderCapFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x5299C0", Offset = "0x528BC0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C35")]
	public void SetMvSliderCapType(GizmoCap2DType capType) { }

	[Address(RVA = "0x529A20", Offset = "0x528C20", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C2A")]
	public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

	[Address(RVA = "0x529A70", Offset = "0x528C70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C3A")]
	public void SetMvSliderCircleCapRadius(float radius) { }

	[Address(RVA = "0x4F9E80", Offset = "0x4F9080", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2F")]
	public void SetMvSliderFillMode(GizmoFillMode2D fillMode) { }

	[Address(RVA = "0x529AD0", Offset = "0x528CD0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C2E")]
	public void SetMvSliderHoveredBorderColor(Color color) { }

	[Address(RVA = "0x529B30", Offset = "0x528D30", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C2D")]
	public void SetMvSliderHoveredFillColor(Color color) { }

	[Address(RVA = "0x529B90", Offset = "0x528D90", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C34")]
	public void SetMvSliderLength(float length) { }

	[Address(RVA = "0x529C00", Offset = "0x528E00", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C32")]
	public void SetMvSliderLineType(GizmoLine2DType lineType) { }

	[Address(RVA = "0x529C60", Offset = "0x528E60", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C39")]
	public void SetMvSliderQuadCapHeight(float height) { }

	[Address(RVA = "0x529CE0", Offset = "0x528EE0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C38")]
	public void SetMvSliderQuadCapWidth(float width) { }

	[Address(RVA = "0x5155E0", Offset = "0x5147E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C26")]
	public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) { }

}

