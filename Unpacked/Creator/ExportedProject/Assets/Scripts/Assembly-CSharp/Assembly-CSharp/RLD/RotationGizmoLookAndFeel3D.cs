namespace RLD;

[Token(Token = "0x200010F")]
public class RotationGizmoLookAndFeel3D : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000497")]
	private bool _isMidCapVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000498")]
	private GizmoCap3DLookAndFeel _midCapLookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000499")]
	private Boolean[] _axesVis; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400049A")]
	private GizmoPlaneSlider3DLookAndFeel[] _axesLookAndFeel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400049B")]
	private bool _isCamLookSliderVisible; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400049C")]
	private float _camLookSliderRadiusOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400049D")]
	private GizmoPlaneSlider2DLookAndFeel _camLookSliderLookAndFeel; //Field offset: 0x50

	[Token(Token = "0x1700037A")]
	public GizmoFillMode3D AxisBorderFillMode
	{
		[Address(RVA = "0x523AB0", Offset = "0x522CB0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ACF")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000379")]
	public GizmoCircle3DBorderType AxisBorderType
	{
		[Address(RVA = "0x523AF0", Offset = "0x522CF0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ACE")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000377")]
	public float AxisCullAlphaScale
	{
		[Address(RVA = "0x523B30", Offset = "0x522D30", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ACC")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000376")]
	public float AxisCylTorusHeight
	{
		[Address(RVA = "0x523B70", Offset = "0x522D70", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ACB")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000375")]
	public float AxisCylTorusWidth
	{
		[Address(RVA = "0x523BB0", Offset = "0x522DB0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000ACA")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000374")]
	public float AxisTorusThickness
	{
		[Address(RVA = "0x523BF0", Offset = "0x522DF0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AC9")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000386")]
	public Color CamLookSliderBorderColor
	{
		[Address(RVA = "0x523C30", Offset = "0x522E30", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000ADB")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000387")]
	public Color CamLookSliderHoveredBorderColor
	{
		[Address(RVA = "0x523C60", Offset = "0x522E60", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000ADC")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000389")]
	public float CamLookSliderPolyBorderThickness
	{
		[Address(RVA = "0x523C90", Offset = "0x522E90", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000ADE")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000388")]
	public GizmoPolygon2DBorderType CamLookSliderPolyBorderType
	{
		[Address(RVA = "0x523CB0", Offset = "0x522EB0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000ADD")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000385")]
	public float CamLookSliderRadiusOffset
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ADA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000373")]
	public Color HoveredColor
	{
		[Address(RVA = "0x523CD0", Offset = "0x522ED0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AC8")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000382")]
	public Color HoveredMidCapColor
	{
		[Address(RVA = "0x523D10", Offset = "0x522F10", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000AD7")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700038A")]
	public bool IsCamLookSliderVisible
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ADF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000384")]
	public bool IsMidCapBorderVisible
	{
		[Address(RVA = "0x523D40", Offset = "0x522F40", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000AD9")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000383")]
	public bool IsMidCapVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700037F")]
	public bool IsRotationArcVisible
	{
		[Address(RVA = "0x523D60", Offset = "0x522F60", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AD4")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000381")]
	public Color MidCapBorderColor
	{
		[Address(RVA = "0x523DA0", Offset = "0x522FA0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD6")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000380")]
	public Color MidCapColor
	{
		[Address(RVA = "0x518DB0", Offset = "0x517FB0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD5")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700037B")]
	public int NumAxisTorusWireAxialSlices
	{
		[Address(RVA = "0x523DD0", Offset = "0x522FD0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AD0")]
		 get { } //Length: 47
	}

	[Token(Token = "0x1700036E")]
	public float Radius
	{
		[Address(RVA = "0x518E20", Offset = "0x518020", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC3")]
		 get { } //Length: 28
	}

	[Token(Token = "0x1700037D")]
	public Color RotationArcBorderColor
	{
		[Address(RVA = "0x523E00", Offset = "0x523000", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AD2")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700037C")]
	public Color RotationArcColor
	{
		[Address(RVA = "0x523E50", Offset = "0x523050", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AD1")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700036D")]
	public float Scale
	{
		[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC2")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000378")]
	public GizmoShadeMode ShadeMode
	{
		[Address(RVA = "0x518E00", Offset = "0x518000", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ACD")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700037E")]
	public bool UseShortestRotationArc
	{
		[Address(RVA = "0x523EA0", Offset = "0x5230A0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AD3")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700036F")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x519310", Offset = "0x518510", Length = "0x1B")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC4")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000370")]
	public Color XBorderColor
	{
		[Address(RVA = "0x523EE0", Offset = "0x5230E0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AC5")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000371")]
	public Color YBorderColor
	{
		[Address(RVA = "0x523F20", Offset = "0x523120", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AC6")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000372")]
	public Color ZBorderColor
	{
		[Address(RVA = "0x523F60", Offset = "0x523160", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AC7")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x5235D0", Offset = "0x5227D0", Length = "0x4D4")]
	[CalledBy(Type = typeof(RotationGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_NumBorderTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(GizmoPlaneSlider2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000AE0")]
	public RotationGizmoLookAndFeel3D() { }

	[Address(RVA = "0x522CA0", Offset = "0x521EA0", Length = "0x2C")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B01")]
	public void ConnectCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider) { }

	[Address(RVA = "0x5166A0", Offset = "0x5158A0", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B00")]
	public void ConnectMidCapLookAndFeel(GizmoCap3D cap) { }

	[Address(RVA = "0x522CD0", Offset = "0x521ED0", Length = "0x45")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AFF")]
	public void ConnectSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex) { }

	[Address(RVA = "0x523AB0", Offset = "0x522CB0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ACF")]
	public GizmoFillMode3D get_AxisBorderFillMode() { }

	[Address(RVA = "0x523AF0", Offset = "0x522CF0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ACE")]
	public GizmoCircle3DBorderType get_AxisBorderType() { }

	[Address(RVA = "0x523B30", Offset = "0x522D30", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ACC")]
	public float get_AxisCullAlphaScale() { }

	[Address(RVA = "0x523B70", Offset = "0x522D70", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ACB")]
	public float get_AxisCylTorusHeight() { }

	[Address(RVA = "0x523BB0", Offset = "0x522DB0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000ACA")]
	public float get_AxisCylTorusWidth() { }

	[Address(RVA = "0x523BF0", Offset = "0x522DF0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC9")]
	public float get_AxisTorusThickness() { }

	[Address(RVA = "0x523C30", Offset = "0x522E30", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ADB")]
	public Color get_CamLookSliderBorderColor() { }

	[Address(RVA = "0x523C60", Offset = "0x522E60", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ADC")]
	public Color get_CamLookSliderHoveredBorderColor() { }

	[Address(RVA = "0x523C90", Offset = "0x522E90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ADE")]
	public float get_CamLookSliderPolyBorderThickness() { }

	[Address(RVA = "0x523CB0", Offset = "0x522EB0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ADD")]
	public GizmoPolygon2DBorderType get_CamLookSliderPolyBorderType() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADA")]
	public float get_CamLookSliderRadiusOffset() { }

	[Address(RVA = "0x523CD0", Offset = "0x522ED0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC8")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x523D10", Offset = "0x522F10", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AD7")]
	public Color get_HoveredMidCapColor() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADF")]
	public bool get_IsCamLookSliderVisible() { }

	[Address(RVA = "0x523D40", Offset = "0x522F40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AD9")]
	public bool get_IsMidCapBorderVisible() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD8")]
	public bool get_IsMidCapVisible() { }

	[Address(RVA = "0x523D60", Offset = "0x522F60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AD4")]
	public bool get_IsRotationArcVisible() { }

	[Address(RVA = "0x523DA0", Offset = "0x522FA0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD6")]
	public Color get_MidCapBorderColor() { }

	[Address(RVA = "0x518DB0", Offset = "0x517FB0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD5")]
	public Color get_MidCapColor() { }

	[Address(RVA = "0x523DD0", Offset = "0x522FD0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AD0")]
	public int get_NumAxisTorusWireAxialSlices() { }

	[Address(RVA = "0x518E20", Offset = "0x518020", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC3")]
	public float get_Radius() { }

	[Address(RVA = "0x523E00", Offset = "0x523000", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AD2")]
	public Color get_RotationArcBorderColor() { }

	[Address(RVA = "0x523E50", Offset = "0x523050", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AD1")]
	public Color get_RotationArcColor() { }

	[Address(RVA = "0x518E60", Offset = "0x518060", Length = "0x1C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC2")]
	public float get_Scale() { }

	[Address(RVA = "0x518E00", Offset = "0x518000", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACD")]
	public GizmoShadeMode get_ShadeMode() { }

	[Address(RVA = "0x523EA0", Offset = "0x5230A0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AD3")]
	public bool get_UseShortestRotationArc() { }

	[Address(RVA = "0x519310", Offset = "0x518510", Length = "0x1B")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC4")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x523EE0", Offset = "0x5230E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC5")]
	public Color get_XBorderColor() { }

	[Address(RVA = "0x523F20", Offset = "0x523120", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC6")]
	public Color get_YBorderColor() { }

	[Address(RVA = "0x523F60", Offset = "0x523160", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AC7")]
	public Color get_ZBorderColor() { }

	[Address(RVA = "0x522D20", Offset = "0x521F20", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE1")]
	public bool IsAxisVisible(int axisIndex) { }

	[Address(RVA = "0x522D50", Offset = "0x521F50", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AF3")]
	public void SetAxisBorderColor(int axisIndex, Color color) { }

	[Address(RVA = "0x522D90", Offset = "0x521F90", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderCircleCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE9")]
	public void SetAxisBorderCullAlphaScale(float scale) { }

	[Address(RVA = "0x522E00", Offset = "0x522000", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE4")]
	public void SetAxisBorderFillMode(GizmoFillMode3D fillMode) { }

	[Address(RVA = "0x522E60", Offset = "0x522060", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEA")]
	public void SetAxisBorderType(GizmoCircle3DBorderType borderType) { }

	[Address(RVA = "0x522EC0", Offset = "0x5220C0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AED")]
	public void SetAxisCylTorusHeight(float height) { }

	[Address(RVA = "0x522F30", Offset = "0x522130", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEC")]
	public void SetAxisCylTorusWidth(float width) { }

	[Address(RVA = "0x522FA0", Offset = "0x5221A0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_BorderTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEB")]
	public void SetAxisTorusThickness(float thickness) { }

	[Address(RVA = "0x523010", Offset = "0x522210", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE2")]
	public void SetAxisVisible(int axisIndex, bool isVisible) { }

	[Address(RVA = "0x523040", Offset = "0x522240", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFA")]
	public void SetCamLookSliderBorderColor(Color color) { }

	[Address(RVA = "0x523060", Offset = "0x522260", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFB")]
	public void SetCamLookSliderHoveredBorderColor(Color color) { }

	[Address(RVA = "0x523080", Offset = "0x522280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AFE")]
	public void SetCamLookSliderPolyBorderThickness(float thickness) { }

	[Address(RVA = "0x5230A0", Offset = "0x5222A0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFD")]
	public void SetCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType) { }

	[Address(RVA = "0x5230C0", Offset = "0x5222C0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AF9")]
	public void SetCamLookSliderRadiusOffset(float offset) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFC")]
	public void SetCamLookSliderVisible(bool isVisible) { }

	[Address(RVA = "0x5230D0", Offset = "0x5222D0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF4")]
	public void SetHoveredColor(Color hoveredColor) { }

	[Address(RVA = "0x523120", Offset = "0x522320", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF0")]
	public void SetHoveredMidCapColor(Color color) { }

	[Address(RVA = "0x523140", Offset = "0x522340", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF2")]
	public void SetMidCapBorderColor(Color color) { }

	[Address(RVA = "0x523160", Offset = "0x522360", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF1")]
	public void SetMidCapBorderVisible(bool isVisible) { }

	[Address(RVA = "0x5173C0", Offset = "0x5165C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEF")]
	public void SetMidCapColor(Color color) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEE")]
	public void SetMidCapVisible(bool isVisible) { }

	[Address(RVA = "0x523180", Offset = "0x522380", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DLookAndFeel), Member = "set_NumBorderTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE5")]
	public void SetNumAxisTorusWireAxialSlices(int numSlices) { }

	[Address(RVA = "0x5231F0", Offset = "0x5223F0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = "set_SphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AE8")]
	public void SetRadius(float radius) { }

	[Address(RVA = "0x523280", Offset = "0x522480", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AF6")]
	public void SetRotationArcBorderColor(Color color) { }

	[Address(RVA = "0x523300", Offset = "0x522500", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AF5")]
	public void SetRotationArcColor(Color color) { }

	[Address(RVA = "0x523380", Offset = "0x522580", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AF8")]
	public void SetRotationArcVisible(bool isVisible) { }

	[Address(RVA = "0x5233F0", Offset = "0x5225F0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000AE7")]
	public void SetScale(float scale) { }

	[Address(RVA = "0x523480", Offset = "0x522680", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AE3")]
	public void SetShadeMode(GizmoShadeMode shadeMode) { }

	[Address(RVA = "0x5234F0", Offset = "0x5226F0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AF7")]
	public void SetUseShortestRotationArc(bool useShortest) { }

	[Address(RVA = "0x523570", Offset = "0x522770", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AE6")]
	public void SetUseZoomFactor(bool useZoomFactor) { }

}

