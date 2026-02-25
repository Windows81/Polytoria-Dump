namespace RLD;

[Token(Token = "0x20000CE")]
public class GizmoPlaneSlider3DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000346")]
	private GizmoPlane3DType _planeType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000347")]
	private float _scale; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000348")]
	private bool _useZoomFactor; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000349")]
	private float _quadWidth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400034A")]
	private float _quadHeight; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400034B")]
	private float _raTriangleXLength; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400034C")]
	private float _raTriangleYLength; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400034D")]
	private float _circleRadius; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400034E")]
	private float _borderBoxHeight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400034F")]
	private float _borderBoxDepth; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000350")]
	private float _borderTorusThickness; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000351")]
	private int _numBorderTorusWireAxialSlices; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000352")]
	private float _borderCylTorusWidth; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000353")]
	private float _borderCylTorusHeight; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000354")]
	private GizmoShadeMode _shadeMode; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000355")]
	private Color _color; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x4000356")]
	private Color _hoveredColor; //Field offset: 0x5C
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000357")]
	private Color _borderColor; //Field offset: 0x6C
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x4000358")]
	private Color _hoveredBorderColor; //Field offset: 0x7C
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Token(Token = "0x4000359")]
	private float _borderCircleCullAlphaScale; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x400035A")]
	private GizmoShadeMode _borderShadeMode; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x400035B")]
	private GizmoFillMode3D _borderFillMode; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x400035C")]
	private GizmoQuad3DBorderType _quadBorderType; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	[Token(Token = "0x400035D")]
	private GizmoRATriangle3DBorderType _raTriangleBorderType; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x400035E")]
	private GizmoCircle3DBorderType _circleBorderType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[Token(Token = "0x400035F")]
	private bool _isRotationArcVisible; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000360")]
	private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel; //Field offset: 0xA8

	[Token(Token = "0x1700029E")]
	public float BorderBoxDepth
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000820")]
		 get { } //Length: 6
		[Address(RVA = "0x508EA0", Offset = "0x5080A0", Length = "0xF")]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetDblSliderBorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvDblSliderBorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000821")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700029D")]
	public float BorderBoxHeight
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081E")]
		 get { } //Length: 6
		[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081F")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700029C")]
	public float BorderCircleCullAlphaScale
	{
		[Address(RVA = "0x508E40", Offset = "0x508040", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081C")]
		 get { } //Length: 9
		[Address(RVA = "0x508EB0", Offset = "0x5080B0", Length = "0x27")]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetAxisBorderCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtAxisBorderCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x600081D")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002A5")]
	public Color BorderColor
	{
		[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082E")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4460", Offset = "0x3B3660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002A1")]
	public float BorderCylTorusHeight
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000826")]
		 get { } //Length: 6
		[Address(RVA = "0x3D0CB0", Offset = "0x3CFEB0", Length = "0xF")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000827")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002A0")]
	public float BorderCylTorusWidth
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000824")]
		 get { } //Length: 6
		[Address(RVA = "0x508EE0", Offset = "0x5080E0", Length = "0xF")]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetAxisCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtAxisCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000825")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002A8")]
	public GizmoFillMode3D BorderFillMode
	{
		[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000834")]
		 get { } //Length: 7
		[Address(RVA = "0x508EF0", Offset = "0x5080F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000835")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002A7")]
	public GizmoShadeMode BorderShadeMode
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000832")]
		 get { } //Length: 7
		[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000833")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700029F")]
	public float BorderTorusThickness
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000822")]
		 get { } //Length: 6
		[Address(RVA = "0x508F00", Offset = "0x508100", Length = "0xF")]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetAxisTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtAxisTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000823")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002AA")]
	public GizmoCircle3DBorderType CircleBorderType
	{
		[Address(RVA = "0x508E60", Offset = "0x508060", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000838")]
		 get { } //Length: 7
		[Address(RVA = "0x508F10", Offset = "0x508110", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000839")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700029B")]
	public float CircleRadius
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081A")]
		 get { } //Length: 6
		[Address(RVA = "0x3B21E0", Offset = "0x3B13E0", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081B")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002A3")]
	public Color Color
	{
		[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082A")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB60", Offset = "0x3E9D60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002A6")]
	public Color HoveredBorderColor
	{
		[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000830")]
		 get { } //Length: 11
		[Address(RVA = "0x3B44B0", Offset = "0x3B36B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000831")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002A4")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3EAB20", Offset = "0x3E9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082C")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB70", Offset = "0x3E9D70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002AC")]
	public bool IsRotationArcVisible
	{
		[Address(RVA = "0x508E70", Offset = "0x508070", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083C")]
		 get { } //Length: 8
		[Address(RVA = "0x508F20", Offset = "0x508120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002A2")]
	public int NumBorderTorusWireAxialSlices
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000828")]
		 get { } //Length: 4
		[Address(RVA = "0x508F30", Offset = "0x508130", Length = "0x10")]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetNumAxisTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtNumAxisTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Token(Token = "0x6000829")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000294")]
	public GizmoPlane3DType PlaneType
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080C")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002A9")]
	public GizmoQuad3DBorderType QuadBorderType
	{
		[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000836")]
		 get { } //Length: 7
		[Address(RVA = "0x508F40", Offset = "0x508140", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000837")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000298")]
	public float QuadHeight
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000814")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000815")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000297")]
	public float QuadWidth
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000812")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000813")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002AB")]
	public GizmoRATriangle3DBorderType RATriangleBorderType
	{
		[Address(RVA = "0x508E90", Offset = "0x508090", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083A")]
		 get { } //Length: 7
		[Address(RVA = "0x508F50", Offset = "0x508150", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083B")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000299")]
	public float RATriangleXLength
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000816")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2230", Offset = "0x3B1430", Length = "0xF")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000817")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700029A")]
	public float RATriangleYLength
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000818")]
		 get { } //Length: 6
		[Address(RVA = "0x3B21D0", Offset = "0x3B13D0", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000819")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002AD")]
	public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000295")]
	public float Scale
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080E")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080F")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000293")]
	public GizmoShadeMode ShadeMode
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080A")]
		 get { } //Length: 4
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000296")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000810")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000811")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x508D30", Offset = "0x507F30", Length = "0x110")]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600083F")]
	public GizmoPlaneSlider3DLookAndFeel() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000820")]
	public float get_BorderBoxDepth() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081E")]
	public float get_BorderBoxHeight() { }

	[Address(RVA = "0x508E40", Offset = "0x508040", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081C")]
	public float get_BorderCircleCullAlphaScale() { }

	[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082E")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000826")]
	public float get_BorderCylTorusHeight() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000824")]
	public float get_BorderCylTorusWidth() { }

	[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000834")]
	public GizmoFillMode3D get_BorderFillMode() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000832")]
	public GizmoShadeMode get_BorderShadeMode() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000822")]
	public float get_BorderTorusThickness() { }

	[Address(RVA = "0x508E60", Offset = "0x508060", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000838")]
	public GizmoCircle3DBorderType get_CircleBorderType() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081A")]
	public float get_CircleRadius() { }

	[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082A")]
	public Color get_Color() { }

	[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000830")]
	public Color get_HoveredBorderColor() { }

	[Address(RVA = "0x3EAB20", Offset = "0x3E9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082C")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x508E70", Offset = "0x508070", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083C")]
	public bool get_IsRotationArcVisible() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000828")]
	public int get_NumBorderTorusWireAxialSlices() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080C")]
	public GizmoPlane3DType get_PlaneType() { }

	[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000836")]
	public GizmoQuad3DBorderType get_QuadBorderType() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000814")]
	public float get_QuadHeight() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000812")]
	public float get_QuadWidth() { }

	[Address(RVA = "0x508E90", Offset = "0x508090", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083A")]
	public GizmoRATriangle3DBorderType get_RATriangleBorderType() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000816")]
	public float get_RATriangleXLength() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000818")]
	public float get_RATriangleYLength() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083E")]
	public GizmoRotationArc3DLookAndFeel get_RotationArcLookAndFeel() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080E")]
	public float get_Scale() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080A")]
	public GizmoShadeMode get_ShadeMode() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000810")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x508EA0", Offset = "0x5080A0", Length = "0xF")]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetDblSliderBorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvDblSliderBorderBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000821")]
	public void set_BorderBoxDepth(float value) { }

	[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081F")]
	public void set_BorderBoxHeight(float value) { }

	[Address(RVA = "0x508EB0", Offset = "0x5080B0", Length = "0x27")]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetAxisBorderCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtAxisBorderCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600081D")]
	public void set_BorderCircleCullAlphaScale(float value) { }

	[Address(RVA = "0x3B4460", Offset = "0x3B3660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082F")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x3D0CB0", Offset = "0x3CFEB0", Length = "0xF")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000827")]
	public void set_BorderCylTorusHeight(float value) { }

	[Address(RVA = "0x508EE0", Offset = "0x5080E0", Length = "0xF")]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetAxisCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtAxisCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000825")]
	public void set_BorderCylTorusWidth(float value) { }

	[Address(RVA = "0x508EF0", Offset = "0x5080F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000835")]
	public void set_BorderFillMode(GizmoFillMode3D value) { }

	[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000833")]
	public void set_BorderShadeMode(GizmoShadeMode value) { }

	[Address(RVA = "0x508F00", Offset = "0x508100", Length = "0xF")]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetAxisTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtAxisTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotationGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000823")]
	public void set_BorderTorusThickness(float value) { }

	[Address(RVA = "0x508F10", Offset = "0x508110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000839")]
	public void set_CircleBorderType(GizmoCircle3DBorderType value) { }

	[Address(RVA = "0x3B21E0", Offset = "0x3B13E0", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081B")]
	public void set_CircleRadius(float value) { }

	[Address(RVA = "0x3EAB60", Offset = "0x3E9D60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082B")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x3B44B0", Offset = "0x3B36B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000831")]
	public void set_HoveredBorderColor(Color value) { }

	[Address(RVA = "0x3EAB70", Offset = "0x3E9D70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600082D")]
	public void set_HoveredColor(Color value) { }

	[Address(RVA = "0x508F20", Offset = "0x508120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083D")]
	public void set_IsRotationArcVisible(bool value) { }

	[Address(RVA = "0x508F30", Offset = "0x508130", Length = "0x10")]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetNumAxisTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtNumAxisTorusWireAxialSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000829")]
	public void set_NumBorderTorusWireAxialSlices(int value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080D")]
	public void set_PlaneType(GizmoPlane3DType value) { }

	[Address(RVA = "0x508F40", Offset = "0x508140", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000837")]
	public void set_QuadBorderType(GizmoQuad3DBorderType value) { }

	[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000815")]
	public void set_QuadHeight(float value) { }

	[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000813")]
	public void set_QuadWidth(float value) { }

	[Address(RVA = "0x508F50", Offset = "0x508150", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083B")]
	public void set_RATriangleBorderType(GizmoRATriangle3DBorderType value) { }

	[Address(RVA = "0x3B2230", Offset = "0x3B1430", Length = "0xF")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000817")]
	public void set_RATriangleXLength(float value) { }

	[Address(RVA = "0x3B21D0", Offset = "0x3B13D0", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000819")]
	public void set_RATriangleYLength(float value) { }

	[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080F")]
	public void set_Scale(float value) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080B")]
	public void set_ShadeMode(GizmoShadeMode value) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000811")]
	public void set_UseZoomFactor(bool value) { }

}

