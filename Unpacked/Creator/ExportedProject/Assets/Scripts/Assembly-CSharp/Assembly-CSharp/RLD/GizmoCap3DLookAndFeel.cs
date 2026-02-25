namespace RLD;

[Token(Token = "0x2000022")]
public class GizmoCap3DLookAndFeel
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000083")]
	private GizmoCap3DType _capType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000084")]
	private GizmoFillMode3D _fillMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private GizmoShadeMode _shadeMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private float _scale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	private bool _useZoomFactor; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000088")]
	private float _coneHeight; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private float _coneRadius; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	private float _pyramidHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	private float _pyramidWidth; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400008C")]
	private float _pyramidDepth; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400008D")]
	private float _boxWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400008E")]
	private float _boxHeight; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400008F")]
	private float _boxDepth; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000090")]
	private float _sphereRadius; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000091")]
	private float _trPrismWidth; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private float _trPrismHeight; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000093")]
	private float _trPrismDepth; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private bool _isSphereBorderVisible; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private Color _sphereBorderColor; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000096")]
	private int _numSphereBorderPoints; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private Color _color; //Field offset: 0x6C
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x4000098")]
	private Color _hoveredColor; //Field offset: 0x7C

	[Token(Token = "0x17000035")]
	public float BoxDepth
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000111")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4400", Offset = "0x3B3600", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Token(Token = "0x6000112")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000034")]
	public float BoxHeight
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600010F")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4420", Offset = "0x3B3620", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Token(Token = "0x6000110")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000033")]
	public float BoxWidth
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600010D")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4440", Offset = "0x3B3640", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapBoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapBoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapBoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Token(Token = "0x600010E")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000029")]
	public GizmoCap3DType CapType
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003D")]
	public Color Color
	{
		[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000121")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4460", Offset = "0x3B3660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000122")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700002E")]
	public float ConeHeight
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000103")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4470", Offset = "0x3B3670", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Token(Token = "0x6000104")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700002F")]
	public float ConeRadius
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000105")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4490", Offset = "0x3B3690", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Token(Token = "0x6000106")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700003F")]
	public static float DefaultConeHeight
	{
		[Address(RVA = "0x3B4350", Offset = "0x3B3550", Length = "0x9")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000040")]
	public static float DefaultConeRadius
	{
		[Address(RVA = "0x3B4360", Offset = "0x3B3560", Length = "0x9")]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "get_AxisConeRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000126")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000043")]
	public static float DefaultPyramidDepth
	{
		[Address(RVA = "0x3B4370", Offset = "0x3B3570", Length = "0x9")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000129")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000041")]
	public static float DefaultPyramidHeight
	{
		[Address(RVA = "0x3B4350", Offset = "0x3B3550", Length = "0x9")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000127")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000042")]
	public static float DefaultPyramidWidth
	{
		[Address(RVA = "0x3B4370", Offset = "0x3B3570", Length = "0x9")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000128")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700002A")]
	public GizmoFillMode3D FillMode
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003E")]
	public Color HoveredColor
	{
		[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000123")]
		 get { } //Length: 11
		[Address(RVA = "0x3B44B0", Offset = "0x3B36B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700003A")]
	public bool IsSphereBorderVisible
	{
		[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011B")]
		 get { } //Length: 5
		[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003C")]
	public int NumSphereBorderPoints
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011F")]
		 get { } //Length: 4
		[Address(RVA = "0x3B44C0", Offset = "0x3B36C0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000120")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000032")]
	public float PyramidDepth
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600010B")]
		 get { } //Length: 6
		[Address(RVA = "0x3B44D0", Offset = "0x3B36D0", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x600010C")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000030")]
	public float PyramidHeight
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000107")]
		 get { } //Length: 6
		[Address(RVA = "0x3B44F0", Offset = "0x3B36F0", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x6000108")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000031")]
	public float PyramidWidth
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000109")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4510", Offset = "0x3B3710", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x600010A")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700002C")]
	public float Scale
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000100")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700002B")]
	public GizmoShadeMode ShadeMode
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003B")]
	public Color SphereBorderColor
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011D")]
		 get { } //Length: 11
		[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000036")]
	public float SphereRadius
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000113")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4550", Offset = "0x3B3750", Length = "0x14")]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Token(Token = "0x6000114")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000039")]
	public float TrPrismDepth
	{
		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000119")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4570", Offset = "0x3B3770", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x600011A")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000038")]
	public float TrPrismHeight
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000117")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4590", Offset = "0x3B3790", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x6000118")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000037")]
	public float TrPrismWidth
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000115")]
		 get { } //Length: 6
		[Address(RVA = "0x3B45B0", Offset = "0x3B37B0", Length = "0x14")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x6000116")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700002D")]
	public bool UseZoomFactor
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000101")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000102")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3B4260", Offset = "0x3B3460", Length = "0xB0")]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012A")]
	public GizmoCap3DLookAndFeel() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000111")]
	public float get_BoxDepth() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010F")]
	public float get_BoxHeight() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	public float get_BoxWidth() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F9")]
	public GizmoCap3DType get_CapType() { }

	[Address(RVA = "0x3B4340", Offset = "0x3B3540", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000121")]
	public Color get_Color() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	public float get_ConeHeight() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	public float get_ConeRadius() { }

	[Address(RVA = "0x3B4350", Offset = "0x3B3550", Length = "0x9")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	public static float get_DefaultConeHeight() { }

	[Address(RVA = "0x3B4360", Offset = "0x3B3560", Length = "0x9")]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "get_AxisConeRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000126")]
	public static float get_DefaultConeRadius() { }

	[Address(RVA = "0x3B4370", Offset = "0x3B3570", Length = "0x9")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000129")]
	public static float get_DefaultPyramidDepth() { }

	[Address(RVA = "0x3B4350", Offset = "0x3B3550", Length = "0x9")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000127")]
	public static float get_DefaultPyramidHeight() { }

	[Address(RVA = "0x3B4370", Offset = "0x3B3570", Length = "0x9")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000128")]
	public static float get_DefaultPyramidWidth() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FB")]
	public GizmoFillMode3D get_FillMode() { }

	[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000123")]
	public Color get_HoveredColor() { }

	[Address(RVA = "0x33C7E0", Offset = "0x33B9E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public bool get_IsSphereBorderVisible() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011F")]
	public int get_NumSphereBorderPoints() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010B")]
	public float get_PyramidDepth() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000107")]
	public float get_PyramidHeight() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	public float get_PyramidWidth() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FF")]
	public float get_Scale() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	public GizmoShadeMode get_ShadeMode() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011D")]
	public Color get_SphereBorderColor() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000113")]
	public float get_SphereRadius() { }

	[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000119")]
	public float get_TrPrismDepth() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000117")]
	public float get_TrPrismHeight() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000115")]
	public float get_TrPrismWidth() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000101")]
	public bool get_UseZoomFactor() { }

	[Address(RVA = "0x3B4400", Offset = "0x3B3600", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderBoxCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x6000112")]
	public void set_BoxDepth(float value) { }

	[Address(RVA = "0x3B4420", Offset = "0x3B3620", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderBoxCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x6000110")]
	public void set_BoxHeight(float value) { }

	[Address(RVA = "0x3B4440", Offset = "0x3B3640", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapBoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapBoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderBoxCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapBoxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x600010E")]
	public void set_BoxWidth(float value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FA")]
	public void set_CapType(GizmoCap3DType value) { }

	[Address(RVA = "0x3B4460", Offset = "0x3B3660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000122")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x3B4470", Offset = "0x3B3670", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderConeCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000104")]
	public void set_ConeHeight(float value) { }

	[Address(RVA = "0x3B4490", Offset = "0x3B3690", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderConeCapBaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000106")]
	public void set_ConeRadius(float value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public void set_FillMode(GizmoFillMode3D value) { }

	[Address(RVA = "0x3B44B0", Offset = "0x3B36B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000124")]
	public void set_HoveredColor(Color value) { }

	[Address(RVA = "0x33C800", Offset = "0x33BA00", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011C")]
	public void set_IsSphereBorderVisible(bool value) { }

	[Address(RVA = "0x3B44C0", Offset = "0x3B36C0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000120")]
	public void set_NumSphereBorderPoints(int value) { }

	[Address(RVA = "0x3B44D0", Offset = "0x3B36D0", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderPyramidCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x600010C")]
	public void set_PyramidDepth(float value) { }

	[Address(RVA = "0x3B44F0", Offset = "0x3B36F0", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderPyramidCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x6000108")]
	public void set_PyramidHeight(float value) { }

	[Address(RVA = "0x3B4510", Offset = "0x3B3710", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderPyramidCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x600010A")]
	public void set_PyramidWidth(float value) { }

	[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000100")]
	public void set_Scale(float value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	public void set_ShadeMode(GizmoShadeMode value) { }

	[Address(RVA = "0x3B4540", Offset = "0x3B3740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011E")]
	public void set_SphereBorderColor(Color value) { }

	[Address(RVA = "0x3B4550", Offset = "0x3B3750", Length = "0x14")]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScMidCapSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoLookAndFeel), Member = "OnScreenSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetMidCapSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoLookAndFeel3D), Member = "SetRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetMidCapSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderSphereCapRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetRtRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Token(Token = "0x6000114")]
	public void set_SphereRadius(float value) { }

	[Address(RVA = "0x3B4570", Offset = "0x3B3770", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderTriPrismCapDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x600011A")]
	public void set_TrPrismDepth(float value) { }

	[Address(RVA = "0x3B4590", Offset = "0x3B3790", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderTriPrismCapHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x6000118")]
	public void set_TrPrismHeight(float value) { }

	[Address(RVA = "0x3B45B0", Offset = "0x3B37B0", Length = "0x14")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "SetSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetMvSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "SetScSliderTriPrismCapWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "Inherit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x6000116")]
	public void set_TrPrismWidth(float value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000102")]
	public void set_UseZoomFactor(bool value) { }

}

