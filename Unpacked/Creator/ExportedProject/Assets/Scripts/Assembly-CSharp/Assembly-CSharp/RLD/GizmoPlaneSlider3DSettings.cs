namespace RLD;

[Token(Token = "0x20000CF")]
public class GizmoPlaneSlider3DSettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000361")]
	private float _areaHoverEps; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000362")]
	private float _extrudeHoverEps; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000363")]
	private float _borderLineHoverEps; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000364")]
	private float _borderBoxHoverEps; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000365")]
	private float _borderTorusHoverEps; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000366")]
	private bool _isCircleHoverCullEnabled; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000367")]
	private float _offsetSnapStepRight; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000368")]
	private float _offsetSnapStepUp; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000369")]
	private float _rotationSnapStep; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400036A")]
	private GizmoSnapMode _rotationSnapMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400036B")]
	private float _scaleSnapStepRight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400036C")]
	private float _scaleSnapStepUp; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400036D")]
	private float _proportionalScaleSnapStep; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400036E")]
	private float _offsetSensitivity; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400036F")]
	private float _rotationSensitivity; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000370")]
	private float _scaleSensitivity; //Field offset: 0x4C

	[Token(Token = "0x170002AE")]
	public float AreaHoverEps
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000840")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000841")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002B1")]
	public float BorderBoxHoverEps
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000846")]
		 get { } //Length: 6
		[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000847")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002B0")]
	public float BorderLineHoverEps
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000844")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000845")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002B2")]
	public float BorderTorusHoverEps
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000848")]
		 get { } //Length: 6
		[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000849")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002AF")]
	public float ExtrudeHoverEps
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000842")]
		 get { } //Length: 6
		[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000843")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170002B3")]
	public bool IsCircleHoverCullEnabled
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084A")]
		 get { } //Length: 5
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002BB")]
	public float OffsetSensitivity
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085A")]
		 get { } //Length: 6
		[Address(RVA = "0x508FD0", Offset = "0x5081D0", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085B")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002B4")]
	public float OffsetSnapStepRight
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084C")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084D")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002B5")]
	public float OffsetSnapStepUp
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084E")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084F")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002BA")]
	public float ProportionalScaleSnapStep
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000858")]
		 get { } //Length: 6
		[Address(RVA = "0x3F09A0", Offset = "0x3EFBA0", Length = "0x14")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000859")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002BC")]
	public float RotationSensitivity
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085C")]
		 get { } //Length: 6
		[Address(RVA = "0x508FF0", Offset = "0x5081F0", Length = "0x14")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085D")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002B7")]
	public GizmoSnapMode RotationSnapMode
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000852")]
		 get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000853")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002B6")]
	public float RotationSnapStep
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000850")]
		 get { } //Length: 6
		[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000851")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002BD")]
	public float ScaleSensitivity
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085E")]
		 get { } //Length: 6
		[Address(RVA = "0x509010", Offset = "0x508210", Length = "0x14")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085F")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002B8")]
	public float ScaleSnapStepRight
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000854")]
		 get { } //Length: 6
		[Address(RVA = "0x5047F0", Offset = "0x5039F0", Length = "0x14")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000855")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170002B9")]
	public float ScaleSnapStepUp
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000856")]
		 get { } //Length: 6
		[Address(RVA = "0x504810", Offset = "0x503A10", Length = "0x14")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000857")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x508F60", Offset = "0x508160", Length = "0x69")]
	[CalledBy(Type = typeof(MoveGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000860")]
	public GizmoPlaneSlider3DSettings() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000840")]
	public float get_AreaHoverEps() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000846")]
	public float get_BorderBoxHoverEps() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000844")]
	public float get_BorderLineHoverEps() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000848")]
	public float get_BorderTorusHoverEps() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000842")]
	public float get_ExtrudeHoverEps() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084A")]
	public bool get_IsCircleHoverCullEnabled() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085A")]
	public float get_OffsetSensitivity() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084C")]
	public float get_OffsetSnapStepRight() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084E")]
	public float get_OffsetSnapStepUp() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000858")]
	public float get_ProportionalScaleSnapStep() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085C")]
	public float get_RotationSensitivity() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000852")]
	public GizmoSnapMode get_RotationSnapMode() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000850")]
	public float get_RotationSnapStep() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085E")]
	public float get_ScaleSensitivity() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000854")]
	public float get_ScaleSnapStepRight() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000856")]
	public float get_ScaleSnapStepUp() { }

	[Address(RVA = "0x4FCB20", Offset = "0x4FBD20", Length = "0xF")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000841")]
	public void set_AreaHoverEps(float value) { }

	[Address(RVA = "0x3B4530", Offset = "0x3B3730", Length = "0xF")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000847")]
	public void set_BorderBoxHoverEps(float value) { }

	[Address(RVA = "0x3B2250", Offset = "0x3B1450", Length = "0xF")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000845")]
	public void set_BorderLineHoverEps(float value) { }

	[Address(RVA = "0x3B2240", Offset = "0x3B1440", Length = "0xF")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000849")]
	public void set_BorderTorusHoverEps(float value) { }

	[Address(RVA = "0x4FCB10", Offset = "0x4FBD10", Length = "0xF")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000843")]
	public void set_ExtrudeHoverEps(float value) { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084B")]
	public void set_IsCircleHoverCullEnabled(bool value) { }

	[Address(RVA = "0x508FD0", Offset = "0x5081D0", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085B")]
	public void set_OffsetSensitivity(float value) { }

	[Address(RVA = "0x4FA5C0", Offset = "0x4F97C0", Length = "0x14")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084D")]
	public void set_OffsetSnapStepRight(float value) { }

	[Address(RVA = "0x4FA5E0", Offset = "0x4F97E0", Length = "0x14")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084F")]
	public void set_OffsetSnapStepUp(float value) { }

	[Address(RVA = "0x3F09A0", Offset = "0x3EFBA0", Length = "0x14")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000859")]
	public void set_ProportionalScaleSnapStep(float value) { }

	[Address(RVA = "0x508FF0", Offset = "0x5081F0", Length = "0x14")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085D")]
	public void set_RotationSensitivity(float value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000853")]
	public void set_RotationSnapMode(GizmoSnapMode value) { }

	[Address(RVA = "0x4FA600", Offset = "0x4F9800", Length = "0x14")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000851")]
	public void set_RotationSnapStep(float value) { }

	[Address(RVA = "0x509010", Offset = "0x508210", Length = "0x14")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085F")]
	public void set_ScaleSensitivity(float value) { }

	[Address(RVA = "0x5047F0", Offset = "0x5039F0", Length = "0x14")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000855")]
	public void set_ScaleSnapStepRight(float value) { }

	[Address(RVA = "0x504810", Offset = "0x503A10", Length = "0x14")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000857")]
	public void set_ScaleSnapStepUp(float value) { }

}

